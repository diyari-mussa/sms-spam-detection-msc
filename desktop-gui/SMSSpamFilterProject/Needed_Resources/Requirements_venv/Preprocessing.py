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
classDistribution = sys.argv[7]
calssEncoding = sys.argv[8]
showUsefulInfo = sys.argv[9]


# variables initialization
dashLine = "---------------"

# 1. data preparation and analysis

# reading sms messages dataset 
df = pd.read_csv(r"" + datasetPath, encoding='utf8', delimiter='\t')

if datasetContent == '1':
	print(df.head())
	print(dashLine)

# chekcing for missing value
if missingValue == '1':
	print(df.isnull().sum())
	print(dashLine)
	
# rename columns
df = df.rename(columns = {'v1':column_class,'v2':column_message})
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



# 2. feature Extraction

# initializing arguments
datasetToList = sys.argv[10] # show list of the collumn message of data 
messageRowState = sys.argv[11]
messageRowID = sys.argv[12]

# arguments of feature extraction types
allFeatureExtr = sys.argv[13] 
allFeatureExtrShow = sys.argv[14] # showing extracted features
binaryFeatureExtr = sys.argv[15]
binaryFeatureExtrShow = sys.argv[16]
numericFeatureExtr = sys.argv[17]
numericFeatureExtrShow = sys.argv[18]
# export features
exportFeaturesCheck = sys.argv[19]
expTabularFilePath = sys.argv[20]

# model evaluation
gbmModelChecked = sys.argv[21]
gbmBinEvaluationShow = sys.argv[22]
gbmNumEvaluationShow = sys.argv[23]
gbmAllEvaluationShow = sys.argv[24]
xgbModelChecked = sys.argv[25]
xgbBinEvaluationShow = sys.argv[26]
xgbNumEvaluationShow = sys.argv[27]
xgbAllEvaluationShow = sys.argv[28]
lgbModelChecked = sys.argv[29]
lgbBinEvaluationShow = sys.argv[30]
lgbNumEvaluationShow = sys.argv[31]
lgbAllEvaluationShow = sys.argv[32]


if datasetToList == '1':
	print(df)
	

def func_all_features():
	# extraction of all features
	
	# determining number of the message length (numeric)
	df['feature1'] = df[column_message].str.len()

	# Count of “/” slash (numeric)
	df['feature2'] = df[column_message].str.findall(r'/').str.len()

	# non-alphanumeric characters (numeric)
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
	df['feature22'] = np.where(df[column_message].str.contains(r'£|\$|\€|\¥|\₣|\₹|\₩|\₦|\₽|\₺|\₴|\₿|\ɱ|\Ł|\Ξ', regex=True), 1, 0)

	# service numbers (short string numbers)
	df['feature23'] = np.where(df[column_message].str.contains(r'\b\d{5}\b|\b\d{4}\b|\b\d{6}\b', regex=True), 1, 0)

	# currency as word (symbol in word)
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
	
	df['message'] = pd.read_csv(r"" + datasetPath, encoding='utf8', delimiter='\t', skipinitialspace=True, usecols=["v2"])

def func_binary_features():
	# collumn includes mathmatical symbols (binary)
	df['feature1'] = np.where(df['message'].str.contains(r'\+|\-|<|>|/|\^', regex=True), 1, 0)

	# collumn corrisponds to having URL (www, http, https) in the message (binary)
	df['feature2'] = np.where(df['message'].str.contains(r'(?i)\bhttp[s]?[:]?[//]?[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|www\.[s]?(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+|http[\s]|.co.uk', regex=True), 1, 0)

	# collumn dots (binary)
	df['feature3'] = np.where(df['message'].str.contains(r'\.', regex=True), 1, 0)

	# collumn corrisponds to having special symbol in the message (binary)
	df['feature4'] = np.where(df['message'].str.contains(r'£|\$|!|\*|&|#|~', regex=True), 1, 0)

	# collumn corrisponds of having emotionss in the message (binary)
	df['feature5'] = np.where(df['message'].str.contains(r':\)|:-\)|:\(|:-\(|;\);-\)|:-O|:P|:D|:\||:\$|:@|8o\||\+o\(|\(H\)|\(C\)|\(\?\)|;\)|-_-|:\*|:o|:\'\(|:V|:3|\*\^\*|xD|<3|-\.-|,-\)|\(:-\(|\(:-\)|\'-\)|:-#|:-\/|:->|:-@|:-d|:-V|:-X|:-]|;-\(|;\^\)|8:-\)|8:-\)', regex=True), 1, 0)

	# collumn Lowercase words (binary)
	df['feature6'] = np.where(df['message'].str.contains(r'\b[a-z]+\b', regex=True), 1, 0)

	# collumn Uppercase words (binary)
	df['feature7'] = np.where(df['message'].str.contains(r'\b[A-Z]{2,20}\b', regex=True), 1, 0)

	# collumn corrisponds to having phone number in the message (binary)
	df['feature8'] = np.where(df['message'].str.contains(r'[+]?\(?[\d]{3,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{4,7}|[+]?\(?[\d]{1,4}\)?[\s-]?[\d]{3,4}[\s-]?[\d]{3,4}[\s-][\d]{3,4}\b', regex=True), 1, 0)

	# Currency (£, $, €, ¥) + number
	df['feature9'] = np.where(df['message'].str.contains(r'[£|\$|\€|\¥][\s]?\d+[\.]?\d+', regex=True), 1, 0)

	# Number+% or number + percent
	df['feature10'] = np.where(df['message'].str.contains(r'(?i)\d+[\.]?\d+[\s]?%|\d+[\.]?\d+[\s]?percent|%[\s]?\d+[\.]?\d+', regex=True), 1, 0)

	# Ring, tel, call+number 
	df['feature11'] = np.where(df['message'].str.contains(r'(?i)ring[\s]?\d+|call[\s]?\d+|cal[\s]?\d+|tel[\s]?\d+', regex=True), 1, 0)

	# Time, date
	df['feature12'] = np.where(df['message'].str.contains(r'(?i)Jan[\s]?\d+|January[\s]?\d+|Feb[\s]?\d+|February[\s]?\d+|Mar[\s]?\d+|March[\s]?\d+|Apr[\s]?\d+|April[\s]?\d+|May[\s]?\d+|Jun[\s]?\d+|June[\s]?\d+|Jul[\s]?\d+|July[\s]?\d+|August[\s]?\d+|Sep[\s]?\d+|September[\s]?\d+|Oct[\s]?\d+|October[\s]?\d+|Nov[\s]?\d+|November[\s]?\d+|Dec[\s]?\d+|December[\s]?\d+', regex=True), 1, 0)

	# Long string number
	df['feature13'] = np.where(df['message'].str.contains(r'\d{13,35}', regex=True), 1, 0)

	# String+@+string (email)
	df['feature14'] = np.where(df['message'].str.contains(r'[a-zA-Z0-9.!#$%&\'*+=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*', regex=True), 1, 0)

	# Currency (£, $, €, ¥)(binary)
	df['feature15'] = np.where(df['message'].str.contains(r'£|\$|\€|\¥|\₣|\₹|\₩|\₦|\₽|\₺|\₴|\₿|\ɱ|\Ł|\Ξ', regex=True), 1, 0)

	# service numbers (short string numbers)
	df['feature16'] = np.where(df['message'].str.contains(r'\b\d{5}\b|\b\d{4}\b|\b\d{6}\b', regex=True), 1, 0)

	# currency as word (symbol in word)
	df['feature17'] = np.where(df['message'].str.contains(r'(?i)\d+[\s]?pound|\d+[\s]?p\b|\d+[\s]?pence\b|gbp|\d+[\s]?USD\b|\d+[\s]?dollar\b', regex=True), 1, 0)


	# spam keywords
	Search_for_spam_words = ['free', 'ringtone', 'claim', 'txt ', 'text', 'reply', 'nokia',
							'win ', 'video', 'mobile', 'award','dating','won ','lottery','entitled'] #creating list

	pattern = '|'.join(Search_for_spam_words)

	df['message'] = df['message'].str.lower()
	# spam words exsistence
	df['feature18'] = np.where(df['message'].str.contains(pattern, regex=True), 1, 0)
	
	df['message'] = pd.read_csv(r"" + datasetPath, encoding='utf8', delimiter='\t', skipinitialspace=True, usecols=["v2"])

def func_numeric_features():
	# determining number of the message length (numeric)
	df['feature1'] = df['message'].str.len()

	# Count of “/” slash (numeric)
	df['feature2'] = df['message'].str.findall(r'/').str.len()

	# non-alphanumeric characters (numeric)
	df['feature3'] = df['message'].str.findall(r'[^a-zA-Z0-9 ]').str.len()

	# alphanumeric words (numeric)
	df['feature4'] = df['message'].str.findall(r'(?:[0-9][^ ]*[A-Za-z][^ ]*)|(?:[A-Za-z][^ ]*[0-9][^ ]*)').str.len()

	# Count of numeric words (numeric)
	df['feature5'] = df['message'].str.findall(r'\d+(\.\d+)?').str.len()

	# upper case letter length (numeric)
	df['feature6'] = [sum([c.isupper() for c in a]) for a in df['message']]

	# Number of words (numeric)
	df['feature7'] = df['message'].str.findall(r'([^\s][a-zA-Z]+)').str.len()


	# spam keyword (numeric)
	Search_for_spam_words_num = ['free', 'ringtone', 'claim', 'txt ', 'text', 'reply', 'nokia',
								'win ', 'video', 'mobile', 'award','dating','won ','lottery','entitled'] #creating list

	pattern = '|'.join(Search_for_spam_words_num)
	
	df['message'] = df['message'].str.lower()
	df['feature8']= df['message'].str.findall(pattern).str.len()
	
	df['message'] = pd.read_csv(r"" + datasetPath, encoding='utf8', delimiter='\t', skipinitialspace=True, usecols=["v2"])


if messageRowState == '1':
	
	if allFeatureExtr == '1':
		
		func_all_features()
		
		if allFeatureExtrShow == '1':
			int_msgRowID = int(messageRowID)
			print(df.iloc[int_msgRowID][column_message])
			print(df.iloc[int_msgRowID]['feature1'])
			print(df.iloc[int_msgRowID]['feature2'])
			print(df.iloc[int_msgRowID]['feature3'])
			print(df.iloc[int_msgRowID]['feature4'])
			print(df.iloc[int_msgRowID]['feature5'])
			print(df.iloc[int_msgRowID]['feature6'])
			print(df.iloc[int_msgRowID]['feature7'])
			print(df.iloc[int_msgRowID]['feature8'])
			print(df.iloc[int_msgRowID]['feature9'])
			print(df.iloc[int_msgRowID]['feature10'])
			print(df.iloc[int_msgRowID]['feature11'])
			print(df.iloc[int_msgRowID]['feature12'])
			print(df.iloc[int_msgRowID]['feature13'])
			print(df.iloc[int_msgRowID]['feature14'])
			print(df.iloc[int_msgRowID]['feature15'])
			print(df.iloc[int_msgRowID]['feature16'])
			print(df.iloc[int_msgRowID]['feature17'])
			print(df.iloc[int_msgRowID]['feature18'])
			print(df.iloc[int_msgRowID]['feature19'])
			print(df.iloc[int_msgRowID]['feature20'])
			print(df.iloc[int_msgRowID]['feature21'])
			print(df.iloc[int_msgRowID]['feature22'])
			print(df.iloc[int_msgRowID]['feature23'])
			print(df.iloc[int_msgRowID]['feature24'])
			print(df.iloc[int_msgRowID]['feature25'])
			print(df.iloc[int_msgRowID]['feature26'])
		
		
		if gbmModelChecked == '1':
		
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8','feature9','feature10','feature11','feature12','feature13','feature14','feature15','feature16','feature17','feature18','feature19','feature20','feature21','feature22','feature23','feature24','feature25','feature26']]

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
			
			if gbmAllEvaluationShow =='1':
				print("GBM Evaluation using All features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)
				print("-----------------------------")	
		
		if xgbModelChecked =='1':
			
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8','feature9','feature10','feature11','feature12','feature13','feature14','feature15','feature16','feature17','feature18','feature19','feature20','feature21','feature22','feature23','feature24','feature25','feature26']]

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
			
			if xgbAllEvaluationShow =='1':
				print("XGB Evaluation using All features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)	
				print("-----------------------------")
		
		if lgbModelChecked =='1':
		
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8','feature9','feature10','feature11','feature12','feature13','feature14','feature15','feature16','feature17','feature18','feature19','feature20','feature21','feature22','feature23','feature24','feature25','feature26']]

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
			
			if lgbAllEvaluationShow =='1':
				print("lgb Evaluation using All features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)
				print("-----------------------------")
				
	
	if binaryFeatureExtr == '1':
		
		func_binary_features()

		if binaryFeatureExtrShow == '1':
			int_msgRowID = int(messageRowID)
			print(df.iloc[int_msgRowID][column_message])
			print(df.iloc[int_msgRowID]['feature1'])
			print(df.iloc[int_msgRowID]['feature2'])
			print(df.iloc[int_msgRowID]['feature3'])
			print(df.iloc[int_msgRowID]['feature4'])
			print(df.iloc[int_msgRowID]['feature5'])
			print(df.iloc[int_msgRowID]['feature6'])
			print(df.iloc[int_msgRowID]['feature7'])
			print(df.iloc[int_msgRowID]['feature8'])
			print(df.iloc[int_msgRowID]['feature9'])
			print(df.iloc[int_msgRowID]['feature10'])
			print(df.iloc[int_msgRowID]['feature11'])
			print(df.iloc[int_msgRowID]['feature12'])
			print(df.iloc[int_msgRowID]['feature13'])
			print(df.iloc[int_msgRowID]['feature14'])
			print(df.iloc[int_msgRowID]['feature15'])
			print(df.iloc[int_msgRowID]['feature16'])
			print(df.iloc[int_msgRowID]['feature17'])
			print(df.iloc[int_msgRowID]['feature18'])
			
		if gbmModelChecked == '1':
		
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8','feature9','feature10','feature11','feature12','feature13','feature14','feature15','feature16','feature17','feature18']]

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
			
			if gbmBinEvaluationShow == '1':
				print("GBM Evaluation using Binary features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)
				print("-----------------------------")
			
		if xgbModelChecked == '1':
		
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8','feature9','feature10','feature11','feature12','feature13','feature14','feature15','feature16','feature17','feature18']]

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
			
			if xgbBinEvaluationShow =='1':
				print("XGB Evaluation using Binary features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)
				print("-----------------------------")
	
		if lgbModelChecked =='1':
		
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8','feature9','feature10','feature11','feature12','feature13','feature14','feature15','feature16','feature17','feature18']]

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
			
			if lgbBinEvaluationShow =='1':
				print("lgb Evaluation using Binary features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)	
				print("-----------------------------")
	
	if numericFeatureExtr == '1':
		
		func_numeric_features()
		
		if numericFeatureExtrShow == '1':
			int_msgRowID = int(messageRowID)
			print(df.iloc[int_msgRowID][column_message])
			print(df.iloc[int_msgRowID]['feature1'])
			print(df.iloc[int_msgRowID]['feature2'])
			print(df.iloc[int_msgRowID]['feature3'])
			print(df.iloc[int_msgRowID]['feature4'])
			print(df.iloc[int_msgRowID]['feature5'])
			print(df.iloc[int_msgRowID]['feature6'])
			print(df.iloc[int_msgRowID]['feature7'])
			print(df.iloc[int_msgRowID]['feature8'])
			
		if gbmModelChecked == '1':
		
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8']]

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
			
			if gbmNumEvaluationShow =='1':
				print("GBM Evaluation using Numeric features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)	
				print("-----------------------------")
			
		if xgbModelChecked == '1':
		
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8']]

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
			
			if xgbNumEvaluationShow =='1':
				print("XGB Evaluation using Numeric features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)	
				print("-----------------------------")

		if lgbModelChecked =='1':
			
			# X is our feature data
			X = df[['feature1','feature2','feature3','feature4','feature5','feature6','feature7','feature8']]

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
			
			if lgbNumEvaluationShow =='1':
				print("lgb Evaluation using Numeric features ")
				print("Accuracy: ",scoreof_crossval)
				print(conf_mat)
				print("Classification Accuracy: ",classifi_acc)
				print("Classification Error: ",classifi_err)
				print("Recall: ",sensitivity)
				print("Specificity: ",specificity)	
				print("Precision: ",models_precision)	
				print("-----------------------------")


# Export Features Results
if exportFeaturesCheck == '1':

	if allFeatureExtr == '1':
		func_all_features()
		df.to_csv(expTabularFilePath)
		
if exportFeaturesCheck == '2':		
	if binaryFeatureExtr  == '1':
		func_binary_features()
		df.to_csv(expTabularFilePath)

if exportFeaturesCheck == '3':	
	if numericFeatureExtr  == '1':
		func_numeric_features()
		df.to_csv(expTabularFilePath)
# 
if featureExtractTimeShow =='1':
	# identify time
	start_time = time.time()
	
	if allFeatureExtr == '1':
		func_all_features()
		
		# evaluating time for preprocessing
		print(round(time.time()-start_time, 3))
	
	if binaryFeatureExtr == '1':
		func_binary_features()
		
		# evaluating time for preprocessing
		print(round(time.time()-start_time, 3))
		
	if numericFeatureExtr == '1':
		func_numeric_features()
		
		# evaluating time for preprocessing
		print(round(time.time()-start_time, 3))
	

#df.iloc[3]
