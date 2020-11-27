package com.unip.ledsolutons;

public class Criptomoeda {
    public String name;
    public String color;
    public String url;
    public String urlBook;
    public Fees fees;

    public String getName() {
        return name;
    }

    public void setName(String nameCoin) {
        this.name = nameCoin;
    }

    public String getColor() {
        return color;
    }

    public void setColor(String colorCoin) {
        this.color = colorCoin;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getUrlBook() {
        return urlBook;
    }

    public void setUrlBook(String urlBook) {
        this.urlBook = urlBook;
    }

    public Fees getFees() {
        return fees;
    }

    public void setFees(Fees fees) {
        this.fees = fees;
    }
}
