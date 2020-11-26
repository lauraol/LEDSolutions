package com.unip.ledsolutons;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
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
    Button botaoMinhaCarteira, buttonLogout, btProdutos;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_perfil_usuario);

        listView = findViewById(R.id.lista_usuarios);
        dao = new UsuarioDAO(this);
        botaoMinhaCarteira = (Button) findViewById(R.id.botaoMinhaCarteira);
        buttonLogout = (Button) findViewById(R.id.buttonLogout);
        pegaUsuarioPorId = dao.obterUsuarioPorId(17); // pegando meu usuario
        usuariosFiltrados.add(pegaUsuarioPorId); //lista dos dados
        ArrayAdapter<Usuario> adaptador = new ArrayAdapter<Usuario>(this, android.R.layout.simple_list_item_1, Collections.singletonList(pegaUsuarioPorId));
        listView.setAdapter(adaptador);

        botaoMinhaCarteira.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(PerfilUsuarioActivity.this, TelaCarteira.class);
                startActivity(i);
            }
        });

        btProdutos = (Button) findViewById(R.id.botaoProduto);
        btProdutos.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                Intent i = new Intent(PerfilUsuarioActivity.this, ProdutosActivity.class);
                startActivity(i);
            }
        });
    }
}