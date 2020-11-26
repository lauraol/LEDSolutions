package com.unip.ledsolutons;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.support.annotation.Nullable;

public class Conexao extends SQLiteOpenHelper {

    private static  String name = "banco.db";
    private static  int version = 1;

    public Conexao(@Nullable Context context, @Nullable SQLiteDatabase.CursorFactory factory) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("create table USUARIO(id integer primary key autoincrement, nome varchar(50), email varchar(50), cpf varchar(30), phone varchar(10), password varchar(50))");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
    }

}
