

public class Persona : Object {
    public int Id {get;set;}
    protected string nombre;

    public void saltar(){
        Console.WriteLine(this.GetType()+" - " +"saltando");
    }
    
}