package com.unip.ledsolutons;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;

public class ProdutosActivity extends AppCompatActivity {

    ImageButton buttonBackProdutos;

        @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_produtos);


            buttonBackProdutos = (ImageButton)findViewById(R.id.btBack3);
            buttonBackProdutos.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(ProdutosActivity.this, PerfilUsuarioActivity.class);
                startActivity(i);
            }
        });
    }
}