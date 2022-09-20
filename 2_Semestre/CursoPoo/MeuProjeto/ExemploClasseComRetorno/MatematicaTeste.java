package MeuProjeto.ExemploClasseComRetorno;

public class MatematicaTeste {
    public static void main(String[] args){
        //Instacia um novo objeto
        Matematica m = new Matematica();

        //Chamada do metodo que retorna qual o maior numero
        int maior = m.Maior(20, 30);
        System.out.println(maior);

        //Chamada do metodo soma
        double soma = m.soma(20, 40);
        System.out.println(soma);

    }
}
