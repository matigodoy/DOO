/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dto;

/**
 *
 * @author agustin
 */
public class MateriaDto {
    private int idMateria;
    private String nombre;
    private String descripcion;

    public MateriaDto() {
    }

    public MateriaDto(int idMateria) {
        this.idMateria = idMateria;
    }

    public MateriaDto(int idMateria, String nombre, String descripcion) {
        this.idMateria = idMateria;
        this.nombre = nombre;
        this.descripcion = descripcion;
    }
    
    public int getIdMateria() {
        return idMateria;
    }

    public void setIdMateria(int idMateria) {
        this.idMateria = idMateria;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    @Override
    public String toString() {
        return nombre.toUpperCase();
    }
    
    
}
