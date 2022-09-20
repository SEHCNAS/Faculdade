package MeuProjeto.ExemploClasseComRetorno;

public class Matematica {

    int Maior (int PNum, int SNum){
        if(PNum > SNum){
            return PNum;
        }else{
            return SNum;
        }
    }

    double soma (double PNum, double SNum){
        return PNum + SNum;
    }

}
