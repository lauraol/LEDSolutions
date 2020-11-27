package com.unip.ledsolutons;

import org.json.JSONArray;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

/*public class ConsumirJson {
    public static List<Criptomoeda> jsonDados(String conteudo){
        try{
            List<Criptomoeda> criptomoedaList = new ArrayList<>();
            JSONArray jsonArray = null;
            JSONObject jsonObject = null;

            jsonArray = new JSONArray(conteudo);

            for (int i = 0; i < jsonArray.length(); i++){
                jsonObject = jsonArray.getJSONObject(i);

                //para cada laço vou criar um novo objeto do tipo Criptomoeda
                Criptomoeda criptomoeda = new Criptomoeda();

                criptomoeda.setName(jsonObject.getString("name"));
                criptomoeda.setColor(jsonObject.getString("color"));
                criptomoeda.setUrl(jsonObject.getString("url"));
                criptomoeda.setUrlBook(jsonObject.getString("url_book"));
                //criptomoeda.setFees(jsonArray.getString(1));

                criptomoedaList.add(criptomoeda);
            }
            return criptomoedaList;
        }catch (Exception e){
            e.printStackTrace();
            return null;
        }
    }
}*/
