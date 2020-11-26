    package com.unip.ledsolutons;

    import android.content.Intent;
    import android.support.v7.app.AppCompatActivity;
    import android.os.Bundle;
    import android.view.View;
    import android.widget.Button;
    import android.widget.EditText;
    import android.widget.Toast;


    public class TelaLogin extends AppCompatActivity {

        Button buttonLogin;
        private UsuarioDAO usuarioDB;

        @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_tela_login);

            usuarioDB = new UsuarioDAO(this);

            final EditText tEmail = (EditText) findViewById(R.id.tEmail);
            final EditText tPassword = (EditText) findViewById(R.id.tPassword);
            Button btnLogin = (Button) findViewById(R.id.buttonLogin);
            Button btnRegister = (Button) findViewById(R.id.buttonCadastrar);


            buttonLogin = findViewById(R.id.buttonLogin);
            buttonLogin.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    String username = ((EditText) findViewById(R.id.tEmail)).getText().toString();
                    String password = ((EditText) findViewById(R.id.tPassword)).getText().toString();

                    Intent profileScreen = new Intent(TelaLogin.this, PerfilUsuarioActivity.class);
                    startActivity(profileScreen);

                    if(username.equals("")){
                        Toast.makeText(TelaLogin.this, "E-mail não inserido, tente novamente", Toast.LENGTH_SHORT).show();
                    }else if(password.equals("")){
                        Toast.makeText(TelaLogin.this, "Senha não inserida, tente novamente", Toast.LENGTH_SHORT).show();
                    } else {
                        // aqui deu bom
                        String res = usuarioDB.ValidarLogin(username, password);

                        if (res.equals("OK")){
                            Toast.makeText(TelaLogin.this, "Login OK", Toast.LENGTH_SHORT).show();
                        } else{
                            Toast.makeText(TelaLogin.this, "Login errado, tente novamente", Toast.LENGTH_SHORT).show();
                        }
                    }
                }
            });

            btnRegister.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent registerScreen = new Intent(TelaLogin.this, MainActivity.class);
                    startActivity(registerScreen);
                }
            });

        }

    }
