
//Determine que tipo de clase es esta

public static class ProcesoCompra{

    public static void comprobarProductoInventario(string producto){
        ComprobadorInventario.comprobarInventario(producto);
    }

    public static void comprarProducto(Producto producto){
        ComprobadorInventario.RealizarCompra(producto);
        ComprobadorInventario.EliminarProductoComprado(producto);
    }



}