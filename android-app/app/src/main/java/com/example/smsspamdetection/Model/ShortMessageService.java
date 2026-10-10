package com.example.smsspamdetection.Model;

public class ShortMessageService {

    private String smsSender;
    private String smsContent;
    private String smsDateSend;
    private String smsLabel;
    private int id;

    public ShortMessageService() {
    }

    public ShortMessageService(String smsSender, String smsContent, String smsLabel, int id) {
        this.smsContent = smsContent;
        this.smsSender = smsSender;
        this.smsLabel = smsLabel;
        this.id = id;
    }

    public ShortMessageService(String smsSender, String smsContent, String smsLabel) {
        this.smsContent = smsContent;
        this.smsSender = smsSender;
        this.smsLabel = smsLabel;
    }

    public String getSmsContent() {
        return smsContent;
    }

    public void setSmsContent(String smsContent) {
        this.smsContent = smsContent;
    }

    public String getSmsSender() {
        return smsSender;
    }

    public void setSmsSender(String smsSender) {
        this.smsSender = smsSender;
    }

    public String getSmsDateSend() {
        return smsDateSend;
    }

    public void setSmsDateSend(String smsDateSend) {
        this.smsDateSend = smsDateSend;
    }

    public String getSmsLabel() {
        return smsLabel;
    }

    public void setSmsLabel(String smsLabel) {
        this.smsLabel = smsLabel;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
}
