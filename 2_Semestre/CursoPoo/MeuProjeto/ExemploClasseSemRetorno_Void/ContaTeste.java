package MeuProjeto.ExemploClasseSemRetorno_Void;

public class ContaTeste {

    public static void main(String[] args){

        Conta conta = new Conta();
        conta.cliente = "Gabriel";
        conta.saldo = 4_000.00;
        conta.exibeSaldo();
//      EXEMPLO DA CHAMADA DO METODO SAQUE E DEPOSITO
//        conta.saque(2000.0);
//        conta.exibeSaldo();
//
//        conta.depositado(3000.0);
//        conta.exibeSaldo();



        Conta destino = new Conta();
        destino.saldo = 5_000.00;
        destino.cliente = "Luana";

//      Exemplo da chamada do metodo de transferencia, que tbm chama o metodo de saque
        conta.transferencia(destino, 1_000);

        destino.exibeSaldo();



    }
}
