/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.controlador;

import edu.ubp.doo.dto.AlumnoDto;
import edu.ubp.doo.dto.MateriaDto;
import edu.ubp.doo.modelo.Alumno;
import edu.ubp.doo.modelo.Modelo;
import java.util.Date;
import java.util.List;
import javax.swing.table.DefaultTableModel;
import edu.ubp.doo.vista.InterfazVistaAbm;
import javax.swing.JComboBox;

/**
 *
 * @author agustin
 */
public class AlumnoControlador extends Controlador {

    private Controlador ctrlInscripcion;

    public AlumnoControlador(InterfazVistaAbm vista, Modelo modelo, Controlador ctrlInscripcion) {
        VISTA = vista;
        MODELO = modelo;
        this.ctrlInscripcion = ctrlInscripcion;
    }

    public void cargarTodos(DefaultTableModel modeloTabla) {
        modeloTabla.setRowCount(0);
        modeloTabla.fireTableDataChanged();
        List<AlumnoDto> listadoAlumnos = ((Alumno) this.MODELO).listar();
        for (AlumnoDto alu : listadoAlumnos) {
            modeloTabla.addRow(new Object[]{alu.getLegajo(), alu.getNombre(), alu.getApellido()});
        }
    }

    public void cargarMateriasDisponibles(int legajo, DefaultTableModel modeloTabla, JComboBox cmbMaterias) {
        cmbMaterias.removeAllItems();
        List<MateriaDto> listadoMaterias = ((Alumno) this.MODELO).listarMateriasDisponibles(legajo);
        for (MateriaDto mat : listadoMaterias) {
            cmbMaterias.addItem(mat);
        }
    }

    public boolean guardar(String nombre, String apellido) {
        return ((Alumno) this.MODELO).guardar(apellido.toUpperCase(), nombre.toUpperCase(), new Date(System.currentTimeMillis()), "");
    }

    public boolean modificar(int legAnterior, String nombre, String apellido) {
        return ((Alumno) this.MODELO).modificar(legAnterior, apellido.toUpperCase(), nombre.toUpperCase(), new Date(System.currentTimeMillis()), "");
    }

    public boolean borrar(int legajo) {
        return ((Alumno) this.MODELO).borrar(legajo);
    }

    public boolean inscribir(int legajo, Object materiaDto) {
        return ((Alumno) this.MODELO).guardarInscripcion(legajo, ((MateriaDto) materiaDto).getIdMateria(), new Date(System.currentTimeMillis()), "");
    }

    public Controlador getCtrlInscripcion() {
        return ctrlInscripcion;
    }

}
