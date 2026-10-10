package com.example.smsspamdetection.UI;

import android.app.AlertDialog;
import android.content.Context;
import android.content.Intent;
import android.content.res.Resources;
import android.graphics.drawable.GradientDrawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.RelativeLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.smsspamdetection.Data.DatabaseHandler;
import com.example.smsspamdetection.DetailsActivity;
import com.example.smsspamdetection.Model.ShortMessageService;
import com.example.smsspamdetection.R;

import java.util.List;

public class RecyclerViewAdapter extends RecyclerView.Adapter<RecyclerViewAdapter.ViewHolder>{

    private Context context;
    private List<ShortMessageService> smsItems;

    // alert dialog instances
    private AlertDialog.Builder alertDialogBuilder;
    private AlertDialog dialog;
    // because we get that xml from layouts so we do inflating
    private LayoutInflater inflater;

    public RecyclerViewAdapter(Context context, List<ShortMessageService> smsItems) {
        this.context = context;
        this.smsItems = smsItems;
    }

    @NonNull
    @Override
    public RecyclerViewAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.list_row, parent, false);

        return new ViewHolder(view, context);
    }

    @Override
    public void onBindViewHolder(@NonNull RecyclerViewAdapter.ViewHolder holder, int position) {
        // here when we tap on the row we will get the id of that row
        ShortMessageService shortMessageService = smsItems.get(position);

        holder.tvSmsSender.setText(shortMessageService.getSmsSender());
        holder.tvSmsContent.setText(shortMessageService.getSmsContent());
        holder.tvSmsLabel.setText(shortMessageService.getSmsLabel());
        holder.tvSmsDateReceived.setText(shortMessageService.getSmsDateSend());
    }

    @Override
    public int getItemCount() {
        return smsItems.size();
    }


    public class ViewHolder extends RecyclerView.ViewHolder implements View.OnClickListener{

        public TextView tvSmsSender;
        public TextView tvSmsContent;
        public TextView tvSmsLabel;
        public TextView tvSmsDateReceived;
        public Button deleteButton;
        public int id;

        public ViewHolder(@NonNull View itemView, Context ctx) {
            super(itemView);

            // this will change colored messages back to default
            strokeColorChangingDefault(itemView);

            context = ctx;

            tvSmsSender = itemView.findViewById(R.id.tvSmsSender);
            tvSmsContent = itemView.findViewById(R.id.tvSmsContent);
            tvSmsLabel = itemView.findViewById(R.id.tvSmsLabel);
            tvSmsDateReceived = itemView.findViewById(R.id.tvDateReceived);

            deleteButton = itemView.findViewById(R.id.deleteButton);

            deleteButton.setOnClickListener(this);

            itemView.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    // go to next screen (means when you click on the whole item)
                    // Details activity
                    int position = getAdapterPosition();

                    ShortMessageService shortMessageService = smsItems.get(position);
                    Intent intent = new Intent(context, DetailsActivity.class);
                    intent.putExtra("id", shortMessageService.getId());
                    intent.putExtra("senderIdentifier", shortMessageService.getSmsSender());
                    intent.putExtra("contentIdentifier", shortMessageService.getSmsContent());
                    intent.putExtra("labelIdentifier", shortMessageService.getSmsLabel());
                    intent.putExtra("dateIdentifier", shortMessageService.getSmsDateSend());

                    // we cant get start activity method, the reason is: we are not inside an activity
                    // but we can get start activity method through our context
                    context.startActivity(intent);

                    strokeColorChangingHam(v);
                }
            });
        }

        @Override
        public void onClick(View v) {

            switch (v.getId()){
                case R.id.deleteButton:
                    int position = getAdapterPosition();
                    ShortMessageService shortMessageService = smsItems.get(position);
                    deleteItem(shortMessageService.getId());
                    break;
            }
        }

        public void deleteItem(final int id){

            // create an AlertDialog
            alertDialogBuilder = new AlertDialog.Builder(context);

            inflater = LayoutInflater.from(context);
            View view = inflater.inflate(R.layout.confirmation_dialog, null);

            Button noButton = view.findViewById(R.id.noButton);
            Button yesButton = view.findViewById(R.id.yesButton);

            alertDialogBuilder.setView(view);
            dialog = alertDialogBuilder.create();
            dialog.show();

            noButton.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    dialog.dismiss();
                }
            });

            yesButton.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    // delete the item
                    DatabaseHandler db = new DatabaseHandler(context);
                    // delete item
                    db.deleteSmsMessage(id);
                    smsItems.remove(getAdapterPosition());
                    notifyItemRemoved(getAdapterPosition());

                    dialog.dismiss();
                }
            });
        }
    }

    // color changing
    public void strokeColorChangingHam(View view){

        RelativeLayout relativeLayout = view.findViewById(R.id.relativeLayoutVar);
        //To change the stroke color
        GradientDrawable drawable = (GradientDrawable)relativeLayout.getBackground();
        //drawable.setStroke( convertDpToPx(3), itemView.getResources().getColor(R.color.colorBlueLight));
        drawable.setColor( view.getResources().getColor(R.color.colorGreenLight));
    }

    public void strokeColorChangingDefault(View view){

        RelativeLayout relativeLayout = view.findViewById(R.id.relativeLayoutVar);
        //To change the stroke color
        GradientDrawable drawable = (GradientDrawable)relativeLayout.getBackground();
        drawable.setColor(view.getResources().getColor(R.color.colorWhite));
    }


}
