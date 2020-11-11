package com.unip.ledsolutons;

import android.content.ContentValues;
import android.content.Context;
import android.database.sqlite.SQLiteDatabase;

//classe que fará a comunicação com o banco de dados
public class UsuarioDAO {

    private Conexao conexao;
    private SQLiteDatabase banco;

    public UsuarioDAO(Context context){
        conexao = new Conexao(context, null); //criando conexão
        banco = conexao.getWritableDatabase(); //pegando meu banco de dados
    }

    public long inserir(Usuario usuario){
        ContentValues values = new ContentValues();

        //pegando os valores dos campos
        values.put("nome", usuario.getNome());
        values.put("email", usuario.getEmail());
        values.put("cpf", usuario.getCpf());
        values.put("phone", usuario.getPhone());
        values.put("password", usuario.getPassword());

        //usando o banco de dados
        return banco.insert("usuario", null, values);
    }
}
