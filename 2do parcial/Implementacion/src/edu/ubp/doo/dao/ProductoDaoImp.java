/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import edu.ubp.doo.dto.ProductoDto;


/**
 *
 * @author De Aragón, Godoy, Moyano
 */
public class ProductoDaoImp implements ProductoDao {

    public ProductoDaoImp() {
    }

    @Override
    public ProductoDto buscarProducto(ProductoDto producto) {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        ProductoDto alumnoResult = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select id_producto, nombre, precio "
                    + "from productos where nombre = ?";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, producto.getNombre());

            rs = sentencia.executeQuery();

            String nombre;
            String precio;
            int id_producto;

            while (rs.next()) {
                nombre = rs.getString("nombre");
                precio = rs.getString("precio");
                id_producto = rs.getInt("id_producto");
                producto = new ProductoDto(nombre, Double.parseDouble(precio), id_producto);
            }
        } catch (SQLException e) {
            System.err.println(e);
        } finally {
            try {
                rs.close();
                sentencia.close();
            } catch (SQLException ex) {
                System.err.println(ex);
            }
        }
        return producto;
    }

    @Override
    public List<ProductoDto> listarProducto() {
        Connection con = null;
        Statement sentencia = null;
        ResultSet rs = null;
        List<ProductoDto> listaAlumnos = new ArrayList<>();

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select id_producto, nombre, precio "
                    + "from productos order by nombre";
            sentencia = con.createStatement();

            rs = sentencia.executeQuery(sql);
            
            String nombre;
            String precio;
            int id_producto;
            ProductoDto alumno;

            while (rs.next()) {
                nombre = rs.getString("nombre");
                precio = rs.getString("precio");
                id_producto = rs.getInt("id_producto");
                alumno = new ProductoDto(nombre, Double.parseDouble(precio), id_producto);
                listaAlumnos.add(alumno);
            }

        } catch (SQLException e) {
            System.err.println(e);
        } finally {
            try {
                rs.close();
                sentencia.close();
            } catch (SQLException ex) {
                System.err.println(ex);
            }
        }
        return listaAlumnos;
    }

    @Override
    public boolean insertarProducto(ProductoDto producto) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "insert into productos (nombre, precio) "
                    + "values(?,?)";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, producto.getNombre());
            sentencia.setString(2, Double.toString(producto.getPrecio()) );

            int resultado = sentencia.executeUpdate();

            return (resultado > 0);
        } catch (SQLException e) {
            System.err.println(e);
            return false;
        } finally {
            try {
                sentencia.close();
            } catch (SQLException ex) {
                System.err.println(ex);
            }
        }
    }

    @Override
    public boolean modificarProducto(ProductoDto producto) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "update productos set nombre=?,precio=? where id_producto=?";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, producto.getNombre());
            sentencia.setString(2, Double.toString(producto.getPrecio()));
            sentencia.setInt(3, producto.getId_producto());

            int resultado = sentencia.executeUpdate();

            return (resultado > 0);
        } catch (SQLException e) {
            System.err.println(e);
            return false;
        } finally {
            try {
                sentencia.close();
            } catch (SQLException ex) {
                System.err.println(ex);
            }
        }
    }

    @Override
    public boolean borrarProducto(int id_producto) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "delete from productos where id_producto = ? ";
            sentencia = con.prepareStatement(sql);
            sentencia.setInt(1, id_producto);

            int resultado = sentencia.executeUpdate();

            return (resultado > 0);
        } catch (SQLException e) {
            System.err.println(e);
            return false;
        } finally {
            try {
                sentencia.close();
            } catch (SQLException ex) {
                System.err.println(ex);
            }
        }
    }

    @Override
    public ProductoDto buscarProducto(int id_producto) {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        ProductoDto alumno = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select nombre, precio, id_producto "
                    + "from productos where id_producto = ?";
            sentencia = con.prepareStatement(sql);
            sentencia.setInt(1, id_producto);

            rs = sentencia.executeQuery();

            String nombre;
            String precio;

            while (rs.next()) {
                nombre = rs.getString("nombre");
                precio = rs.getString("precio");
                id_producto = rs.getInt("id_producto");
                alumno = new ProductoDto(nombre, Double.parseDouble(precio), id_producto);
            }

        } catch (SQLException e) {
            System.err.println(e);
        } finally {
            try {
                rs.close();
                sentencia.close();
            } catch (SQLException ex) {
                System.err.println(ex);
            }
        }
        return alumno;
    }

    @Override
    public int mayorId_producto() {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        int id_producto = -1;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select MAX(id_producto) "
                    + "from productos";
            sentencia = con.prepareStatement(sql);

            rs = sentencia.executeQuery();

            while (rs.next()) {
                id_producto = rs.getInt(1);
            }

        } catch (SQLException e) {
            System.err.println(e);
        } finally {
            try {
                rs.close();
                sentencia.close();
            } catch (SQLException ex) {
                System.err.println(ex);
            }
        }
        return id_producto;
    }

    @Override
    public List<ProductoDto> listarProductoPorCriterio(ProductoDto producto) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
