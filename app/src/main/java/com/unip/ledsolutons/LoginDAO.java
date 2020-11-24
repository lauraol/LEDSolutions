package com.unip.ledsolutons;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class LoginDAO {
    private Conexao conexao;
    private SQLiteDatabase banco;

    public LoginDAO(Context context){
        conexao = new Conexao(context, null); //criando conexão
        banco = conexao.getWritableDatabase(); //pegando meu banco de dados
    }

}
