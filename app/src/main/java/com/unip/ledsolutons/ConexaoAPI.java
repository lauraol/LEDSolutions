package com.unip.ledsolutons;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class ConexaoAPI {

    public static String getDados(String uri){
        BufferedReader bufferedReader = null;

        try{
            URL url = new URL(uri);
            HttpURLConnection httpURLConnection = (HttpURLConnection) url.openConnection();

            StringBuilder stringBuilder = new StringBuilder();
            bufferedReader = new BufferedReader(new InputStreamReader(httpURLConnection.getInputStream()));  //armazenando dados na minha API

            //criação de laço para enquanto minha var linha não for nula
            String linha;

            while((linha = bufferedReader.readLine()) != null){
                stringBuilder.append(linha + "\n");
            }

            return  stringBuilder.toString();

        }catch (Exception e){
            e.printStackTrace();
            return null;
        }finally {
            if (bufferedReader != null){
                try {
                    bufferedReader.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}
