/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.controlador;

import edu.ubp.doo.dto.ProductoDto;
import edu.ubp.doo.modelo.Producto;
import edu.ubp.doo.modelo.Modelo;
import java.util.Date;
import java.util.List;
import javax.swing.table.DefaultTableModel;
import edu.ubp.doo.vista.InterfazVistaAbm;
import javax.swing.JComboBox;

public class ProductoControlador extends Controlador {

    public ProductoControlador(InterfazVistaAbm vista, Modelo modelo) {
        VISTA = vista;
        MODELO = modelo;
    }

    public void cargarTodos(DefaultTableModel modeloTabla) {
        modeloTabla.setRowCount(0);
        modeloTabla.fireTableDataChanged();
        List<ProductoDto> listadoProductos = ((Producto) this.MODELO).listar();
        for (ProductoDto prod : listadoProductos) {
            modeloTabla.addRow(new Object[]{prod.getId_producto(), prod.getNombre(), prod.getPrecio()});
        }
    }



    public boolean guardar(String nombre, String precio) {
        return ((Producto) this.MODELO).guardar(precio, nombre.toUpperCase());
    }

    public boolean modificar(int id_producto, String nombre, double precio) {
        return ((Producto) this.MODELO).modificar(id_producto, nombre.toUpperCase(), "");
    }

    public boolean borrar(int legajo) {
        return ((Producto) this.MODELO).borrar(legajo);
    }



}
