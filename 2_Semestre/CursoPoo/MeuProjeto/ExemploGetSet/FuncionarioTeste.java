package MeuProjeto.ExemploGetSet;

public class FuncionarioTeste {
    public static void main(String[] args){
        //Cria uma istancia do tipo Funcionario
        Funcionario funcionario = new Funcionario();

        //Define o nome do funcionario atraves do metodo set
        funcionario.setNome("Gabriel");

        //Busca o nome do funcionario atraves do metodo get
        String FuncionarioNome = funcionario.getNome();

        System.out.println(FuncionarioNome);
    }

}
