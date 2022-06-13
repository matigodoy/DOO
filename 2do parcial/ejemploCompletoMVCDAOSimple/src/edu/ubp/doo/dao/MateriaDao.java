/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dao;

import edu.ubp.doo.dto.MateriaDto;
import java.util.List;

/**
 *
 * @author agustin
 */
public interface MateriaDao extends Dao {

    MateriaDto buscarMateria(MateriaDto materia);

    MateriaDto buscarMateria(int id);

    List<MateriaDto> listarMateriasPorCriterio(MateriaDto materia);

    List<MateriaDto> listarMaterias();

    int mayorId();

    boolean insertarMateria(MateriaDto materia);

    boolean modificarMateria(MateriaDto materia);

    boolean borrarMateria(int id);
}
