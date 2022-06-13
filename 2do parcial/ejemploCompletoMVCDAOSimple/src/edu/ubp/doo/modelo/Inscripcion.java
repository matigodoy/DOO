/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.modelo;

import edu.ubp.doo.dao.FabricaDao;
import edu.ubp.doo.dao.InscripcionDao;
import edu.ubp.doo.dto.InscripcionDto;
import java.util.Date;
import java.util.List;

/**
 *
 * @author agustin
 */
public class Inscripcion extends Modelo {
    
    private final InscripcionDao inscripcionDao;

    public Inscripcion() {
        inscripcionDao = (InscripcionDao) FabricaDao.getDao("InscripcionDaoImp");
    }
    
    public InscripcionDto buscar(int id, Date fecha) {
        InscripcionDto alumno = (InscripcionDto) inscripcionDao.buscarInscripcion(new InscripcionDto(id, null, null, fecha, ""));
        return alumno;
    }

    public InscripcionDto buscar(int id) {
        InscripcionDto alumno = (InscripcionDto) inscripcionDao.buscarInscripcion(id);
        return alumno;
    }

    public int mayorId() {
        return inscripcionDao.mayorId();
    }

    public List<InscripcionDto> listar() {
        List<InscripcionDto> listadoAlumnos = (List<InscripcionDto>) inscripcionDao.listarInscripciones();
        return listadoAlumnos;
    }

    public boolean modificar(int idInscripcion, Date fecha, String observacion) {
        return inscripcionDao.modificarInscripcion(new InscripcionDto(idInscripcion, fecha, observacion));
    }

    public boolean borrar(int id) {
        return inscripcionDao.borrarInscripcion(id);
    }

    @Override
    protected void finalize() throws Throwable {
        inscripcionDao.cerrarConexion();
    }
}
