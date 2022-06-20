/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.modelo;

import edu.ubp.doo.dao.FabricaDao;
import edu.ubp.doo.dto.ProductoDto;
import java.util.List;
import edu.ubp.doo.dao.ProductoDao;

/**
 *
 * @author De Aragón, Godoy, Moyano
 */
public class Producto extends Modelo {

    private final ProductoDao productoDao;

    public Producto() {
        productoDao = (ProductoDao) FabricaDao.getDao("ProductoDaoImp");
    }

    public ProductoDto buscar(String nombre) {
        ProductoDto producto = (ProductoDto) productoDao.buscarProducto(new ProductoDto(nombre));
        return producto;
    }

    public ProductoDto buscar(int id_producto) {
        ProductoDto producto = (ProductoDto) productoDao.buscarProducto(id_producto);
        return producto;
    }

    public int mayorId_producto() {
        return productoDao.mayorId_producto();
    }

    public List<ProductoDto> listar() {
        List<ProductoDto> listadoProductos = (List<ProductoDto>) productoDao.listarProducto();
        return listadoProductos;
    }

    
    public boolean guardar(String nombre, String Precio) {
        return productoDao.insertarProducto(new ProductoDto(nombre, Double.parseDouble(Precio), -1));
    }

    public boolean modificar(int id_producto, String nombre, String precio) {
        return productoDao.modificarProducto(new ProductoDto(nombre, Double.parseDouble(precio), id_producto));
    }

    public boolean borrar(int id_producto) {
        return productoDao.borrarProducto(id_producto);
    }

    /*
    @Override
    protected void finalize() throws Throwable {
        productoDao.cerrarConexion();
    }*/

}
