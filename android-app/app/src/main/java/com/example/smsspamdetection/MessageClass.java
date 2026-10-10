package com.example.smsspamdetection;

import com.google.gson.annotations.SerializedName;

public class MessageClass {

    @SerializedName("message")
    private String msg;

    @SerializedName("id")
    private String id;

    public String getMsg() {
        return msg;
    }

    public String getId() {
        return id;
    }
}
