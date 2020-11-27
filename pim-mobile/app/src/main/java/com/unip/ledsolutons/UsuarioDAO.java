package com.unip.ledsolutons;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import java.util.ArrayList;
import java.util.List;

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

    public List<Usuario> obterTodos(){
        List<Usuario> usuarios = new ArrayList<>(); //criando uma lista para os usuários

        //fazendo consulta ao banco de dados
        Cursor cursor = banco.query("usuario", new String[]{"id", "nome", "email", "phone", "password"}, null, null, null, null, null);

        while (cursor.moveToNext()){
            Usuario usuario = new Usuario();
            usuario.setId(cursor.getInt(0));
            usuario.setNome(cursor.getString(1));
            usuario.setEmail(cursor.getString(2));
            usuario.setPhone(cursor.getString(3));
            usuario.setPassword(cursor.getString(4));

            usuarios.add(usuario); //após preencher os atribuitos (acima), adicionando usuário na lista
        }
        return usuarios;
    }

    public Usuario obterUsuarioPorId(int id) {
        // instanciando o objeto Usuario
        Usuario usuarioID = new Usuario();

        // Cursor que irei receber a query do usuario
        Cursor cursor = banco.query("usuario", new String[]{"id", "nome", "email", "cpf", "phone", "password"}, "id" + "= ? ", new String[]{String.valueOf(id)}, null,null, null, null);

        // verificando se o cursor retornou algum resultado
        if(cursor != null){
            cursor.moveToFirst();
            if (cursor.getCount() > 0){
                usuarioID.setId(cursor.getInt(0));
                usuarioID.setNome(cursor.getString(1));
                usuarioID.setEmail(cursor.getString(2));
                usuarioID.setPassword(cursor.getString(3));
            } else {
                // caso não retorne nenhum usuario do cursor, o retorno da função será nulo
                return null;
            }
        }
        // finalizando meu banco
        banco.close();
        return usuarioID;
    }

    public String ValidarLogin(String username, String password){
        SQLiteDatabase db = (SQLiteDatabase) getReadableDatabase();
        Cursor cursor = db.rawQuery("SELECT * FROM USUARIO WHERE username=? AND password=?", new String[] {username, password});
        if (cursor.getCount() > 0){
            return "OK";
        }
        return "ERRO";
    }

    private Object getReadableDatabase() {
        return "";
    }
}
