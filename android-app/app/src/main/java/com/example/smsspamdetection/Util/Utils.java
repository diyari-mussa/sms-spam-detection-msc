package com.example.smsspamdetection.Util;

public class Utils {

    public static final int DB_VERSION = 1;
    public static final String DB_NAME = "smsSpamDetectionDB";
    public static final String TABLE_NAME = "smsSpamDetectionTable";

    // Table column
    public static final String COL_ID = "id";
    public static final String COL_SMS_SENDER = "sms_sender";
    public static final String COL_SMS_CONTENT = "sms_content";
    public static final String COL_SMS_LABEL = "sms_label";
    public static final String COL_DATE_NAME = "date_received";
}
