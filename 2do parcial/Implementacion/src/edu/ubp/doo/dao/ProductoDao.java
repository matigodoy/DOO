/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dao;


import edu.ubp.doo.dto.ProductoDto;
import java.util.List;

/**
 *
 * @author De Aragón, Godoy, Moyano
 */
public interface ProductoDao extends Dao {

    ProductoDto buscarProducto(ProductoDto producto);

    ProductoDto buscarProducto(int id_producto);

    List<ProductoDto> listarProductoPorCriterio(ProductoDto producto);

    List<ProductoDto> listarProducto();

    int mayorId_producto();

    boolean insertarProducto(ProductoDto producto);

    boolean modificarProducto(ProductoDto producto);

    boolean borrarProducto(int id_producto);

}
