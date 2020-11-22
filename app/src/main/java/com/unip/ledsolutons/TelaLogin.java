    package com.unip.ledsolutons;

    import android.content.Context;
    import android.content.Intent;
    import android.database.Cursor;
    import android.database.sqlite.SQLiteDatabase;
    import android.support.v7.app.AppCompatActivity;
    import android.os.Bundle;
    import android.view.View;
    import android.widget.Button;
    import android.widget.EditText;
    import android.widget.Toast;


    public class TelaLogin extends AppCompatActivity {

        private EditText tEmail;
        private EditText tPassword;
        private LoginDAO dao;
        Button buttonLogin, buttonCadastrar;
        private EditText fieldName;
         private EditText fieldPassword;
        private Conexao conexao;
        private SQLiteDatabase banco;


        @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_tela_login);

            tEmail = (EditText) findViewById(R.id.tEmail);
            tPassword = (EditText) findViewById(R.id.tPassword);
            buttonLogin = (Button) findViewById(R.id.buttonLogin);
            buttonCadastrar = (Button) findViewById(R.id.buttonCadastrar);


            //se o usuário clicar no login
            buttonLogin.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    if ((tEmail.getText().length() == 0) || (tPassword.getText().length() == 0)) {
                        Toast.makeText(getApplication(),
                                "Os campos login e senha são obrigatórios",
                                Toast.LENGTH_LONG).show();

                    } else {
                        Toast.makeText(getApplication(),
                                "Seja bem vindo, " + tEmail.getText().toString() + "!",
                                Toast.LENGTH_LONG).show();
                        Intent i = new Intent(TelaLogin.this, PerfilUsuarioActivity.class);
                        startActivity(i);
                        //Limpando os dados digitados programaticamente
                        tEmail.setText("");
                        tPassword.setText("");
                    }
                }
            });

            //Se o usuário clicar no botão para se registrar
            buttonCadastrar.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Intent i = new Intent(TelaLogin.this, MainActivity.class);
                    startActivity(i);
                }
            });


/*teste - -- - - - -  -  --

            public Usuario validarLogin (String fieldName, String fieldPassword){

                String[] selectionArgs = new String[]{fieldName, fieldPassword};
                Cursor cursor = dao.getReadableDatabase().rawQuery("SELECT * FROM Usuarios WHERE usuario_nome=? AND usuario_senha=?", selectionArgs);
                Usuario usuarioLinha = null;
                while (cursor.moveToNext()) {
                    usuarioLinha = new Usuario();
                    usuarioLinha.setNome(cursor.getString(cursor.getColumnIndex("usuario_nome")));
                    usuarioLinha.setPassword(cursor.getString(cursor.getColumnIndex("usuario_senha")));
                }
                cursor.close();
                return usuarioLinha;
            }

            //  private Conexao conexao;
            //private SQLiteDatabase banco;
        public TelaLogin(Context context) {
                conexao = new Conexao(context, null); //criando conexão
                banco = conexao.getWritableDatabase(); //pegando meu banco de dados
            }
            public Usuario validarLogin (String login, String senha){

                String[] selectionArgs = new String[]{login, senha};
                Cursor cursor = banco.rawQuery("SELECT * FROM usuario WHERE nome=? AND password=?", selectionArgs);
                Usuario usuarioLinha = new Usuario();

                String fieldName = ((EditText) findViewById(R.id.fieldName)).getText().toString();
                String fieldPassword = ((EditText) findViewById(R.id.fieldPassword)).getText().toString();

                Usuario usuario = dao.validarLogin(fieldName, fieldPassword);

                //Se a variavel usuario for diferente de null

                if (usuario != null) {
                    Intent i = new Intent(TelaLogin.this, PerfilUsuarioActivity.class);
                    startActivity(i);
                } else {
                    Toast.makeText(getApplication(),
                            "Usuário e/ou senha nao conferem",
                            Toast.LENGTH_LONG).show();
                }


            }


            //Tentativa de criar validação
        }*/
        }
    }
