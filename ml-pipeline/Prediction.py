import numpy as np
import pandas as pd
import string
import time 

import sys

from sklearn.preprocessing import LabelEncoder


# initializing arguments
datasetPath = sys.argv[1]
datasetContent = sys.argv[2]
missingValue = sys.argv[3]
datasetColRename = sys.argv[4]
column_class = sys.argv[5]
column_message = sys.argv[6]
column_purpose = sys.argv[7]
classDistribution = sys.argv[8]
calssEncoding = sys.argv[9]
showUsefulInfo = sys.argv[10]

selectedFeatNames = sys.argv[11]

# classification
showGbmEvaluation = sys.argv[12]
showXgbEvaluation = sys.argv[13]
showLgbmEvaluation = sys.argv[14]

# variables initialization
dashLine = "---------------"

# 1. data preparation and analysis

# reading sms messages dataset 
df = pd.read_csv(r"" + datasetPath, encoding='utf8', delimiter='\t')
if datasetContent == '1':
	print('- Top 15 rows :')
	print(df.head(15))
	print('......')
	print('- Last 15 rows :')
	print(df.tail(15))
	print(dashLine)

# chekcing for missing value
if missingValue == '1':
	print(df.isnull().sum())
	print(dashLine)
	
# rename columns
df = df.rename(columns = {'v1':column_class,'v2':column_message,'v3':column_purpose})
if datasetColRename == '1':
	print(df.head())
	print(dashLine)
	
# checking class distribution
classes = df[column_class]
if classDistribution == '1':
	print(classes.value_counts())
	print(dashLine)

# encoding class 
encoder = LabelEncoder()
df[column_class] = encoder.fit_transform(df[column_class])
if calssEncoding == '1':
	print(df.head())
	print(dashLine)

# cleaned dataset and show all useful information before feature extraction
if showUsefulInfo == '1':
	print(df.info())
	print(dashLine)


#---------------------------------------------------------------------------
# Extraction of all features
#---------------------------------------------------------------------------
	
# determining number of the message length (numeric)
df['feature1'] = df[column_message].str.len()

# Count of “/” slash (numeric)
df['feature2'] = df[column_message].str.findall(r'/').str.len()

# non-alphanumeric characters (punctuations) (numeric)
df['feature3'] = df[column_message].str.findall(r'[^a-zA-Z0-9 ]').str.len()

# alphanumeric words (numeric)
df['feature4'] = df[column_message].str.findall(r'(?:[0-9][^ ]*[A-Za-z][^ ]*)|(?:[A-Za-z][^ ]*[0-9][^ ]*)').str.len()

# Count of numeric words (numeric)
df['feature5'] = df[column_message].str.findall(r'\d+(\.\d+)?').str.len()

# upper case letter length (numeric)
df['feature6'] = [sum([c.isupper() for c in a]) for a in df[column_message]]

# Number of words (numeric)
df['feature7'] = df[column_message].str.findall(r'([^\s][a-zA-Z]+)').str.len()


# collumn includes mathmatical symbols (binary)
df['feature8'] = np.where(df[column_message].str.contains(r'\+|\-|<|>|/|\^', regex=True), 1, 0)

# collumn corrisponds to having URL (www, http, https) in the message (binary)
df['feature9'] = np.where(df[column_message].str.contains(r'(?i)\bhttp[s]?[:]?[//]?[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|www\.[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|http[\s]|.co.uk', regex=True), 1, 0)

# collumn dots (binary)
df['feature10'] = np.where(df[column_message].str.contains(r'\.', regex=True), 1, 0)
	
# collumn corrisponds to having special symbol in the message (binary)
df['feature11'] = np.where(df[column_message].str.contains(r'£|\$|!|\*|&|#|~', regex=True), 1, 0)

# collumn corrisponds of having emotionss in the message (binary)
df['feature12'] = np.where(df[column_message].str.contains(r':\)|:-\)|:\(|:-\(|;\);-\)|:-O|:P|:D|:\||:\$|:@|8o\||\+o\(|\(H\)|\(C\)|\(\?\)|;\)|-_-|:\*|:o|:\'\(|:V|:3|\*\^\*|xD|<3|-\.-|,-\)|\(:-\(|\(:-\)|\'-\)|:-#|:-\/|:->|:-@|:-d|:-V|:-X|:-]|;-\(|;\^\)|8:-\)|8:-\)', regex=True), 1, 0)

# collumn Lowercase words (binary)
df['feature13'] = np.where(df[column_message].str.contains(r'\b[a-z]+\b', regex=True), 1, 0)

# collumn Uppercase words (binary)
df['feature14'] = np.where(df[column_message].str.contains(r'\b[A-Z]{2,20}\b', regex=True), 1, 0)

# collumn corrisponds to having phone number in the message (binary)
df['feature15'] = np.where(df[column_message].str.contains(r'[+]?\(?[\d]{3,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{4,7}|[+]?\(?[\d]{1,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{3,4}[\s-][\d]{3,4}\b', regex=True), 1, 0)

# Currency (£, $, €, ¥) + number
df['feature16'] = np.where(df[column_message].str.contains(r'[£|\$|\€|\¥][\s]?\d+[\.]?\d+', regex=True), 1, 0)

# Number+% or number + percent
df['feature17'] = np.where(df[column_message].str.contains(r'(?i)\d+[\.]?\d+[\s]?%|\d+[\.]?\d+[\s]?percent|%[\s]?\d+[\.]?\d+', regex=True), 1, 0)

# Ring, tel, call+number 
df['feature18'] = np.where(df[column_message].str.contains(r'(?i)ring[\s]?\d+|call[\s]?\d+|cal[\s]?\d+|tel[\s]?\d+', regex=True), 1, 0)

# Time, date
df['feature19'] = np.where(df[column_message].str.contains(r'(?i)Jan[\s]?\d+|January[\s]?\d+|Feb[\s]?\d+|February[\s]?\d+|Mar[\s]?\d+|March[\s]?\d+|Apr[\s]?\d+|April[\s]?\d+|May[\s]?\d+|Jun[\s]?\d+|June[\s]?\d+|Jul[\s]?\d+|July[\s]?\d+|August[\s]?\d+|Sep[\s]?\d+|September[\s]?\d+|Oct[\s]?\d+|October[\s]?\d+|Nov[\s]?\d+|November[\s]?\d+|Dec[\s]?\d+|December[\s]?\d+', regex=True), 1, 0)

# Long string number
df['feature20'] = np.where(df[column_message].str.contains(r'\d{13,35}', regex=True), 1, 0)
	
# String+@+string (email)
df['feature21'] = np.where(df[column_message].str.contains(r'[a-zA-Z0-9.!#$%&\'*+=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*', regex=True), 1, 0)

# Currency (£, $, €, ¥)(binary)
df['feature22'] = np.where(df[column_message].str.contains(r'£|\$|\€|\¥', regex=True), 1, 0)

# service numbers (short string numbers)
df['feature23'] = np.where(df[column_message].str.contains(r'\b\d{5}\b|\b\d{4}\b|\b\d{6}\b', regex=True), 1, 0)

# currency in word (symbol in word)
df['feature24'] = np.where(df[column_message].str.contains(r'(?i)\d+[\s]?pound|\d+[\s]?p\b|\d+[\s]?pence\b|gbp|\d+[\s]?USD\b|\d+[\s]?dollar\b', regex=True), 1, 0)


# spam keywords
Search_for_spam_words = ['free', 'ringtone', 'claim', 'txt ', 'text', 'reply', 'nokia',
                         'win ', 'video', 'mobile', 'award','dating','won ','lottery','entitled'] #creating list

pattern = '|'.join(Search_for_spam_words)

df[column_message] = df[column_message].str.lower()
# count of spam words
df['feature25']= df[column_message].str.findall(pattern).str.len()
# spam words exsistence
df['feature26'] = np.where(df[column_message].str.contains(pattern, regex=True), 1, 0)

#---------------------------------------------------------------------------
#---------------------------------------------------------------------------

allfeatureNamse = selectedFeatNames.split(",")

if showGbmEvaluation == '1':

	X_train = df[allfeatureNamse][df[column_purpose].str.contains('for_train')]
	X_test = df[allfeatureNamse][df[column_purpose].str.contains('for_test')]
	y_train = df[column_class][df[column_purpose].str.contains('for_train')]
	y_test = df[column_class][df[column_purpose].str.contains('for_test')]
	
	# classification
	from sklearn.ensemble import GradientBoostingClassifier
	gbm_model= GradientBoostingClassifier()

	# Fit the model with data (aka "model training")
	gbm_model.fit(X_train, y_train)

	# Predict the response for a new observation
	y_pred = gbm_model.predict(X_test)

	from sklearn.metrics import confusion_matrix
	confusion_matrix(y_test, y_pred)
	
	from sklearn import metrics

	# save confusion matrix and slice into four pieces
	confusion = metrics.confusion_matrix(y_test, y_pred)
	TP = confusion[1, 1]
	TN = confusion[0, 0]
	FP = confusion[0, 1]
	FN = confusion[1, 0]
	
	# accuracy
	accuracy = metrics.accuracy_score(y_test, y_pred)
	
	# recall (Sensitivity)
	sensitivity = TP / float(TP + FN)
	
	# Specificity
	specificity = TN / float(TN + FP)
	
	# Precision:
	precision = TP / float(TP + FP)
	
	# f1 score
	models_f1score = 2 * (precision * sensitivity) / (precision + sensitivity)
	
	print("-----------------------------")
	print("GBM Evaluation (on new dataset)")
	print("Accuracy: ",accuracy)
	print(confusion)
	print("Recall: ",sensitivity)
	print("Specificity: ",specificity)	
	print("Precision: ",precision)
	print("F1 score: ",models_f1score)
	print("-----------------------------")
	
if showXgbEvaluation == '1':

	X_train = df[allfeatureNamse][df[column_purpose].str.contains('for_train')]
	X_test = df[allfeatureNamse][df[column_purpose].str.contains('for_test')]
	y_train = df[column_class][df[column_purpose].str.contains('for_train')]
	y_test = df[column_class][df[column_purpose].str.contains('for_test')]
	
	# classification
	from xgboost import XGBClassifier
	xgb_model = XGBClassifier()

	# Fit the model with data (aka "model training")
	xgb_model.fit(X_train, y_train)

	# Predict the response for a new observation
	y_pred = xgb_model.predict(X_test)

	from sklearn.metrics import confusion_matrix
	confusion_matrix(y_test, y_pred)
	
	from sklearn import metrics

	# save confusion matrix and slice into four pieces
	confusion = metrics.confusion_matrix(y_test, y_pred)
	TP = confusion[1, 1]
	TN = confusion[0, 0]
	FP = confusion[0, 1]
	FN = confusion[1, 0]
	
	# accuracy
	accuracy = metrics.accuracy_score(y_test, y_pred)
	
	# recall (Sensitivity)
	sensitivity = TP / float(TP + FN)
	
	# Specificity
	specificity = TN / float(TN + FP)
	
	# Precision:
	precision = TP / float(TP + FP)
	
	# f1 score
	models_f1score = 2 * (precision * sensitivity) / (precision + sensitivity)
	
	print("-----------------------------")
	print("XGBoost Evaluation (on new dataset)")
	print("Accuracy: ",accuracy)
	print(confusion)
	print("Recall: ",sensitivity)
	print("Specificity: ",specificity)	
	print("Precision: ",precision)
	print("F1 score: ",models_f1score)
	print("-----------------------------")
	
if showLgbmEvaluation == '1':

	X_train = df[allfeatureNamse][df[column_purpose].str.contains('for_train')]
	X_test = df[allfeatureNamse][df[column_purpose].str.contains('for_test')]
	y_train = df[column_class][df[column_purpose].str.contains('for_train')]
	y_test = df[column_class][df[column_purpose].str.contains('for_test')]
	
	# classification
	from lightgbm import LGBMClassifier
	lgb_model = LGBMClassifier()

	# Fit the model with data (aka "model training")
	lgb_model.fit(X_train, y_train)

	# Predict the response for a new observation
	y_pred = lgb_model.predict(X_test)

	from sklearn.metrics import confusion_matrix
	confusion_matrix(y_test, y_pred)
	
	from sklearn import metrics

	# save confusion matrix and slice into four pieces
	confusion = metrics.confusion_matrix(y_test, y_pred)
	TP = confusion[1, 1]
	TN = confusion[0, 0]
	FP = confusion[0, 1]
	FN = confusion[1, 0]
	
	# accuracy
	accuracy = metrics.accuracy_score(y_test, y_pred)
	
	# recall (Sensitivity)
	sensitivity = TP / float(TP + FN)
	
	# Specificity
	specificity = TN / float(TN + FP)
	
	# Precision:
	precision = TP / float(TP + FP)
	
	# f1 score
	models_f1score = 2 * (precision * sensitivity) / (precision + sensitivity)
	
	print("-----------------------------")
	print("LightGBM Evaluation (on new dataset)")
	print("Accuracy: ",accuracy)
	print(confusion)
	print("Recall: ",sensitivity)
	print("Specificity: ",specificity)	
	print("Precision: ",precision)
	print("F1 score: ",models_f1score)
	print("-----------------------------")
	
	