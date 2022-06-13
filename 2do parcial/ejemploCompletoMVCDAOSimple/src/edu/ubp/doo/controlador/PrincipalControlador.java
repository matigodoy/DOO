/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.controlador;

import edu.ubp.doo.modelo.Alumno;
import edu.ubp.doo.modelo.Inscripcion;
import edu.ubp.doo.modelo.Materia;
import edu.ubp.doo.modelo.Modelo;
import edu.ubp.doo.vista.FrmAbmAlumno;
import edu.ubp.doo.vista.FrmAbmMateria;
import edu.ubp.doo.vista.FrmAbmInscripcion;
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

        InscripcionControlador inscCtrl = null;
        if (segundoControlador instanceof InscripcionControlador) {
            inscCtrl = (InscripcionControlador) segundoControlador;
        }
        //modelo:
        this.MODELO = new Alumno();
        //vista:
        vista = new FrmAbmAlumno(null, true);

        //controlador:
        control = new AlumnoControlador(vista, this.MODELO, inscCtrl);

        //configuramos la vista para que pueda enviar las acciones del usuario como eventos al controlador
        vista.setControlador(control);

        //y arrancamos la interfaz:
        vista.iniciaVista();
    }

    public void abmMateria() {
        InterfazVistaAbm vista;
        Controlador control;
        //modelo:
        this.MODELO = new Materia();
        //vista:
        vista = new FrmAbmMateria(null, true);

        //controlador:
        control = new MateriaControlador(vista, this.MODELO);

        //configuramos la vista para que pueda enviar las acciones del usuario como eventos al controlador
        vista.setControlador(control);

        //y arrancamos la interfaz:
        vista.iniciaVista();
    }

    public void abmInscripcion() {
        InterfazVistaAbm vista;
        Controlador control;
        //modelo:
        this.MODELO = new Inscripcion();
        //vista:
        vista = new FrmAbmInscripcion(null, true);

        //controlador:
        control = new InscripcionControlador(vista, this.MODELO, this);

        //configuramos la vista para que pueda enviar las acciones del usuario como eventos al controlador
        vista.setControlador(control);

        //y arrancamos la interfaz:
        vista.iniciaVista();
    }
    
    public void salir(ActionEvent e) {
        System.exit(0);
    }

    

}
