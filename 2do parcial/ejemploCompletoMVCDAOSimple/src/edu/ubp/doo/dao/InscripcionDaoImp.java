/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dao;

import edu.ubp.doo.dto.AlumnoDto;
import edu.ubp.doo.dto.InscripcionDto;
import edu.ubp.doo.dto.MateriaDto;
import java.sql.Connection;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author agustin
 */
public class InscripcionDaoImp implements InscripcionDao {


    public InscripcionDaoImp() {
        
    }
    
    @Override
    public InscripcionDto buscarInscripcion(InscripcionDto inscripcion) {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        InscripcionDto inscripcionResult = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select i.idInscripcion, i.fecha, i.observacion, "
                    + "a.legajo, a.nombre, a.apellido, a.fechaNacimiento, a.sexo, "
                    + "m.idMateria, m.nombre, m.descripcion "
                    + "from inscripcion i, materias m, alumnos a "
                    + "where "
                    + "i.legajo = a.legajo and "
                    + "i.idMateria = m.idMateria "
                    + "i.fecha = ? and i.idInscripcion = ?";
            sentencia = con.prepareStatement(sql);
            sentencia.setDate(1, (Date) inscripcion.getFecha());
            sentencia.setInt(2, inscripcion.getIdInscripcion());

            rs = sentencia.executeQuery();

            Date fecha;
            String observacion;
            AlumnoDto alumno;
            MateriaDto materia;
            int id;

            while (rs.next()) {
                alumno = new AlumnoDto(rs.getString("a.apellido"), rs.getString("a.nombre"), rs.getDate("a.fechaNacimiento"), rs.getString("a.sexo"), rs.getInt("a.legajo"));
                materia = new MateriaDto(rs.getInt("m.idMateria"), rs.getString("m.nombre"), rs.getString("m.descripcion"));
                fecha = rs.getDate("fecha");
                observacion = rs.getString("observacion");
                id = rs.getInt("idInscripcion");
                inscripcion = new InscripcionDto(id, materia, alumno, fecha, observacion);
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
        return inscripcion;
    }

    @Override
    public InscripcionDto buscarInscripcion(int id) {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        InscripcionDto inscripcionResult = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select i.idInscripcion, i.fecha, i.observacion, "
                    + "a.legajo, a.nombre, a.apellido, a.fechaNacimiento, a.sexo, "
                    + "m.idMateria, m.nombre, m.descripcion "
                    + "from inscripcion i, materias m, alumnos a "
                    + "where "
                    + "i.legajo = a.legajo and "
                    + "i.idMateria = m.idMateria and "
                    + "i.idInscripcion = ?";
            sentencia = con.prepareStatement(sql);
            sentencia.setInt(1, id);

            rs = sentencia.executeQuery();

            Date fecha;
            String observacion;
            AlumnoDto alumno;
            MateriaDto materia;

            while (rs.next()) {
                alumno = new AlumnoDto(rs.getString("a.apellido"), rs.getString("a.nombre"), rs.getDate("a.fechaNacimiento"), rs.getString("a.sexo"), rs.getInt("a.legajo"));
                materia = new MateriaDto(rs.getInt("m.idMateria"), rs.getString("m.nombre"), rs.getString("m.descripcion"));
                fecha = rs.getDate("fecha");
                observacion = rs.getString("observacion");
                id = rs.getInt("idInscripcion");
                inscripcionResult = new InscripcionDto(id, materia, alumno, fecha, observacion);
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
        return inscripcionResult;
    }

    @Override
    public List<InscripcionDto> listarInscripciones() {
        Connection con = null;
        Statement sentencia = null;
        ResultSet rs = null;
        List<InscripcionDto> listaInscripciones = new ArrayList<>();

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select i.idInscripcion, i.fecha, i.observacion, "
                    + "a.legajo, a.nombre, a.apellido, a.fechaNacimiento, a.sexo, "
                    + "m.idMateria, m.nombre as nombreMat, m.descripcion "
                    + "from inscripcion i, materias m, alumnos a "
                    + "where "
                    + "i.legajo = a.legajo and "
                    + "i.idMateria = m.idMateria "
                    + "order by i.fecha";
            sentencia = con.createStatement();

            rs = sentencia.executeQuery(sql);
            
            
            Date fecha;
            String observacion;
            AlumnoDto alumno;
            MateriaDto materia;
            InscripcionDto inscripcion = null;
            int id;
            
            while (rs.next()) {
                alumno = new AlumnoDto(rs.getString("apellido"), rs.getString("nombre"), new SimpleDateFormat("yyyy-MM-dd HH:mm:ss").parse(rs.getString("fechaNacimiento")), rs.getString("sexo"), rs.getInt("legajo"));
                materia = new MateriaDto(rs.getInt("idMateria"), rs.getString("nombreMat"), rs.getString("descripcion"));
                fecha = rs.getDate("fecha");
                observacion = rs.getString("observacion");
                id = rs.getInt("idInscripcion");
                inscripcion = new InscripcionDto(id, materia, alumno, fecha, observacion);
                listaInscripciones.add(inscripcion);
            }

        } catch (SQLException | ParseException e) {
            System.err.println(e);
        } finally {
            try {
                rs.close();
                sentencia.close();
            } catch (SQLException ex) {
                System.err.println(ex);
            }
        }
        return listaInscripciones;
    }

    @Override
    public int mayorId() {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        int id = -1;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select MAX(idInscripcion) "
                    + "from inscripcion";
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
    public boolean modificarInscripcion(InscripcionDto inscripcion) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "update inscripcion set fecha=?,observacion=? where idInscripcion=?";
            sentencia = con.prepareStatement(sql);
            sentencia.setDate(1, (Date) inscripcion.getFecha());
            sentencia.setString(2, inscripcion.getObservacion());
            sentencia.setInt(3, inscripcion.getIdInscripcion());

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
    public boolean borrarInscripcion(int id) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "delete from inscripcion where idInscripcion = ?";
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
    public List<InscripcionDto> listarInscripcionesPorCriterio(InscripcionDto inscripcion) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
    
}
