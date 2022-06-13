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
import java.util.Date;
import java.util.List;
import edu.ubp.doo.dto.AlumnoDto;
import edu.ubp.doo.dto.InscripcionDto;
import edu.ubp.doo.dto.MateriaDto;
import java.text.ParseException;
import java.text.SimpleDateFormat;

/**
 *
 * @author agustin
 */
public class AlumnoDaoImp implements AlumnoDao {

    public AlumnoDaoImp() {
    }

    @Override
    public AlumnoDto buscarAlumno(AlumnoDto alumno) {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        AlumnoDto alumnoResult = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select legajo, nombre, apellido, fechaNacimiento, sexo "
                    + "from alumnos where nombre = ? and apellido = ?";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, alumno.getNombre());
            sentencia.setString(2, alumno.getApellido());

            rs = sentencia.executeQuery();

            String nombre;
            String apellido;
            Date fechaNacimiento;
            String sexo;
            int legajo;

            while (rs.next()) {
                nombre = rs.getString("nombre");
                apellido = rs.getString("apellido");
                fechaNacimiento = new SimpleDateFormat("yyyy-MM-dd").parse(rs.getString("fechaNacimiento"));
                sexo = rs.getString("sexo");
                legajo = rs.getInt("legajo");
                alumno = new AlumnoDto(apellido, nombre, fechaNacimiento, sexo, legajo);
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
        return alumno;
    }

    @Override
    public List<AlumnoDto> listarAlumnos() {
        Connection con = null;
        Statement sentencia = null;
        ResultSet rs = null;
        List<AlumnoDto> listaAlumnos = new ArrayList<>();

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select nombre, apellido, fechaNacimiento, sexo, legajo "
                    + "from alumnos order by apellido, nombre";
            sentencia = con.createStatement();

            rs = sentencia.executeQuery(sql);

            int id;
            String nombre;
            String apellido;
            Date fechaNacimiento;
            String sexo;
            int legajo;
            AlumnoDto alumno;

            while (rs.next()) {
                nombre = rs.getString("nombre");
                apellido = rs.getString("apellido");
                fechaNacimiento = rs.getString("fechaNacimiento") != null ? new SimpleDateFormat("yyyy-MM-dd").parse(rs.getString("fechaNacimiento")) : null;
                sexo = rs.getString("sexo");
                legajo = rs.getInt("legajo");
                alumno = new AlumnoDto(apellido, nombre, fechaNacimiento, sexo, legajo);
                listaAlumnos.add(alumno);
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
        return listaAlumnos;
    }

    @Override
    public boolean insertarAlumno(AlumnoDto alumno) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "insert into alumnos (nombre, apellido, fechaNacimiento, sexo) "
                    + "values(?,?,?,?)";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, alumno.getNombre());
            sentencia.setString(2, alumno.getApellido());
            sentencia.setString(3, new SimpleDateFormat("yyyy-MM-dd hh:mm:ss").format(alumno.getFechaNacimiento()));
            sentencia.setString(4, alumno.getSexo());

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
    public boolean modificarAlumno(AlumnoDto alumno) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "update alumnos set nombre=?,apellido=?,fechaNacimiento=?,sexo=? where legajo=?";
            sentencia = con.prepareStatement(sql);
            sentencia.setString(1, alumno.getNombre());
            sentencia.setString(2, alumno.getApellido());
            sentencia.setString(3, new SimpleDateFormat("yyyy-MM-dd hh:mm:ss").format(alumno.getFechaNacimiento()));
            sentencia.setString(4, alumno.getSexo());
            sentencia.setInt(5, alumno.getLegajo());

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
    public boolean borrarAlumno(int legajo) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "delete from alumnos where legajo = ? "
                    + "and (select count(i.idMateria) "
                    + "from inscripcion i "
                    + "where i.legajo = ?) = 0";
            sentencia = con.prepareStatement(sql);
            sentencia.setInt(1, legajo);
            sentencia.setInt(2, legajo);
            
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
    public AlumnoDto buscarAlumno(int legajo) {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        AlumnoDto alumno = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select legajo, nombre, apellido, fechaNacimiento, sexo "
                    + "from alumnos where legajo = ?";
            sentencia = con.prepareStatement(sql);
            sentencia.setInt(1, legajo);

            rs = sentencia.executeQuery();

            String nombre;
            String apellido;
            Date fechaNacimiento;
            String sexo;

            while (rs.next()) {
                nombre = rs.getString("nombre");
                apellido = rs.getString("apellido");
                fechaNacimiento = new SimpleDateFormat("yyyy-MM-dd").parse(rs.getString("fechaNacimiento"));
                sexo = rs.getString("sexo");
                legajo = rs.getInt("legajo");
                alumno = new AlumnoDto(apellido, nombre, fechaNacimiento, sexo, legajo);
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
        return alumno;
    }

    @Override
    public int mayorLegajo() {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        int legajo = -1;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select MAX(legajo) "
                    + "from alumnos";
            sentencia = con.prepareStatement(sql);

            rs = sentencia.executeQuery();

            while (rs.next()) {
                legajo = rs.getInt(1);
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
        return legajo;
    }

    @Override
    public List<AlumnoDto> listarAlumnosPorCriterio(AlumnoDto alumno) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public List<MateriaDto> listarMateriasDisponibles(int legajo) {
        Connection con = null;
        PreparedStatement sentencia = null;
        ResultSet rs = null;
        List<MateriaDto> listaMaterias = new ArrayList<>();

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "select m.idMateria, m.nombre, m.descripcion "
                    + "from materias m "
                    + "where m.idMateria not in (select i.idMateria "
                    + "                            from inscripcion i "
                    + "                            where i.legajo = ?) "
                    + "order by m.nombre";

            sentencia = con.prepareStatement(sql);
            sentencia.setInt(1, legajo);

            rs = sentencia.executeQuery();

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
    public boolean insertarInscripcion(InscripcionDto inscripcion) {
        Connection con = null;
        PreparedStatement sentencia = null;

        try {
            con = ConexionSql.getInstancia().getConnection();
            String sql = "insert into inscripcion (legajo, idMateria, fecha, observacion) "
                    + "values(?,?,?,?)";
            sentencia = con.prepareStatement(sql);
            sentencia.setInt(1, inscripcion.getAlumno().getLegajo());
            sentencia.setInt(2, inscripcion.getMateria().getIdMateria());
            sentencia.setDate(3, new java.sql.Date(inscripcion.getFecha().getTime()));
            sentencia.setString(4, inscripcion.getObservacion());

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

}
