package com.example.smsspamdetection.Data;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import androidx.annotation.Nullable;

import com.example.smsspamdetection.Model.ShortMessageService;
import com.example.smsspamdetection.Util.Utils;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class DatabaseHandler extends SQLiteOpenHelper {

    public DatabaseHandler(@Nullable Context context) {
        super(context, Utils.DB_NAME, null, Utils.DB_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String CREATE_SMS_TABLE = "CREATE TABLE " + Utils.TABLE_NAME + "("
                + Utils.COL_ID + " INTEGER PRIMARY KEY,"
                + Utils.COL_SMS_SENDER +" TEXT,"
                + Utils.COL_SMS_CONTENT + " TEXT,"
                + Utils.COL_SMS_LABEL + " TEXT,"
                + Utils.COL_DATE_NAME + " LONG);";

        db.execSQL(CREATE_SMS_TABLE);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

        db.execSQL("DROP TABLE IF EXISTS " + Utils.TABLE_NAME);

        onCreate(db);
    }

    /*
     * CRUD Operations: Create, Read, Delete Methods
     */

    // Add Grocery
    public void addSmsMessages(ShortMessageService shortMessageService){

        SQLiteDatabase db = this.getWritableDatabase();

        ContentValues values = new ContentValues();
        values.put(Utils.COL_SMS_SENDER, shortMessageService.getSmsSender());
        values.put(Utils.COL_SMS_CONTENT, shortMessageService.getSmsContent()); // column name, grocery item user have added
        values.put(Utils.COL_SMS_LABEL, shortMessageService.getSmsLabel());
        values.put(Utils.COL_DATE_NAME, java.lang.System.currentTimeMillis());

        // Insert the Row
        db.insert(Utils.TABLE_NAME, null, values);

        Log.d("Saved!!","Row Saved to DB");
    }

    // Get all SMS messages
    public List<ShortMessageService> getAllSmsMessages(){

        SQLiteDatabase db = this.getReadableDatabase();

        List<ShortMessageService> smsList = new ArrayList<>();

        Cursor cursor = db.query(Utils.TABLE_NAME, new String[]{
                        Utils.COL_ID, Utils.COL_SMS_SENDER, Utils.COL_SMS_CONTENT, Utils.COL_SMS_LABEL, Utils.COL_DATE_NAME},
                null,null,null,null, Utils.COL_DATE_NAME + " DESC");

        if(cursor.moveToNext())
            do{
                ShortMessageService shortMessageService = new ShortMessageService();
                shortMessageService.setId(Integer.parseInt(cursor.getString(cursor.getColumnIndex(Utils.COL_ID))));
                shortMessageService.setSmsSender(cursor.getString(cursor.getColumnIndex(Utils.COL_SMS_SENDER)));
                shortMessageService.setSmsContent(cursor.getString(cursor.getColumnIndex(Utils.COL_SMS_CONTENT)));
                shortMessageService.setSmsLabel(cursor.getString(cursor.getColumnIndex(Utils.COL_SMS_LABEL)));

                // convert time stamp to something readable (because it is in millis type
                java.text.DateFormat dateFormat = java.text.DateFormat.getDateInstance();
                String formattedDate = dateFormat.format(new Date(cursor.getLong(cursor.getColumnIndex(Utils.COL_DATE_NAME))).getTime());

                shortMessageService.setSmsDateSend(formattedDate);

                // add to grocery lists
                smsList.add(shortMessageService);

            } while (cursor.moveToNext());

        return smsList;
    }

    // Get Only Spam or ham SMS messages (filter the messages)
    public List<ShortMessageService> getAllSmsMessages(String smsLabel){

        SQLiteDatabase db = this.getReadableDatabase();

        List<ShortMessageService> smsList = new ArrayList<>();

        Cursor cursor = db.query(Utils.TABLE_NAME, new String[]{
                        Utils.COL_ID, Utils.COL_SMS_SENDER, Utils.COL_SMS_CONTENT, Utils.COL_SMS_LABEL, Utils.COL_DATE_NAME},
                Utils.COL_SMS_LABEL + "=?", new String[] {smsLabel},null,null, Utils.COL_DATE_NAME + " DESC");

        if(cursor.moveToNext())
            do{
                ShortMessageService shortMessageService = new ShortMessageService();
                shortMessageService.setId(Integer.parseInt(cursor.getString(cursor.getColumnIndex(Utils.COL_ID))));
                shortMessageService.setSmsSender(cursor.getString(cursor.getColumnIndex(Utils.COL_SMS_SENDER)));
                shortMessageService.setSmsContent(cursor.getString(cursor.getColumnIndex(Utils.COL_SMS_CONTENT)));
                shortMessageService.setSmsLabel(cursor.getString(cursor.getColumnIndex(Utils.COL_SMS_LABEL)));

                // convert time stamp to something readable (because it is in millis type
                java.text.DateFormat dateFormat = java.text.DateFormat.getDateInstance();
                String formattedDate = dateFormat.format(new Date(cursor.getLong(cursor.getColumnIndex(Utils.COL_DATE_NAME))).getTime());

                shortMessageService.setSmsDateSend(formattedDate);

                // add to grocery lists
                smsList.add(shortMessageService);

            } while (cursor.moveToNext());

        return smsList;
    }

    // Delete SMS messages according to id
    public void deleteSmsMessage(int id){

        SQLiteDatabase db = this.getWritableDatabase();
        db.delete(Utils.TABLE_NAME, Utils.COL_ID + " = ?",
                new String[]{String.valueOf(id)});

        db.close();
    }

    // Get Count of Spam messages
    public int getSmsSpamCount(){

        String countQuery = "SELECT * FROM " + Utils.TABLE_NAME + " WHERE " + Utils.COL_SMS_LABEL + "='spam'";

        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(countQuery, null);

        return cursor.getCount();
    }

    public int getSmsHamCount(){

        String countQuery = "SELECT * FROM " + Utils.TABLE_NAME + " WHERE " + Utils.COL_SMS_LABEL + "='ham'";

        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(countQuery, null);

        return cursor.getCount();
    }

    // Get Count
    public int getAllSmsCount(){

        String countQuery = "SELECT * FROM " + Utils.TABLE_NAME;

        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.rawQuery(countQuery, null);

        return cursor.getCount();
    }


}
