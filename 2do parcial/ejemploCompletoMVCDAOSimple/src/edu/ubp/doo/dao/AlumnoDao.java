/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package edu.ubp.doo.dao;

import edu.ubp.doo.dto.AlumnoDto;
import edu.ubp.doo.dto.InscripcionDto;
import edu.ubp.doo.dto.MateriaDto;
import java.util.List;

/**
 *
 * @author agustin
 */
public interface AlumnoDao extends Dao {
    
     AlumnoDto buscarAlumno(AlumnoDto alumno);
     
     AlumnoDto buscarAlumno(int legajo);
    
     List<AlumnoDto> listarAlumnosPorCriterio(AlumnoDto alumno);
     
     List<AlumnoDto> listarAlumnos();
     
     int mayorLegajo();
     
     boolean insertarAlumno(AlumnoDto alumno);
     
     boolean modificarAlumno(AlumnoDto alumno);
     
     boolean borrarAlumno(int legajo);
     
     List<MateriaDto> listarMateriasDisponibles(int legajo);
     
     boolean insertarInscripcion(InscripcionDto inscripcion);
       
}
