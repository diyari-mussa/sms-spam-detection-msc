package com.example.smsspamdetection;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

public class DetailsActivity extends AppCompatActivity {

    private String smsLabelVar;
    private TextView smsContent;
    private TextView smsDateRcv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details);

        smsContent = findViewById(R.id.tvMessageDetail);
        smsDateRcv = findViewById(R.id.tvDateRcv);

        // get value from previous activity
        Intent intent = getIntent();
        // gets the value from previous activity
        String titleSender = intent.getExtras().getString("senderIdentifier");
        String messageDate = intent.getExtras().getString("dateIdentifier");
        String messageDetail = intent.getExtras().getString("contentIdentifier");
        String messageLabel = intent.getExtras().getString("labelIdentifier");

        setTitle(titleSender);
        smsDateRcv.setText(messageDate);
        smsContent.setText(messageDetail);

        // assigning the message label
        smsLabelVar = messageLabel;
    }

    public void onBackPressed() {

        if(smsLabelVar.equals("spam")){
        Intent intent = new Intent(DetailsActivity.this, ListActivity.class);
        smsLabelVar = "spam";
        intent.putExtra("smsLabelIdentifier", smsLabelVar);
        startActivity(intent);
        } else{
            Intent intent = new Intent(DetailsActivity.this, ListActivity.class);
            smsLabelVar = "ham";
            intent.putExtra("smsLabelIdentifier", smsLabelVar);
            startActivity(intent);
        }
    }
}
