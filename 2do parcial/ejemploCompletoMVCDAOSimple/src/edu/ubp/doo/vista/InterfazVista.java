/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.vista;

import edu.ubp.doo.controlador.Controlador;
import java.awt.event.KeyEvent;

/**
 *
 * @author agustin
 */
public interface InterfazVista {

    void setControlador(Controlador c);

    void iniciaVista();

    void imprimeMensaje(Exception... e);
    
    void limpiaVista();
    
    default void verificarInputTxt(KeyEvent e) {
        char c = e.getKeyChar();
        if (!((c == KeyEvent.VK_BACK_SPACE) || (c == KeyEvent.VK_DELETE)
                || (c == KeyEvent.VK_ENTER) || (c == KeyEvent.VK_TAB)
                || (Character.isDigit(c)))) {
            e.consume();
        }
    }

}
