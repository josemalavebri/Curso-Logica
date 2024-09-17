

//Determine que tipo de clase es esta


public class Inventario{

}

 
 public  class  ProductsInventario{

    private  List<Product> productos;


    public ProductsInventario(){
      List<Products> productos = new List<Products>()
        {
            new Products(1, "Leche", 2.00),
            new Products(2, "Pan", 1.50),
            new Products(3, "Arroz", 3.00),
            new Products(4, "Aceite", 5.00),
            new Products(5, "Huevos", 2.50),
            new Products(6, "Azúcar", 1.80),
            new Products(7, "Café", 4.20),
            new Products(8, "Té", 2.50),
            new Products(9, "Queso", 6.00),
            new Products(10, "Jamón", 7.50),
            new Products(11, "Mantequilla", 3.50)
        };
    }
    public static bool comprobarInventario(string producto){
        foreach(Producto producto in productos){
            if(producto.Nombre ==producto){
                return true;
            }
        }
        return false;
    }

    public Producto devolverItem(string producto){
         foreach(Producto producto in productos){
            if(producto.Nombre ==producto){
                return producto;
                productos.Remove(producto);
            }
        }
        return null;
    }

    public void removerItem(Producto producto){
        productos.Remove(producto);
    }





}