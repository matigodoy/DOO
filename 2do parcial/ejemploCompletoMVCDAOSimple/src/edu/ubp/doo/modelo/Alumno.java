/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.modelo;

import edu.ubp.doo.dao.FabricaDao;
import edu.ubp.doo.dto.AlumnoDto;
import java.util.Date;
import java.util.List;
import edu.ubp.doo.dao.AlumnoDao;
import edu.ubp.doo.dto.InscripcionDto;
import edu.ubp.doo.dto.MateriaDto;

/**
 *
 * @author agustin
 */
public class Alumno extends Modelo {

    private final AlumnoDao alumnoDao;

    public Alumno() {
        alumnoDao = (AlumnoDao) FabricaDao.getDao("AlumnoDaoImp");
    }

    public AlumnoDto buscar(String nombre, String apellido) {
        AlumnoDto alumno = (AlumnoDto) alumnoDao.buscarAlumno(new AlumnoDto(nombre, apellido));
        return alumno;
    }

    public AlumnoDto buscar(int legajo) {
        AlumnoDto alumno = (AlumnoDto) alumnoDao.buscarAlumno(legajo);
        return alumno;
    }

    public int mayorLegajo() {
        return alumnoDao.mayorLegajo();
    }

    public List<AlumnoDto> listar() {
        List<AlumnoDto> listadoAlumnos = (List<AlumnoDto>) alumnoDao.listarAlumnos();
        return listadoAlumnos;
    }

    public List<MateriaDto> listarMateriasDisponibles(int legajo) {
        List<MateriaDto> listadoMaterias = (List<MateriaDto>) alumnoDao.listarMateriasDisponibles(legajo);
        return listadoMaterias;
    }
    
    public boolean guardarInscripcion(int legajo, int idMateria, Date fecha, String observacion) {
        return alumnoDao.insertarInscripcion(new InscripcionDto(-1, new MateriaDto(idMateria), new AlumnoDto(legajo), fecha, observacion));
    }
    
    public boolean guardar(String apellido, String nombre, Date fechaNacimiento, String sexo) {
        return alumnoDao.insertarAlumno(new AlumnoDto(apellido, nombre, fechaNacimiento, sexo, -1));
    }

    public boolean modificar(int legajo, String apellido, String nombre, Date fechaNacimiento, String sexo) {
        return alumnoDao.modificarAlumno(new AlumnoDto(apellido, nombre, fechaNacimiento, sexo, legajo));
    }

    public boolean borrar(int legajo) {
        return alumnoDao.borrarAlumno(legajo);
    }

    @Override
    protected void finalize() throws Throwable {
        alumnoDao.cerrarConexion();
    }

}
