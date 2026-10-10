package com.example.smsspamdetection;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Query;

public interface JsonPlaceHolderAPI {

    @GET("messages")
    Call<List<MessageClass>> getMessagesApi(@Query("msg") String msg,
                                         @Query("id") String id);
}
