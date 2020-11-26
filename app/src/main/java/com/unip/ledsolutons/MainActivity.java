
package com.unip.ledsolutons;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private EditText nome;
    private EditText email;
    private EditText cpf;
    private EditText phone;
    private EditText password;
    private UsuarioDAO dao;
    ImageButton buttonBack;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        nome = findViewById(R.id.fieldName);
        email = findViewById(R.id.fieldEmail);
        cpf = findViewById(R.id.fieldCPF);
        phone = findViewById(R.id.fieldPhone);
        password = findViewById(R.id.fieldPassword);
        dao = new UsuarioDAO(this);

        buttonBack = (ImageButton)findViewById(R.id.btBack2);

        buttonBack.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MainActivity.this, TelaLogin.class);
                startActivity(i);
            }
        });

    }

    public void salvar(View view){
        Usuario usuario = new Usuario();

        SharedPreferences preferences = getSharedPreferences("MYPREFS",MODE_PRIVATE);
        usuario.setNome(nome.getText().toString());
        usuario.setEmail(email.getText().toString());
        usuario.setCpf(cpf.getText().toString());
        usuario.setPhone(phone.getText().toString());
        usuario.setPassword(password.getText().toString());
        long id = dao.inserir(usuario);

        Toast.makeText(this, "Usuário inserido com id: " + id, Toast.LENGTH_SHORT).show();
    }
}




