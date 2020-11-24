    package com.unip.ledsolutons;

    import android.content.Context;
    import android.content.Intent;
    import android.content.SharedPreferences;
    import android.database.Cursor;
    import android.database.sqlite.SQLiteDatabase;
    import android.database.sqlite.SQLiteOpenHelper;
    import android.support.v7.app.AppCompatActivity;
    import android.os.Bundle;
    import android.view.View;
    import android.widget.Button;
    import android.widget.EditText;
    import android.widget.Toast;


    public class TelaLogin extends AppCompatActivity {

        //private EditText tEmail;
        //private EditText tPassword;
        private LoginDAO dao;
        Button buttonLogin;
        private EditText fieldName;
        private EditText fieldPassword;
        private Conexao conexao;
        private SharedPreferences sharedPref;
        private SQLiteDatabase banco;


        @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_tela_login);

            final EditText tEmail = (EditText) findViewById(R.id.tEmail);
            final EditText tPassword = (EditText) findViewById(R.id.tPassword);
            Button btnLogin = (Button) findViewById(R.id.buttonLogin);
            Button btnRegister = (Button) findViewById(R.id.buttonCadastrar);


            btnLogin.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    String user = tEmail.getText().toString();
                    String password = tPassword.getText().toString();
                    SharedPreferences preferences = getSharedPreferences("MYPREFS", MODE_PRIVATE);


                    String userDetails = preferences.getString(user + password + "data","No information on that user.");
                    SharedPreferences.Editor editor = preferences.edit();
                    editor.putString("display",userDetails);
                    editor.commit();

                    Intent displayScreen = new Intent(TelaLogin.this, PerfilUsuarioActivity.class);
                    startActivity(displayScreen);
                }
            });

            btnRegister.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent registerScreen = new Intent(TelaLogin.this, MainActivity.class);
                    startActivity(registerScreen);
                }
            });

            buttonLogin = findViewById(R.id.buttonLogin);
            buttonLogin.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    String nomeLogin = ((EditText) findViewById(R.id.tEmail)).getText().toString();
                    String senhaLogin = ((EditText) findViewById(R.id.tPassword)).getText().toString();

                    UsuarioDAO dao = new UsuarioDAO(TelaLogin.this);
                    Usuario usuario = dao.validarLogin(nomeLogin, senhaLogin);

                    // Se a variável usuario for diferente de null, significa que consultou no SQLite e esse usuário existe, então:
                    if (usuario != null){
                        Intent vaiParaPerfil = new Intent(TelaLogin.this, PerfilUsuarioActivity.class);
                        startActivity(vaiParaPerfil);
                    }else{
                        Toast.makeText(TelaLogin.this, "Usuário ou senha não conferem!", Toast.LENGTH_SHORT).show();
                    }
                }
            });
        }

    }
