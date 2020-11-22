package com.unip.ledsolutons;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class TelaInicial extends AppCompatActivity {
    Button buttonLogin, buttonCadastrar;




    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_inicial);

        buttonLogin = (Button) findViewById(R.id.btEntrar);
        buttonCadastrar = (Button) findViewById(R.id.regitrar);

        buttonLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(TelaInicial.this, TelaLogin.class);
                startActivity(i);
            }
        });

        buttonCadastrar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(TelaInicial.this, MainActivity.class);
                startActivity(i);
            }
        });
    }
}