using System.Collections;

public class Compuertas : IValor_compleat
{
    public Compuertas(Entradas entradas){
        this.Name = Name;
        this.Valor = Valor;

        
    }

    public string Name {get;set;}
    public int Valor {get;set;}  


    public int or(Entradas entrada1, Entradas entrada2){ 
        if (entrada1.Valor ==0 && entrada2.Valor==0){
        return 0;
       }
       else {
        return 1;
       }
        //return 0;
    }
    public int and(Entradas entrada1, Entradas entrada2){
       if (entrada1.Valor ==1 && entrada2.Valor==1){
        return 1;
       }
       else {
        return 0;
       }
        //return 0;
    }
    public int not(Entradas entradas){
        if (entradas.Valor ==1){
            return 0;
        }
        else {
            return 1;
        }
        
    }
}

