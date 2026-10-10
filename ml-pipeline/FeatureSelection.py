import numpy as np
import pandas as pd
import string
import time 

import sys

from sklearn.preprocessing import LabelEncoder


# initializing arguments
datasetPath = sys.argv[1]
column_class = sys.argv[2]
column_message = sys.argv[3]



# 1. data preparation

# reading sms messages dataset 
df = pd.read_csv(r"" + datasetPath, encoding='utf8', delimiter='\t')

# rename columns
df = df.rename(columns = {'v1':column_class,'v2':column_message})

# encoding class 
encoder = LabelEncoder()
df[column_class] = encoder.fit_transform(df[column_class])

# 2. features preparation for slection

# features variables
fchecked_MessageLength = sys.argv[4]
fname_messageLength = sys.argv[5]
fchecked_CountSlashes = sys.argv[6]
fname_CountSlashes = sys.argv[7]
fchecked_CountPunct = sys.argv[8]
fname_CountPunct = sys.argv[9]
fchecked_CountAlphaNum = sys.argv[10]
fname_CountAlphaNum = sys.argv[11]
fchecked_CountNumTerms = sys.argv[12]
fname_CountNumTerms = sys.argv[13]
fchecked_CountUpperCaseLetter = sys.argv[14]
fname_CountUpperCaseLetter = sys.argv[15]
fchecked_CountWordsNum = sys.argv[16]
fname_CountWordsNum = sys.argv[17]
fchecked_MathSymbol = sys.argv[18]
fname_MathSymbol = sys.argv[19]
fchecked_URL = sys.argv[20]
fname_URL = sys.argv[21]
fchecked_Dots = sys.argv[22]
fname_Dots = sys.argv[23]
fchecked_SpecialSymbol = sys.argv[24]
fname_SpecialSymbol = sys.argv[25]
fchecked_Emotions = sys.argv[26]
fname_Emotions = sys.argv[27]
fchecked_Lowercase = sys.argv[28]
fname_Lowercase = sys.argv[29]
fchecked_Uppercase = sys.argv[30]
fname_Uppercase = sys.argv[31]
fchecked_PhoneNumber = sys.argv[32]
fname_PhoneNumber = sys.argv[33]
fchecked_CurrencyPNum = sys.argv[34]
fname_CurrencyPNum = sys.argv[35]
fchecked_NumPpercent = sys.argv[36]
fname_NumPpercent = sys.argv[37]
fchecked_RingtelPNum = sys.argv[38]
fname_RingtelPNum = sys.argv[39]
fchecked_DateTime = sys.argv[40]
fname_DateTime = sys.argv[41]
fchecked_LongStrNum = sys.argv[42]
fname_LongStrNum = sys.argv[43]
fchecked_Email = sys.argv[44]
fname_Email = sys.argv[45]
fchecked_CurrencySymb = sys.argv[46]
fname_CurrencySymb = sys.argv[47]
fchecked_ServiceNum = sys.argv[48]
fname_ServiceNum = sys.argv[49]
fchecked_CurrencyWord = sys.argv[50]
fname_CurrencyWord = sys.argv[51]
fchecked_CountSpamKeywords = sys.argv[52]
fname_CountSpamKeywords = sys.argv[53]
fchecked_PreSpamKeywords = sys.argv[54]
fname_PreSpamKeywords = sys.argv[55]


# array to hold all feature names that will be extracted
featureNames_arr = []

#### extraction of features ####

## numeric features ##

if fchecked_MessageLength == '1':
	# determining number of the message length (numeric)
	df[fname_messageLength] = df[column_message].str.len()
	
	featureNames_arr.append(fname_messageLength)
	
if fchecked_CountSlashes == '1':
	# count the number of slashes in the message (numeric)
	df[fname_CountSlashes] = df[column_message].str.findall(r'/').str.len()
	
	featureNames_arr.append(fname_CountSlashes)
	
	
if fchecked_CountPunct == '1':
	# non-alphanumeric characters (numeric)
	df[fname_CountPunct] = df[column_message].str.findall(r'[^a-zA-Z0-9 ]').str.len()
	
	featureNames_arr.append(fname_CountPunct)
	
	
if fchecked_CountAlphaNum == '1':
	# alphanumeric words (numeric)
	df[fname_CountAlphaNum] = df[column_message].str.findall(r'(?:[0-9][^ ]*[A-Za-z][^ ]*)|(?:[A-Za-z][^ ]*[0-9][^ ]*)').str.len()
	
	featureNames_arr.append(fname_CountAlphaNum)
	
	
if fchecked_CountNumTerms == '1':
	# Count of numeric words (numeric)
	df[fname_CountNumTerms] = df[column_message].str.findall(r'\d+(\.\d+)?').str.len()
	
	featureNames_arr.append(fname_CountNumTerms)
	
	
if fchecked_CountUpperCaseLetter == '1':
	# upper case letter length (numeric)
	df[fname_CountUpperCaseLetter] = [sum([c.isupper() for c in a]) for a in df[column_message]]
	
	featureNames_arr.append(fname_CountUpperCaseLetter)
	
	
if fchecked_CountWordsNum == '1':
	# Number of words (numeric)
	df[fname_CountWordsNum] = df[column_message].str.findall(r'([^\s][a-zA-Z]+)').str.len()	
	
	featureNames_arr.append(fname_CountWordsNum)


## binary features ##

if fchecked_MathSymbol == '1':
	# collumn includes mathmatical symbols (binary)
	df[fname_MathSymbol] = np.where(df[column_message].str.contains(r'\+|\-|<|>|/|\^', regex=True), 1, 0)
	
	featureNames_arr.append(fname_MathSymbol)

if fchecked_URL == '1':
	# collumn corrisponds to having URL (www, http, https) in the message (binary)
	df[fname_URL] = np.where(df[column_message].str.contains(r'(?i)\bhttp[s]?[:]?[//]?[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|www\.[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|http[\s]|.co.uk', regex=True), 1, 0)
	
	featureNames_arr.append(fname_URL)
	
if fchecked_Dots == '1':
	# collumn dots (binary)
	df[fname_Dots] = np.where(df[column_message].str.contains(r'\.', regex=True), 1, 0)
	
	featureNames_arr.append(fname_Dots)

if fchecked_SpecialSymbol == '1':
	# collumn corrisponds to having special symbol in the message (binary)
	df[fname_SpecialSymbol] = np.where(df[column_message].str.contains(r'£|\$|!|\*|&|#|~', regex=True), 1, 0)
	
	featureNames_arr.append(fname_SpecialSymbol)

if fchecked_Emotions == '1':
	# collumn corrisponds of having emotionss in the message (binary)
	df[fname_Emotions] = np.where(df[column_message].str.contains(r':\)|:-\)|:\(|:-\(|;\);-\)|:-O|:P|:D|:\||:\$|:@|8o\||\+o\(|\(H\)|\(C\)|\(\?\)|;\)|-_-|:\*|:o|:\'\(|:V|:3|\*\^\*|xD|<3|-\.-|,-\)|\(:-\(|\(:-\)|\'-\)|:-#|:-\/|:->|:-@|:-d|:-V|:-X|:-]|;-\(|;\^\)|8:-\)|8:-\)', regex=True), 1, 0)
	
	featureNames_arr.append(fname_Emotions)

if fchecked_Lowercase == '1':
	# collumn Lowercase words (binary)
	df[fname_Lowercase] = np.where(df[column_message].str.contains(r'\b[a-z]+\b', regex=True), 1, 0)
	
	featureNames_arr.append(fname_Lowercase)
	
if fchecked_Uppercase == '1':
	# collumn Uppercase words (binary)
	df[fname_Uppercase] = np.where(df[column_message].str.contains(r'\b[A-Z]{2,20}\b', regex=True), 1, 0)
	
	featureNames_arr.append(fname_Uppercase)
	
if fchecked_PhoneNumber == '1':
	# collumn corrisponds to having phone number in the message (binary)
	df[fname_PhoneNumber] = np.where(df[column_message].str.contains(r'[+]?\(?[\d]{3,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{4,7}|[+]?\(?[\d]{1,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{3,4}[\s-][\d]{3,4}\b', regex=True), 1, 0)
	
	featureNames_arr.append(fname_PhoneNumber)
	
if fchecked_CurrencyPNum == '1':
	# Currency (£, $, €, ¥) + number
	df[fname_CurrencyPNum] = np.where(df[column_message].str.contains(r'[£|\$|\€|\¥][\s]?\d+[\.]?\d+', regex=True), 1, 0)
	
	featureNames_arr.append(fname_CurrencyPNum)
	
if fchecked_NumPpercent == '1':
	# Number+% or number + percent
	df[fname_NumPpercent] = np.where(df[column_message].str.contains(r'(?i)\d+[\.]?\d+[\s]?%|\d+[\.]?\d+[\s]?percent|%[\s]?\d+[\.]?\d+', regex=True), 1, 0)
	
	featureNames_arr.append(fname_NumPpercent)
	
if fchecked_RingtelPNum == '1':
	# Ring, tel, call+number 
	df[fname_RingtelPNum] = np.where(df[column_message].str.contains(r'(?i)ring[\s]?\d+|call[\s]?\d+|cal[\s]?\d+|tel[\s]?\d+', regex=True), 1, 0)
	
	featureNames_arr.append(fname_RingtelPNum)
	
if fchecked_DateTime == '1':
	# Time, date
	df[fname_DateTime] = np.where(df[column_message].str.contains(r'(?i)Jan[\s]?\d+|January[\s]?\d+|Feb[\s]?\d+|February[\s]?\d+|Mar[\s]?\d+|March[\s]?\d+|Apr[\s]?\d+|April[\s]?\d+|May[\s]?\d+|Jun[\s]?\d+|June[\s]?\d+|Jul[\s]?\d+|July[\s]?\d+|August[\s]?\d+|Sep[\s]?\d+|September[\s]?\d+|Oct[\s]?\d+|October[\s]?\d+|Nov[\s]?\d+|November[\s]?\d+|Dec[\s]?\d+|December[\s]?\d+', regex=True), 1, 0)
	
	featureNames_arr.append(fname_DateTime)
	
if fchecked_LongStrNum == '1':
	# Long string number
	df[fname_LongStrNum] = np.where(df[column_message].str.contains(r'\d{13,35}', regex=True), 1, 0)
	
	featureNames_arr.append(fname_LongStrNum)
	
if fchecked_Email == '1':
	# String+@+string (email)
	df[fname_Email] = np.where(df[column_message].str.contains(r'[a-zA-Z0-9.!#$%&\'*+=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*', regex=True), 1, 0)
	
	featureNames_arr.append(fname_Email)
	
if fchecked_CurrencySymb == '1':
	# Currency (£, $, €, ¥)(binary)
	df[fname_CurrencySymb] = np.where(df[column_message].str.contains(r'£|\$|\€|\¥|\₣|\₹|\₩|\₦|\₽|\₺|\₴|\₿|\ɱ|\Ł|\Ξ', regex=True), 1, 0)
	
	featureNames_arr.append(fname_CurrencySymb)
	
if fchecked_ServiceNum == '1':
	# service numbers (short string numbers)
	df[fname_ServiceNum] = np.where(df[column_message].str.contains(r'\b\d{5}\b|\b\d{4}\b|\b\d{6}\b', regex=True), 1, 0)
	
	featureNames_arr.append(fname_ServiceNum)
	
if fchecked_CurrencyWord == '1':
	# currency as word (symbol in word)
	df[fname_CurrencyWord] = np.where(df[column_message].str.contains(r'(?i)\d+[\s]?pound|\d+[\s]?p\b|\d+[\s]?pence\b|gbp|\d+[\s]?USD\b|\d+[\s]?dollar\b', regex=True), 1, 0)
	
	featureNames_arr.append(fname_CurrencyWord)
	
	
if fchecked_CountSpamKeywords == '1':
	# spam keywords
	Search_for_spam_words = ['free', 'ringtone', 'claim', 'txt ', 'text', 'reply', 'nokia',
                          'win ', 'video', 'mobile', 'award','dating','won ','lottery','entitled'] #creating list

	pattern = '|'.join(Search_for_spam_words)

	df[column_message] = df[column_message].str.lower()
	# count of spam words
	df[fname_CountSpamKeywords] = df[column_message].str.findall(pattern).str.len()
	
	featureNames_arr.append(fname_CountSpamKeywords)
	

if fchecked_PreSpamKeywords == '1':
	# spam keywords
	Search_for_spam_words = ['free', 'ringtone', 'claim', 'txt ', 'text', 'reply', 'nokia',
                          'win ', 'video', 'mobile', 'award','dating','won ','lottery','entitled'] #creating list

	pattern = '|'.join(Search_for_spam_words)

	df[column_message] = df[column_message].str.lower()
	# count of spam words
	df[fname_PreSpamKeywords] = np.where(df[column_message].str.contains(pattern, regex=True), 1, 0)
	
	featureNames_arr.append(fname_PreSpamKeywords)


#### feature selection ####


## parmeters of feature selection algorithm
par_algorithm = sys.argv[56]
par_K_features = sys.argv[57]
par_featSelecType = sys.argv[58]
par_Score = sys.argv[59]


## importing libraries and algorithms according to algorithm parameter
##
if par_algorithm =='1':
	from xgboost import XGBClassifier
	xgb_model = XGBClassifier()
	varBoostAlgo = xgb_model
	
if par_algorithm =='2':
	from lightgbm import LGBMClassifier
	lgb_model = LGBMClassifier()
	varBoostAlgo = lgb_model
	
if par_algorithm =='3':
	from sklearn.ensemble import GradientBoostingClassifier
	gbm_model= GradientBoostingClassifier()
	varBoostAlgo = gbm_model
##
if par_featSelecType == 'true':
	sFSelectionType = True
if par_featSelecType == 'false':
	sFSelectionType = False

## 
btnFeatSelecResult = sys.argv[60]
reportFileDir = sys.argv[61]

if btnFeatSelecResult =='1':

	# X is our feature data
	X = df[featureNames_arr]

	# y is our label
	y = df[column_class]
	
	# method for handling feature slection algorithm
	from mlxtend.feature_selection import SequentialFeatureSelector as SFS
	sbs1 = SFS(varBoostAlgo, 
           k_features=int(par_K_features), 
           forward=sFSelectionType, 
           floating=False, 
           verbose=2,
           scoring=par_Score,
           n_jobs=-1,
           cv=10)      

	sbs1 = sbs1.fit(X, y)
	
	print("Scored Accuracy : ",sbs1.k_score_)
	print("Selected Features of Last Iteration : ",sbs1.k_feature_names_)
	print("Full report Generated in : ", reportFileDir)

	reportFile= open(reportFileDir,"w+")
	reportFile.write(str(sbs1.subsets_)) 
	reportFile.close()
	
	#print(sbs1.subsets_)


## Model evaluation and Time 

showGbmAccuracyTime = sys.argv[62]
showGbmEvaluation = sys.argv[63]
showXgbAccuracyTime = sys.argv[64]
showXgbEvaluation = sys.argv[65]
showLgbmAccuracyTime = sys.argv[66]
showLgbmEvaluation = sys.argv[67]


if showGbmAccuracyTime == '1':

	# X is our feature data
	X = df[featureNames_arr]

	# y is our label
	y = df[column_class]
			
	from sklearn.ensemble import GradientBoostingClassifier
	gbm_model= GradientBoostingClassifier()

	from sklearn.model_selection import cross_val_score
	
	# identify time
	start_time = time.time()
	
	scoreof_crossval = cross_val_score(gbm_model,X,y,cv=10,scoring='accuracy').mean()
	# evaluating time for preprocessing
	
	print("-----------------------------")
	print("GBM Classifier time in seconds: ", round(time.time()-start_time, 3), "seconds")
	print("-----------------------------")
	
if showGbmEvaluation == '1':
		
	# X is our feature data
	X = df[featureNames_arr]

	# y is our label
	y = df[column_class]
			
	from sklearn.ensemble import GradientBoostingClassifier
	gbm_model= GradientBoostingClassifier()

	from sklearn.model_selection import cross_val_score
	scoreof_crossval = cross_val_score(gbm_model,X,y,cv=10,scoring='accuracy').mean()
			
	from sklearn.model_selection import cross_val_predict
	from sklearn.metrics import confusion_matrix
	y_pred = cross_val_predict(gbm_model, X, y, cv=10)
	conf_mat = confusion_matrix(y, y_pred)
			
	# Metrics computed from a confusion matrix
	from sklearn import metrics
	# save confusion matrix and slice into four pieces
	confusion = metrics.confusion_matrix(y, y_pred)
	TP = confusion[1, 1]
	TN = confusion[0, 0]
	FP = confusion[0, 1]
	FN = confusion[1, 0]
			
	# Classification Accuracy:
	classifi_acc = metrics.accuracy_score(y, y_pred)
			
	# Classification Error:
	classifi_err = 1 - metrics.accuracy_score(y, y_pred)
			
	# Sensitivity: When the actual value is positive
	sensitivity = metrics.recall_score(y, y_pred)
			
	# Specificity:
	specificity = TN / float(TN + FP)
				
	# Precision:
	models_precision = metrics.precision_score(y, y_pred)
	
	# f1 score
	models_f1score = 2 * (models_precision * sensitivity) / (models_precision + sensitivity)
			
	print("-----------------------------")
	print("GBM Evaluation")
	print("Accuracy: ",scoreof_crossval)
	print(conf_mat)
	print("Classification Accuracy: ",classifi_acc)
	print("Classification Error: ",classifi_err)
	print("Recall: ",sensitivity)
	print("Specificity: ",specificity)	
	print("Precision: ",models_precision)
	print("F1 score: ",models_f1score)
	print("-----------------------------")


if showXgbAccuracyTime == '1':

	# X is our feature data
	X = df[featureNames_arr]

	# y is our label
	y = df[column_class]
			
	from xgboost import XGBClassifier
	xgb_model = XGBClassifier()

	from sklearn.model_selection import cross_val_score
	
	# identify time
	start_time = time.time()
	
	scoreof_crossval = cross_val_score(xgb_model,X,y,cv=10,scoring='accuracy').mean()
	
	# evaluating time for preprocessing	
	print("-----------------------------")
	print("XGBoost Classifier time in seconds: ", round(time.time()-start_time, 3), "seconds")
	print("-----------------------------")
	

if showXgbEvaluation == '1':
		
	# X is our feature data
	X = df[featureNames_arr]

	# y is our label
	y = df[column_class]
			
	from xgboost import XGBClassifier
	xgb_model = XGBClassifier()

	from sklearn.model_selection import cross_val_score
	scoreof_crossval = cross_val_score(xgb_model,X,y,cv=10,scoring='accuracy').mean()
			
	from sklearn.model_selection import cross_val_predict
	from sklearn.metrics import confusion_matrix
	y_pred = cross_val_predict(xgb_model, X, y, cv=10)
	conf_mat = confusion_matrix(y, y_pred)
	
	# Metrics computed from a confusion matrix
	from sklearn import metrics
	# save confusion matrix and slice into four pieces
	confusion = metrics.confusion_matrix(y, y_pred)
	TP = confusion[1, 1]
	TN = confusion[0, 0]
	FP = confusion[0, 1]
	FN = confusion[1, 0]
			
	# Classification Accuracy:
	classifi_acc = metrics.accuracy_score(y, y_pred)
			
	# Classification Error:
	classifi_err = 1 - metrics.accuracy_score(y, y_pred)
			
	# Sensitivity: When the actual value is positive
	sensitivity = metrics.recall_score(y, y_pred)
			
	# Specificity:
	specificity = TN / float(TN + FP)
				
	# Precision:
	models_precision = metrics.precision_score(y, y_pred)
			
	# f1 score
	models_f1score = 2 * (models_precision * sensitivity) / (models_precision + sensitivity)
			
	print("-----------------------------")
	print("XGBoost Evaluation")
	print("Accuracy: ",scoreof_crossval)
	print(conf_mat)
	print("Classification Accuracy: ",classifi_acc)
	print("Classification Error: ",classifi_err)
	print("Recall: ",sensitivity)
	print("Specificity: ",specificity)	
	print("Precision: ",models_precision)
	print("F1 score: ",models_f1score)
	print("-----------------------------")


if showLgbmAccuracyTime == '1':

	# X is our feature data
	X = df[featureNames_arr]

	# y is our label
	y = df[column_class]
			
	from lightgbm import LGBMClassifier
	lgb_model = LGBMClassifier()

	from sklearn.model_selection import cross_val_score
	
	# identify time
	start_time = time.time()
	
	scoreof_crossval = cross_val_score(lgb_model,X,y,cv=10,scoring='accuracy').mean()
	
	# evaluating time for preprocessing	
	print("-----------------------------")
	print("LightGBM Classifier time in seconds: ", round(time.time()-start_time, 3), "seconds")
	print("-----------------------------")
	

if showLgbmEvaluation == '1':
		
	# X is our feature data
	X = df[featureNames_arr]

	# y is our label
	y = df[column_class]
			
	from lightgbm import LGBMClassifier
	lgb_model = LGBMClassifier()

	from sklearn.model_selection import cross_val_score
	scoreof_crossval = cross_val_score(lgb_model,X,y,cv=10,scoring='accuracy').mean()
			
	from sklearn.model_selection import cross_val_predict
	from sklearn.metrics import confusion_matrix
	y_pred = cross_val_predict(lgb_model, X, y, cv=10)
	conf_mat = confusion_matrix(y, y_pred)
	
	# Metrics computed from a confusion matrix
	from sklearn import metrics
	# save confusion matrix and slice into four pieces
	confusion = metrics.confusion_matrix(y, y_pred)
	TP = confusion[1, 1]
	TN = confusion[0, 0]
	FP = confusion[0, 1]
	FN = confusion[1, 0]
			
	# Classification Accuracy:
	classifi_acc = metrics.accuracy_score(y, y_pred)
			
	# Classification Error:
	classifi_err = 1 - metrics.accuracy_score(y, y_pred)
			
	# Sensitivity: When the actual value is positive
	sensitivity = metrics.recall_score(y, y_pred)
			
	# Specificity:
	specificity = TN / float(TN + FP)
				
	# Precision:
	models_precision = metrics.precision_score(y, y_pred)
			
	# f1 score
	models_f1score = 2 * (models_precision * sensitivity) / (models_precision + sensitivity)
			
	print("-----------------------------")
	print("LightGBM Evaluation")
	print("Accuracy: ",scoreof_crossval)
	print(conf_mat)
	print("Classification Accuracy: ",classifi_acc)
	print("Classification Error: ",classifi_err)
	print("Recall: ",sensitivity)
	print("Specificity: ",specificity)	
	print("Precision: ",models_precision)
	print("F1 score: ",models_f1score)
	print("-----------------------------")
