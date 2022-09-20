package MeuProjeto.ExemploGetSet;

public class Funcionario {
    private String nome;
    private boolean ativo;

    public String getNome(){
        return nome;
    } //Busca o nome do funcionario

    public void setNome(String nome){
        this.nome = nome;
    }//Define o atributo nome da instancia atual

    public boolean isAtivo(){
        return this.ativo;
    }//Busca se o funcionario esta ativo

    public void setAtivo(boolean ativo){
        this.ativo = ativo;
    }//Define o atributo ativo da instancia atual
}
