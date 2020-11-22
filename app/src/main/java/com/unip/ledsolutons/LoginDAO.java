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
  public Usuario validarLogin(String login, String senha) {

      String[] selectionArgs = new String[]{login, senha};
      Cursor cursor = banco.rawQuery("SELECT * FROM usuario WHERE nome=? AND password=?", selectionArgs);
      Usuario usuarioLinha = null;
      while (cursor.moveToNext()) {
          usuarioLinha = new Usuario();
          usuarioLinha.setNome(cursor.getString(cursor.getColumnIndex("nome")));
          usuarioLinha.setPassword(cursor.getString(cursor.getColumnIndex("password")));
      }cursor.close();
      return usuarioLinha;
  }

}
