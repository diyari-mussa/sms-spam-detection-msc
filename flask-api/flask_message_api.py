# needed libraries for ML
import numpy as np
import pandas as pd
import string
import time
import re

# needed libraries for flask server
from flask import Flask, jsonify, request
app = Flask(__name__)   # define app using flask

# Api Function
@app.route('/messages')
def params():
    id = request.args['id']
    msg = request.args['msg']
    if(lightGBM_predictor(msg) == '1'):
        return jsonify([{'id' : id,'message' : 'spam'}])
    else:
        return jsonify([{'id' : id,'message' : 'ham'}])


# lightGBM Classifier Function
def lightGBM_predictor(rcvedTextMessage):

    df = pd.read_csv(r"C:\Users\OMEN\Machine Learning Kaggles\Data sets\SMSSpamCollectionfixed.csv", encoding='utf8', delimiter='\t')
    df = df.rename(columns = {'v1':'label','v2':'message'})

    from sklearn.preprocessing import LabelEncoder
    encoder = LabelEncoder()
    df['label'] = encoder.fit_transform(df['label'])

    # non-alphanumeric characters (numeric)
    df['feature3'] = df['message'].str.findall(r'[^a-zA-Z0-9 ]').str.len()

    # alphanumeric words (numeric)
    df['feature4'] = df['message'].str.findall(r'(?:[0-9][^ ]*[A-Za-z][^ ]*)|(?:[A-Za-z][^ ]*[0-9][^ ]*)').str.len()

    # upper case letter length (numeric)
    df['feature6'] = [sum([c.isupper() for c in a]) for a in df['message']]

    
    # collumn includes mathmatical symbols (binary)
    df['feature8'] = np.where(df['message'].str.contains(r'\+|\-|<|>|/|\^', regex=True), 1, 0)

    # collumn corrisponds to having URL (www, http, https) in the message (binary)
    df['feature9'] = np.where(df['message'].str.contains(r'(?i)\bhttp[s]?[:]?[//]?[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|www\.[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|http[\s]|.co.uk', regex=True), 1, 0)

    # collumn corrisponds to having phone number in the message (binary)
    df['feature15'] = np.where(df['message'].str.contains(r'[+]?\(?[\d]{3,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{4,7}|[+]?\(?[\d]{1,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{3,4}[\s-][\d]{3,4}\b', regex=True), 1, 0)

    # Currency (£, $, €, ¥)(binary)
    df['feature22'] = np.where(df['message'].str.contains(r'£|\$|\€|\¥|\₣|\₹|\₩|\₦|\₽|\₺|\₴|\₿|\ɱ|\Ł|\Ξ', regex=True), 1, 0)

    # service numbers (short string numbers)
    df['feature23'] = np.where(df['message'].str.contains(r'\b\d{5}\b|\b\d{4}\b|\b\d{6}\b', regex=True), 1, 0)

    # currency in word (symbol in word)
    df['feature24'] = np.where(df['message'].str.contains(r'(?i)\d+[\s]?pound|\d+[\s]?p\b|\d+[\s]?pence\b|gbp|\d+[\s]?USD\b|\d+[\s]?dollar\b', regex=True), 1, 0)

    # spam keywords
    Search_for_spam_words = ['free', 'ringtone', 'claim', 'txt ', 'text', 'reply', 'nokia',
                              'win ', 'video', 'mobile', 'award','dating','won ','lottery','entitled'] #creating list

    pattern = '|'.join(Search_for_spam_words)

    df['message'] = df['message'].str.lower()
    # count of spam words
    df['feature25']= df['message'].str.findall(pattern).str.len()


    # X is our feature data
    X = df[['feature3','feature4','feature6','feature8','feature9','feature15','feature22','feature23','feature24','feature25']]

    # y is our label
    y = df['label']


    # learning using lightGBM classifier
    from lightgbm import LGBMClassifier
    lgb_model = LGBMClassifier()

    clf_lgbm = lgb_model.fit(X,y)


    # array to hold the values of features
    features_array = []

    # non-alphanumeric characters  (numeric)
    features_array.append(len(re.findall(r'[^a-zA-Z0-9 ]', rcvedTextMessage)))

    # alphanumeric words (numeric)
    features_array.append(len(re.findall(r'(?:[0-9][^ ]*[A-Za-z][^ ]*)|(?:[A-Za-z][^ ]*[0-9][^ ]*)', rcvedTextMessage)))

    # upper case letter length (numeric)
    features_array.append(sum([c.isupper() for c in rcvedTextMessage]))

    # collumn includes mathmatical symbols (binary)
    if re.search(re.compile(r'\+|\-|<|>|/|\^'), rcvedTextMessage):
        features_array.append(1)
    else:
        features_array.append(0)

    # collumn corrisponds to having URL (www, http, https) in the message (binary)
    if re.search(re.compile(r'(?i)\bhttp[s]?[:]?[//]?[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|www\.[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|http[\s]|.co.uk'), rcvedTextMessage):
        features_array.append(1)
    else:
        features_array.append(0)

    # collumn corrisponds to having phone number in the message (binary)
    if re.search(re.compile(r'[+]?\(?[\d]{3,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{4,7}|[+]?\(?[\d]{1,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{3,4}[\s-][\d]{3,4}\b'), rcvedTextMessage):
        features_array.append(1)
    else:
        features_array.append(0)

    # Currency (£, $, €, ¥)(binary)
    if re.search(re.compile(r'£|\$|\€|\¥|\₣|\₹|\₩|\₦|\₽|\₺|\₴|\₿|\ɱ|\Ł|\Ξ'), rcvedTextMessage):
        features_array.append(1)
    else:
        features_array.append(0)

    # service numbers (short string numbers)
    if re.search(re.compile(r'\b\d{5}\b|\b\d{4}\b|\b\d{6}\b'), rcvedTextMessage):
        features_array.append(1)
    else:
        features_array.append(0)

    # currency in word (symbol in word)
    if re.search(re.compile(r'(?i)\d+[\s]?pound|\d+[\s]?p\b|\d+[\s]?pence\b|gbp|\d+[\s]?USD\b|\d+[\s]?dollar\b'), rcvedTextMessage):
        features_array.append(1)
    else:
        features_array.append(0)

    # spam keywords
    Search_for_spam_words = ['free', 'ringtone', 'claim', 'txt ', 'text', 'reply', 'nokia',
                              'win ', 'video', 'mobile', 'award','dating','won ','lottery','entitled'] #creating list

    pattern = '|'.join(Search_for_spam_words)

    result = re.findall(pattern, rcvedTextMessage.lower())
    features_array.append(len(result))

    # convert to numpy array
    features_np = np.array(features_array)
    features_df=pd.DataFrame(features_np) 
    features_df = features_df.transpose()
    features_df = features_df.rename(columns={0: 'feature3', 1: 'feature4', 2: 'feature6', 3: 'feature8', 4: 'feature9', 5: 'feature15', 6: 'feature22', 7: 'feature23', 8: 'feature24', 9:'feature25'})

    # classifer prediction
    clf_lgbm_list = clf_lgbm.predict(features_df)
    clf_lgbm_str = ' '.join([str(elem) for elem in clf_lgbm_list])

    return clf_lgbm_str


# Main Function
if __name__ == '__main__':
    app.run(debug=True, port=9090)

