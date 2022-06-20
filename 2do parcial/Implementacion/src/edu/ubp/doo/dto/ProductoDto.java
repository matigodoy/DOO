/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dto;

import java.util.Date;

/**
 *
 * @author De Aragón, Godoy, Moyano
 */
public class ProductoDto {

    private String nombre;
    private double precio;
    private int id_producto;

    public ProductoDto() {
    }

    public ProductoDto(int id_producto) {
        this.id_producto = id_producto;
    }
    public ProductoDto(String nombre) {
        this.nombre = nombre;
    }
    public ProductoDto(String nombre,  double precio) {
        this.nombre = nombre;
        this.precio = precio;
    }

    public ProductoDto(String nombre, double precio, int id_producto) {
        this.nombre = nombre;
        this.precio = precio;
        this.id_producto = id_producto;
    }

    /**
     * @return the nombre
     */
    public String getNombre() {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    /**
     * @return the fechaNacimiento
     */
    public double getPrecio() {
        return precio;
    }

    /**
     * @param precio the precio to set
     */
    public void setPrecio(double precio) {
        this.precio = precio;
    }

    /**
     * @return the legajo
     */
    public int getId_producto() {
        return id_producto;
    }

    /**
     * @param id_producto the producto to set
     */
    public void setId_producto(int id_producto) {
        this.id_producto = id_producto;
    }

    @Override
    public String toString() {
        return  "[" + id_producto + "] "+ nombre.toUpperCase();
    }

}
