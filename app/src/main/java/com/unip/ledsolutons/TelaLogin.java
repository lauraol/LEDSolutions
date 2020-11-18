    package com.unip.ledsolutons;

    import android.content.Intent;
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
        private Button btLogin;

        @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
            setContentView(R.layout.activity_tela_login);
            //Vinculando os objetosaos seus IDs
            tEmail = (EditText) findViewById(R.id.tEmail);
            tPassword = (EditText) findViewById(R.id.tPassword);
            btLogin = (Button) findViewById(R.id.buttonLogin);
        }
         btLogin.setOnClickListener(new View.OnClickListener()

        {
            @Override
            public void onClick (View v){
            if (tEmail.getText().length() == 0 || tPassword.getText().length() == 0) {
                Toast.makeText(getApplication(),
                        "Os campos login e senha são obrigatorios",
                        Toast.LENGTH_LONG).show();

            } else {
                Toast.makeText(getApplication(),
                        "Seja bem vindo" + tEmail.getText().toString() + "!",
                        Toast.LENGTH_LONG).show();
                startActivity(new Intent(TelaLogin.this, TelaLogin.class));
                //Limpando os dados digitados programaticamente
                tEmail.setText("");
                tPassword.setText("");

  