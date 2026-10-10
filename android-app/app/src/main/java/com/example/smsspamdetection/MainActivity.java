package com.example.smsspamdetection;

import androidx.appcompat.app.AppCompatActivity;

import android.Manifest;
import android.app.AlertDialog;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.content.res.Resources;
import android.graphics.drawable.GradientDrawable;
import android.os.Build;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import com.example.smsspamdetection.Data.DatabaseHandler;
import com.example.smsspamdetection.R;

import java.util.List;

public class MainActivity extends AppCompatActivity {

    private String smsLabelVar;

    private TextView tvCountSpamSms;
    private TextView tvCountHamSms;

    private AlertDialog.Builder alertDialogBuilder;
    private AlertDialog dialog;
    // because we get that xml from layouts so we do inflating
    private LayoutInflater inflater;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M && checkSelfPermission(Manifest.permission.RECEIVE_SMS)
                != PackageManager.PERMISSION_GRANTED) {
            requestPermissions(new String[]{Manifest.permission.RECEIVE_SMS}, 1000);
        }

        // get strokes color back to default values
        strokeColorChangingDefault();

        // database handler object
        DatabaseHandler db = new DatabaseHandler(this);
        // showing the number of spam and ham messages
        tvCountSpamSms = findViewById(R.id.lblNumSpam);
        tvCountHamSms = findViewById(R.id.lblNumHam);
        tvCountSpamSms.setText("Number of Spam SMS : " + String.valueOf(db.getSmsSpamCount()));
        tvCountHamSms.setText("Number of Normal SMS : " + String.valueOf(db.getSmsHamCount()));

    }


    @Override
    public void onRequestPermissionsResult(int requestCode, String[] permissions, int[] grantResults) {
        if(requestCode == 1000){
            if(grantResults[0] == PackageManager.PERMISSION_GRANTED){
                Toast.makeText(this,"Permission Granted!", Toast.LENGTH_SHORT).show();
            } else {
                Toast.makeText(this,"Permission not Granted!", Toast.LENGTH_SHORT).show();
                finish();
            }
        }
    }

    public void onSpamMessagesButtonClick(View view) {

        strokeColorChangingSpam();

        DatabaseHandler db = new DatabaseHandler(this);
        if(db.getSmsSpamCount() > 0){
        Intent intent = new Intent(MainActivity.this, ListActivity.class);
        smsLabelVar = "spam";
        intent.putExtra("smsLabelIdentifier", smsLabelVar);
        startActivity(intent);
        } else {
            alertDialogBuilder = new AlertDialog.Builder(this);
            inflater = LayoutInflater.from(this);
            View v = inflater.inflate(R.layout.error_dialog, null);

            Button okButton = v.findViewById(R.id.okButton);

            alertDialogBuilder.setView(v);
            dialog = alertDialogBuilder.create();
            dialog.show();

            okButton.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    dialog.dismiss();
                    strokeColorChangingDefault();
                }
            });
        }
    }

    public void onHamMessagesButtonClick(View view){

        strokeColorChangingHam();

        DatabaseHandler db = new DatabaseHandler(this);
        if(db.getSmsHamCount() > 0){
        Intent intent = new Intent(MainActivity.this, ListActivity.class);
        smsLabelVar = "ham";
        intent.putExtra("smsLabelIdentifier", smsLabelVar);
        startActivity(intent);
        } else {
            alertDialogBuilder = new AlertDialog.Builder(this);
            inflater = LayoutInflater.from(this);
            View v = inflater.inflate(R.layout.error_dialog, null);

            Button okButton = v.findViewById(R.id.okButton);

            alertDialogBuilder.setView(v);
            dialog = alertDialogBuilder.create();
            dialog.show();

            okButton.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    dialog.dismiss();
                    strokeColorChangingDefault();
                }
            });
        }
    }

    public void onAboutButtonClick(View view){

        strokeColorChangingAbout();

        Intent intent = new Intent(MainActivity.this, AboutActivity.class);
        startActivity(intent);
    }


    public void strokeColorChangingSpam(){

        LinearLayout linearLayout = findViewById(R.id.linearSpamMessages);
        //To change the stroke color
        GradientDrawable drawable = (GradientDrawable)linearLayout.getBackground();
        drawable.setStroke( convertDpToPx(3), getResources().getColor(R.color.colorBlueLight));
    }

    public void strokeColorChangingHam(){

        LinearLayout linearLayout = findViewById(R.id.linearHamMessages);
        //To change the stroke color
        GradientDrawable drawable = (GradientDrawable)linearLayout.getBackground();
        drawable.setStroke( convertDpToPx(3), getResources().getColor(R.color.colorBlueLight));
    }

    public void strokeColorChangingAbout(){

        LinearLayout linearLayout = findViewById(R.id.linearAbout);
        //To change the stroke color
        GradientDrawable drawable = (GradientDrawable)linearLayout.getBackground();
        drawable.setStroke( convertDpToPx(3), getResources().getColor(R.color.colorBlueLight));
    }

    private int convertDpToPx(int dp){
        return (int) (dp * Resources.getSystem().getDisplayMetrics().density);
    }

    public void strokeColorChangingDefault(){

        LinearLayout linearLayoutPrivate = findViewById(R.id.linearSpamMessages);
        //To change the stroke color
        GradientDrawable drawablePrivate = (GradientDrawable)linearLayoutPrivate.getBackground();
        drawablePrivate.setStroke( 3 , getResources().getColor(R.color.colorWhite));

        LinearLayout linearLayoutPublic = findViewById(R.id.linearHamMessages);
        //To change the stroke color
        GradientDrawable drawablePublic = (GradientDrawable)linearLayoutPublic.getBackground();
        drawablePublic.setStroke( 3 , getResources().getColor(R.color.colorWhite));

        LinearLayout linearLayoutApp = findViewById(R.id.linearAbout);
        //To change the stroke color
        GradientDrawable drawableApp = (GradientDrawable)linearLayoutApp.getBackground();
        drawableApp.setStroke( 3 , getResources().getColor(R.color.colorWhite));
    }

}
