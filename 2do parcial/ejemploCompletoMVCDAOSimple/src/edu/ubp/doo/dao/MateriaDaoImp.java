/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dao;

import edu.ubp.doo.dto.MateriaDto;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author agustin
 */
public class MateriaDaoImp implements MateriaDao {


    public MateriaDaoImp() {
        
    }
    
    @Override
    public MateriaDto buscarMateria(MateriaDto materia) {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        MateriaDto materiaResult = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select idMateria, nombre, descripcion "
                    + "from materias where nombre = ? and adescripcion = ?";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, materia.getNombre());
            sentencia.setString(2, materia.getDescripcion());

            rs = sentencia.executeQuery();

            String nombre;
            String descripcion;
            int id;

            while (rs.next()) {
                nombre = rs.getString("nombre");
                descripcion = rs.getString("descripcion");
                id = rs.getInt("idMateria");
                materia = new MateriaDto(id, nombre, descripcion);
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
        return materia;
    }

    @Override
    public MateriaDto buscarMateria(int id) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public List<MateriaDto> listarMaterias() {
        Connection con = null;
        Statement sentencia = null;
        ResultSet rs = null;
        List<MateriaDto> listaMaterias = new ArrayList<>();

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select idMateria, nombre, descripcion "
                    + "from materias order by nombre";
            sentencia = con.createStatement();

            rs = sentencia.executeQuery(sql);

            int id;
            String nombre;
            String descripcion;
            MateriaDto materia;

            while (rs.next()) {
                nombre = rs.getString("nombre");
                descripcion = rs.getString("descripcion");
                id = rs.getInt("idMateria");
                materia = new MateriaDto(id, nombre, descripcion);
                listaMaterias.add(materia);
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
        return listaMaterias;
    }

    @Override
    public int mayorId() {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        int id = -1;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select MAX(idMateria) "
                    + "from materias";
            sentencia = con.prepareStatement(sql);

            rs = sentencia.executeQuery();

            while (rs.next()) {
                id = rs.getInt(1);
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
        return id;
    }

    @Override
    public boolean insertarMateria(MateriaDto materia) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "insert into materias (nombre, descripcion) "
                    + "values(?,?)";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, materia.getNombre());
            sentencia.setString(2, materia.getDescripcion());

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
    public boolean modificarMateria(MateriaDto materia) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "update materias set nombre=?,descripcion=? where idMateria=?";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, materia.getNombre());
            sentencia.setString(2, materia.getDescripcion());
            sentencia.setInt(3, materia.getIdMateria());

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
    public boolean borrarMateria(int id) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "delete from materias where idMateria = ?";
            sentencia = con.prepareStatement(sql);
            sentencia.setInt(1, id);

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
    public List<MateriaDto> listarMateriasPorCriterio(MateriaDto materia) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    
}
