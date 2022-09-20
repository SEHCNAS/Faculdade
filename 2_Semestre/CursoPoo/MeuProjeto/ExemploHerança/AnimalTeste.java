package MeuProjeto.ExemploHerança;

public class AnimalTeste {
    public static void main(String[] args){
        //Cria a instacia do objeto com metodos e atributos herdados
        Cachorro beagle = new Cachorro();
        beagle.comida = "Ração";
        beagle.FazerBarulho();
        beagle.dormir();

        //Cria a instacia do objeto com metodos e atributos herdados
        Galinha Merilu = new Galinha();
        Merilu.comida = "Milho";
        Merilu.botar();
        Merilu.dormir();
    }
}
