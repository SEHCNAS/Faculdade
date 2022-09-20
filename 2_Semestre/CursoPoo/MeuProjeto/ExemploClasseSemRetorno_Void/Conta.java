package MeuProjeto.ExemploClasseSemRetorno_Void;

public class Conta {
    String cliente;
    double saldo;

    void exibeSaldo(){
        System.out.println(cliente + " seu saldo é " + saldo);
    }

    void saque(Double valor){
        saldo = saldo - valor;
        System.out.println("O valor do saque foi de: " + valor);
    }

    void depositado(double valor){
        saldo = saldo + valor;
        System.out.println("O valor do deposito foi de: " + valor);

    }

    void transferencia(Conta destino, double valor){
        this.saque(valor);

        destino.depositado(valor);

    }
}
