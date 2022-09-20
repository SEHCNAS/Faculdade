package MeuProjeto.IntergaceGrafica;

import javax.swing.*;
import javax.swing.JButton;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

//Herda os metodos do JFrame
public class MeuFrame extends JFrame{

    public MeuFrame(){
        //Inicia o metodo do JButton

        JButton botao = new JButton("Clique");
        botao.addActionListener(this::actionPerformed); //Define um evento para o botão
        getContentPane().add(botao); //Adiciona o botão na tela

        //Habilita para o usuario fechar a tela
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        //Define o tamanho da tela que sera aberta
        setSize(300, 300);
        //Define a tela como visivel
        setVisible(true);
    }

    public static void main(String[] args){
        new MeuFrame();
    }

    public void actionPerformed(ActionEvent e){
        System.out.println("Voce clicou");
    }
}
