package MeuProjeto.TratamentoDeErros;

import java.util.InputMismatchException;
import java.util.Scanner;

public class DividePorZero {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);

            try {

                System.out.println("Numero: ");
                int a = s.nextInt();

                System.out.println("divisor: ");
                int b = s.nextInt();

                System.out.println(a / b);

            }
            catch (InputMismatchException e1) {
                System.out.println("Inserir somente valores inteiros: ");

            } //Pega a excessão caso o valor digitado sera diferentes do valor esperado

            catch (Throwable e2) {
                System.err.println("Erro de .ArithmeticException capturado! ");
            } //Pega o erro de divisão por 0

            finally {
                System.out.println("Executando o finally!!");
            }
    }
}
