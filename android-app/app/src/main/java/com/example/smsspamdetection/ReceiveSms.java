package com.example.smsspamdetection;

import android.app.ActivityManager;
import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.telephony.SmsMessage;
import android.util.Log;
import android.widget.Toast;

import androidx.annotation.RequiresApi;

import com.example.smsspamdetection.Data.DatabaseHandler;
import com.example.smsspamdetection.Model.ShortMessageService;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class ReceiveSms extends BroadcastReceiver {

    private String messageSender;
    private String messageBody;
    //private String messageTime;

    JsonPlaceHolderAPI jsonPlaceHolderAPI;

    @RequiresApi(api = Build.VERSION_CODES.LOLLIPOP)
    @Override
    public void onReceive(Context context, Intent intent) {
        //Toast.makeText(context, "SMS Received!", Toast.LENGTH_SHORT).show();
        if (intent.getAction().equals("android.provider.Telephony.SMS_RECEIVED")) {
            Bundle bundle = intent.getExtras();
            SmsMessage[] msgs = null;
            String msg_from;
            StringBuilder sbMsgBody = new StringBuilder();
            if (bundle != null) {
                try {
                    Object[] pdus = (Object[]) bundle.get("pdus");
                    msgs = new SmsMessage[pdus.length];
                    for (int i = 0; i < msgs.length; i++) {
                        msgs[i] = SmsMessage.createFromPdu((byte[]) pdus[i]);
                        // assign the sender to variable and set it in function in order to be set to messageSender
                        msg_from = msgs[i].getOriginatingAddress();
                        setMessageSender(msg_from);
                        // append the message to buffer string because the message is originally in chunks
                        sbMsgBody.append(msgs[i].getMessageBody());
                        //Date currentTime = Calendar.getInstance().getTime();
                    }
                    String strMsgBody = sbMsgBody.toString();
                    setMessageBody(strMsgBody);

                    Toast.makeText(context, "From: " + getMessageSender() + ", Body: " + getMessageBody(), Toast.LENGTH_LONG).show();
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("http://212.24.103.188:8080")      //.baseUrl("http://10.0.2.2:9090")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        jsonPlaceHolderAPI = retrofit.create(JsonPlaceHolderAPI.class);

        getMessagesApi(context, getMessageBody(), getMessageSender());

    }


    public String getMessageSender() {
        return messageSender;
    }

    public void setMessageSender(String messageSender) {
        this.messageSender = messageSender;
    }

    public String getMessageBody() {
        return messageBody;
    }

    public void setMessageBody(String messageBody) {
        this.messageBody = messageBody;
    }



    private void getMessagesApi(final Context context, final String varMessage, String id) {

        Call<List<MessageClass>> call = jsonPlaceHolderAPI.getMessagesApi(varMessage, id);

        call.enqueue(new Callback<List<MessageClass>>() {
            @Override
            public void onResponse(Call<List<MessageClass>> call, Response<List<MessageClass>> response) {

                if (!response.isSuccessful()) {
                    //textViewResult.setText("code: " + response.code());
                    return;
                }

                List<MessageClass> messagesList = response.body();

                StringBuilder sbMsgHeaderResult = new StringBuilder();
                StringBuilder sbMsgBodyResult = new StringBuilder();
                for (MessageClass msg : messagesList) {
                    sbMsgHeaderResult.append(msg.getId());
                    sbMsgBodyResult.append(msg.getMsg());
                }

                Log.e("Result:","the message from:" + sbMsgHeaderResult.toString() +", is: " + sbMsgBodyResult.toString());

                DatabaseHandler db = new DatabaseHandler(context);

                // Inserting contacts
                Log.d("Inserting : ", "Inserting ...");
                db.addSmsMessages(new ShortMessageService(sbMsgHeaderResult.toString(), varMessage,sbMsgBodyResult.toString()));

                // check if the running application is the our app in order to update the messages directly
                if(getCurrentActivity(context).contains("ListActivity")) {
                    if(sbMsgBodyResult.toString().equals("ham")){
                        Intent intent = new Intent(context, ListActivity.class);
                        intent.putExtra("smsLabelIdentifier", "ham");
                        context.startActivity(intent);
                    } else {
                        Intent intent = new Intent(context, ListActivity.class);
                        intent.putExtra("smsLabelIdentifier", "spam");
                        context.startActivity(intent);
                    }
                }
                if(getCurrentActivity(context).contains("smsspamdetection.MainActivity")) {

                        Intent intent = new Intent(context, MainActivity.class);
                        context.startActivity(intent);
                }
            }

            @Override
            public void onFailure(Call<List<MessageClass>> call, Throwable t) {
                //textViewResult.setText(t.getMessage());
            }
        });
    }

    // it gets the application name package and class and everything related to the running app
    public String getCurrentActivity(Context ctx){

        ActivityManager am = (ActivityManager)ctx.getSystemService(Context.ACTIVITY_SERVICE);
        ComponentName cn = am.getRunningTasks(1).get(0).topActivity;

        return String.valueOf(cn);
    }

}

