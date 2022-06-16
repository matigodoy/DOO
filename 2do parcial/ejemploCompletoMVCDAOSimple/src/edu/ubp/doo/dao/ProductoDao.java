/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package edu.ubp.doo.dao;

import edu.ubp.doo.dto.ProductoDto;
import edu.ubp.doo.dto.InscripcionDto;
import edu.ubp.doo.dto.MateriaDto;
import java.util.List;

/**
 *
 * @author agustin
 */
public interface AlumnoDao extends Dao {
    
     ProductoDto buscarAlumno(ProductoDto alumno);
     
     ProductoDto buscarAlumno(int legajo);
    
     List<ProductoDto> listarAlumnosPorCriterio(ProductoDto alumno);
     
     List<ProductoDto> listarAlumnos();
     
     int mayorLegajo();
     
     boolean insertarAlumno(ProductoDto alumno);
     
     boolean modificarAlumno(ProductoDto alumno);
     
     boolean borrarAlumno(int legajo);
     
     List<MateriaDto> listarMateriasDisponibles(int legajo);
     
     boolean insertarInscripcion(InscripcionDto inscripcion);
       
}
