
Perro perro = new Perro(1,"firulais","ricardo",10);
hacerSonidoAnimales(perro);


Gato gato = new Gato(2,"michifu","gatoConvotas",true);
hacerSonidoAnimales(gato);

void hacerSonidoAnimales(Animal animal){
    animal.hacerSonido();
}


class Animal{

    protected int Id {get;set;}
    protected string Nombre {get;set;}

    protected string Apodo {get;set;}

    public Animal(int id, string nombre, string apodo){
        this.Id = id;
        this.Nombre = nombre;
        this.Apodo = apodo;
    }

    public int imprimirId()
    {
        return Id; 
    }
  
    public string imprimirNombre()
    {
       return Nombre; 
    }
    public void imprimirDatos()
    {
        Console.WriteLine($"{Id} {Nombre} {Apodo}");
    }
    
    public virtual void hacerSonido(){
        Console.WriteLine(this.GetType()+" - Sonido Animal");
    }


}

class Gato : Animal{
    
    private bool bolaPeloCuello;
    public Gato(int id,string nombre,string apodo,bool bolaPeloCuello) : base(id,nombre,apodo){
       this.bolaPeloCuello = bolaPeloCuello;
    }

    public override void hacerSonido(){
        Console.WriteLine(this.GetType()+" MIAU MIAU");
    }

}

class Perro : Animal{
    private int cantidadDeSoliradidadHumanos;
    public Perro(int id,string nombre,string apodo, int cantidadDeSoliradidadHumanos) : base(id,nombre,apodo){
        this.cantidadDeSoliradidadHumanos = cantidadDeSoliradidadHumanos;
        
    }
    
    public override void hacerSonido(){
        Console.WriteLine(this.GetType()+" GUAU GUAU");
    }
}