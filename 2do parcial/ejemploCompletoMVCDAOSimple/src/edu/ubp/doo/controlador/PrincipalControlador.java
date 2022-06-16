/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.controlador;

import edu.ubp.doo.modelo.Producto;
import edu.ubp.doo.modelo.Modelo;
import edu.ubp.doo.vista.FrmAbmProducto;
import edu.ubp.doo.vista.InterfazVista;
import edu.ubp.doo.vista.InterfazVistaAbm;
import java.awt.event.ActionEvent;

/**
 *
 * @author agustin
 */
public class PrincipalControlador extends Controlador {

    public PrincipalControlador(InterfazVista vista, Modelo modelo) {
        VISTA = vista;
        MODELO = modelo;
    }

    public void abmAlumno(Controlador segundoControlador) {
        InterfazVistaAbm vista;
        Controlador control;


        //modelo:
        this.MODELO = new Producto();
        //vista:
        vista = new FrmAbmProducto(null, true);

        //controlador:
        control = new ProductoControlador(vista, this.MODELO);

        //configuramos la vista para que pueda enviar las acciones del usuario como eventos al controlador
        vista.setControlador(control);

        //y arrancamos la interfaz:
        vista.iniciaVista();
    }

    
    
    public void salir(ActionEvent e) {
        System.exit(0);
    }

    

}
