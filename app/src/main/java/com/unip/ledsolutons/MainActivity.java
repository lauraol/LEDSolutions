
package com.unip.ledsolutons;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private EditText nome;
    private EditText email;
    private EditText cpf;
    private EditText phone;
    private EditText password;
    private UsuarioDAO dao;

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
    }

    public void salvar(View view){
        Usuario usuario = new Usuario();

        usuario.setNome(nome.getText().toString());
        usuario.setEmail(email.getText().toString());
        usuario.setCpf(cpf.getText().toString());
        usuario.setPhone(phone.getText().toString());
        usuario.setPassword(password.getText().toString());
        long id = dao.inserir(usuario);
        Toast.makeText(this, "Usuário inserido com id: " + id, Toast.LENGTH_SHORT).show();
    }
}




