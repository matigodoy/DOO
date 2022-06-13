/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package edu.ubp.doo.dao;

import edu.ubp.doo.dto.InscripcionDto;
import java.util.List;

/**
 *
 * @author agustin
 */
public interface InscripcionDao extends Dao {
    
     InscripcionDto buscarInscripcion(InscripcionDto inscripcion);
     
     InscripcionDto buscarInscripcion(int idInscripcion);
    
     List<InscripcionDto> listarInscripcionesPorCriterio(InscripcionDto inscripcion);
     
     List<InscripcionDto> listarInscripciones();
     
     int mayorId();
     
//     boolean insertarInscripcion(InscripcionDto inscripcion);
     
     boolean modificarInscripcion(InscripcionDto inscripcion);
     
     boolean borrarInscripcion(int idInscripcion);
       
}
