/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.modelo;

import edu.ubp.doo.dao.FabricaDao;
import edu.ubp.doo.dao.MateriaDao;
import edu.ubp.doo.dto.MateriaDto;
import java.util.List;

/**
 *
 * @author agustin
 */
public class Materia extends Modelo {
    private final MateriaDao materiaDao;

    public Materia() {
        materiaDao = (MateriaDao) FabricaDao.getDao("MateriaDaoImp");
    }
    
    public MateriaDao buscar(String nombre, String apellido) {
        MateriaDao materia = (MateriaDao) materiaDao.buscarMateria(new MateriaDto(-1, nombre, apellido));
        return materia;
    }

    public MateriaDao buscar(int id) {
        MateriaDao materia = (MateriaDao) materiaDao.buscarMateria(id);
        return materia;
    }

    public int mayorId() {
        return materiaDao.mayorId();
    }

    public List<MateriaDto> listar() {
        List<MateriaDto> listadoMaterias = (List<MateriaDto>) materiaDao.listarMaterias();
        return listadoMaterias;
    }

    public boolean guardar(String nombre, String descripcion) {
        return materiaDao.insertarMateria(new MateriaDto(-1, nombre, descripcion));
    }

    public boolean modificar(int id, String nombre, String descripcion) {
        return materiaDao.modificarMateria(new MateriaDto(id, nombre, descripcion));
    }

    public boolean borrar(int id) {
        return materiaDao.borrarMateria(id);
    }

    @Override
    protected void finalize() throws Throwable {
        materiaDao.cerrarConexion();
    }
}
