/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.controlador;

import edu.ubp.doo.dto.InscripcionDto;
import edu.ubp.doo.modelo.Inscripcion;
import edu.ubp.doo.modelo.Modelo;
import edu.ubp.doo.vista.FrmAbmInscripcion;
import edu.ubp.doo.vista.InterfazVista;
import edu.ubp.doo.vista.InterfazVistaAbm;
import java.text.SimpleDateFormat;
import java.util.List;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author agustin
 */
public class InscripcionControlador extends Controlador {

    Controlador controladorPrincipal;

    public InscripcionControlador(InterfazVistaAbm vista, Modelo modelo, Controlador principal) {
        VISTA = vista;
        MODELO = modelo;
        this.controladorPrincipal = principal;
    }
    
    public void cargarTodas(DefaultTableModel... modeloTabla) {
        DefaultTableModel modelo;
        if(modeloTabla.length > 0) {
            modelo = modeloTabla[0];
        } else {
            modelo = ((FrmAbmInscripcion) this.VISTA).getModeloTbl();
        }
        modelo.setRowCount(0);
        modelo.fireTableDataChanged();
        List<InscripcionDto> listadoInscripciones = ((Inscripcion) this.MODELO).listar();
        for (InscripcionDto ins : listadoInscripciones) {
            modelo.addRow(new Object[]{ins.getIdInscripcion(), new SimpleDateFormat("dd-MM-yyyy").format(ins.getFecha()), ins.getAlumno().toString(), ins.getMateria().toString()});
        }
        ((FrmAbmInscripcion) this.VISTA).getLblTotalFilasTabla().setText("Total filas: " + modelo.getRowCount());
    }
    
    public boolean borrar(int id) {
        return ((Inscripcion) this.MODELO).borrar(id);
    }
    
    public void abrirInscripcion() {
        ((PrincipalControlador)this.controladorPrincipal).abmAlumno(this);
    }

    

}
