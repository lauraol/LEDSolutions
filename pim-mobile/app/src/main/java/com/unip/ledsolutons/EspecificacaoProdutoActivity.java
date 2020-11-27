package com.unip.ledsolutons;

import android.content.Intent;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class EspecificacaoProdutoActivity extends AppCompatActivity {
    private Button button;
    private TextView textView;
    private List<Criptomoeda> criptomoedaList = new ArrayList<>();
    Button btVendas;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_especificacao_produto);
        button = (Button) findViewById(R.id.buttonInfoProduto);
        textView = (TextView) findViewById(R.id.textViewTrasDetalhes);

        // chamando button para executar a class Tarefa
        button.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                Tarefa tarefa = new Tarefa();
                tarefa.execute("https://api.bitvalor.com/v1/exchanges.json");
            }
        });

        btVendas = (Button) findViewById(R.id.buttonVendas);
        btVendas.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {
                Intent i = new Intent(EspecificacaoProdutoActivity.this, ProdutosActivity.class);
                startActivity(i);
            }
        });

    }

    // classe ConexaoAPI tem que ser executada em segundo plano
    private class Tarefa extends AsyncTask<String, String, String>{

        @Override
        protected String doInBackground(String... strings) {
            String retorno = ConexaoAPI.getDados(strings[0]);
            return retorno;
        }

        //mostrar lista de dados
        @Override
        protected void onPostExecute(String s) {
            textView.setText(s);
            //criptomoedaList = ConsumirJson.jsonDados(s);
            //exibirDados();
        }

        /*public void exibirDados(){
            if (criptomoedaList != null){
                for (Criptomoeda criptomoeda: criptomoedaList){
                    textView.append(criptomoeda.getName() + "\n");

                }
            }
        }*/
    }
}