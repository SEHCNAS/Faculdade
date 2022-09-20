package MeuProjeto;

public class ContaTeste {

    public static void main(String[] args){

        Conta conta = new Conta();
        conta.cliente = "Gabriel";
        conta.saldo = 4_000.00;
        conta.exibeSaldo();

//        conta.saque(2000.0);
//        conta.exibeSaldo();
//
//        conta.depositado(3000.0);
//        conta.exibeSaldo();

        Conta destino = new Conta();
        destino.saldo = 5_000.00;
        destino.cliente = "Luana";
        destino.exibeSaldo();

    }
}
