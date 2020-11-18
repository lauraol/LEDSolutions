package com.unip.ledsolutons;

import android.content.Context;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class PerfilUsuarioActivity extends AppCompatActivity {

    private ListView listView;
    private UsuarioDAO dao;
    private List<Usuario> usuarios;
    private List<Usuario> usuariosFiltrados = new ArrayList<>();
    private Usuario pegaUsuarioPorId;
    //private UsuarioDAO db = new UsuarioDAO(this);
    //Usuario user = db.obterUsuarioPorId(id);

    /*@Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perfil_usuario);

        listView = findViewById(R.id.lista_usuarios);
        dao = new UsuarioDAO(this);
        usuarios = dao.obterTodos(); //lista com todos os usuários
        usuariosFiltrados.addAll(usuarios); //lista com usuários filtrados
        ArrayAdapter<Usuario> adaptador = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, usuarios);
        listView.setAdapter(adaptador);
    }*/


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perfil_usuario);

        listView = findViewById(R.id.lista_usuarios);
        dao = new UsuarioDAO(this);

        pegaUsuarioPorId = dao.obterUsuarioPorId(2); // pegando meu usuario
        usuariosFiltrados.add(pegaUsuarioPorId); //lista dos dados
        ArrayAdapter<Usuario> adaptador = new ArrayAdapter<Usuario>(this, android.R.layout.simple_list_item_1, Collections.singletonList(pegaUsuarioPorId));

        listView.setAdapter(adaptador);
    }
}