//Determine que tipo de clase es esta


public static class ComprobadorInventario{

    private static ProductsInventario inventarioProductos = new ProductsInventario();

    public static void comprobarInventario(string producto){
        if(inventarioProductos.devolverItem(producto))
            Console.WriteLine("Si hay producto");
        else
            Console.WriteLine("No hay producto");
    }

    public static void RealizarCompra(string producto){
        if(inventarioProductos.devolverItem != null)
            Console.WriteLine("Producto comprado");
        else
            Console.WriteLine("prodcuto no comprado");
    }


    public static void EliminarProductoComprado(Producto producto){
        inventarioProductos.removerItem(producto);
    }

    

}



