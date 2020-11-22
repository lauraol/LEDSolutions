package com.unip.ledsolutons;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;

public class TelaCarteira extends AppCompatActivity {

    ImageButton buttonBack;
    Button btLogout;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_carteira);

        btLogout = (Button) findViewById(R.id.btLogout);
        buttonBack = (ImageButton)findViewById(R.id.btBack);


        buttonBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(TelaCarteira.this, PerfilUsuarioActivity.class);
                startActivity(i);
            }
        });



        btLogout.setOnClickListener(new View.OnClickListener(){
            @Override
                    public void onClick(View v) {
                Intent i = new Intent(TelaCarteira.this, TelaLogin.class);
                startActivity(i);
            }
        });
    }

}