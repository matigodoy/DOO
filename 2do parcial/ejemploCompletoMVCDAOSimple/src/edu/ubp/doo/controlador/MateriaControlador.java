/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.controlador;

import edu.ubp.doo.dto.MateriaDto;
import edu.ubp.doo.modelo.Materia;
import edu.ubp.doo.modelo.Modelo;
import java.util.List;
import javax.swing.table.DefaultTableModel;
import edu.ubp.doo.vista.InterfazVistaAbm;

/**
 *
 * @author agustin
 */
public class MateriaControlador extends Controlador {

    public MateriaControlador(InterfazVistaAbm vista, Modelo modelo) {
        VISTA = vista;
        MODELO = modelo;
    }

    public void cargarTodas(DefaultTableModel modeloTabla) {
        modeloTabla.setRowCount(0);
        modeloTabla.fireTableDataChanged();
        List<MateriaDto> listadoMaterias = ((Materia) this.MODELO).listar();
        for (MateriaDto alu : listadoMaterias) {
            modeloTabla.addRow(new Object[]{alu.getIdMateria(), alu.getNombre(), alu.getDescripcion()});
        }
    }

    public boolean guardar(String nombre, String descripcion) {
        return ((Materia) this.MODELO).guardar(nombre.toUpperCase(), descripcion.toUpperCase());
    }

    public boolean modificar(int idAnterior, String nombre, String descripcion) {
        return ((Materia) this.MODELO).modificar(idAnterior, nombre.toUpperCase(), descripcion.toUpperCase());
    }

    public boolean borrar(int id) {
        return ((Materia) this.MODELO).borrar(id);
    }

}
