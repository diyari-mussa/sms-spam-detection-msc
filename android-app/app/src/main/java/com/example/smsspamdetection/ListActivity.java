package com.example.smsspamdetection;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.graphics.drawable.GradientDrawable;
import android.os.Bundle;
import android.view.View;
import android.widget.RelativeLayout;

import com.example.smsspamdetection.Data.DatabaseHandler;
import com.example.smsspamdetection.Model.ShortMessageService;
import com.example.smsspamdetection.UI.RecyclerViewAdapter;

import java.util.ArrayList;
import java.util.List;

public class ListActivity extends AppCompatActivity {

    private RecyclerView recyclerView;
    private RecyclerViewAdapter recyclerViewAdapter;
    private List<ShortMessageService> smsList;
    private List<ShortMessageService> listItems;
    private DatabaseHandler db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_list);

        // get value from previous activity
        Intent intent = getIntent();
        // gets the value from previous activity such as: local ip address or public ip address
        String titleText = intent.getExtras().getString("smsLabelIdentifier");

        // set title of action bar
        if(titleText.equals("spam"))
            setTitle("Spam Messages");
        else
            setTitle("Normal Messages");

        // db: database functions
        db = new DatabaseHandler(this);
        recyclerView = findViewById(R.id.recyclerViewSms);
        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        smsList = new ArrayList<>();
        listItems = new ArrayList<>();

        // get items from database
        smsList = db.getAllSmsMessages(titleText);

        for (ShortMessageService c: smsList) {
            ShortMessageService shortMessageService = new ShortMessageService();
            shortMessageService.setSmsSender(c.getSmsSender());
            shortMessageService.setSmsContent(c.getSmsContent());
            shortMessageService.setSmsLabel(c.getSmsLabel());
            shortMessageService.setSmsDateSend(c.getSmsDateSend());
            shortMessageService.setId(c.getId());

            listItems.add(shortMessageService);
        }

        recyclerViewAdapter = new RecyclerViewAdapter(this, listItems);
        recyclerView.setAdapter(recyclerViewAdapter);
        recyclerViewAdapter.notifyDataSetChanged();

    }

    public void onBackPressed() {
        Intent intent = new Intent(ListActivity.this, MainActivity.class);
        startActivity(intent);
    }

}
