package com.example.webviewestatico

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.webkit.WebView
import android.widget.Button
import android.widget.Toast

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        //instancia do objeto WebView adicionado ao layout
        val VWPrincipal: WebView = findViewById(R.id.WVPrincipal);

        //habilita os controles javascript no WebView
        VWPrincipal.settings.javaScriptEnabled = true;

        //instancia do objeto button adicionado ao layout
        val BtExecutar = findViewById<Button>(R.id.BtExecutar);

        //Defini o evento que carrega o webView
        BtExecutar.setOnClickListener{

            Toast.makeText(this, "Botão acionado", Toast.LENGTH_SHORT);

            //código que carrega o arquivo html do diretório para o WebView
            VWPrincipal.loadUrl("file:///android_asset/Pagina.html");

        }
    }
}