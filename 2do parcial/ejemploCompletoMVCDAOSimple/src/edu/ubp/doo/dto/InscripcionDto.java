/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dto;

import java.util.Date;

/**
 *
 * @author agustin
 */
public class InscripcionDto {

    private int idInscripcion;
    private MateriaDto materia;
    private AlumnoDto alumno;

    private Date fecha;
    private String observacion;

    public InscripcionDto() {
    }

    public InscripcionDto(int idInscripcion) {
        this.idInscripcion = idInscripcion;
    }

    public InscripcionDto(int idInscripcion, Date fecha, String observacion) {
        this.idInscripcion = idInscripcion;
        this.fecha = fecha;
        this.observacion = observacion;
    }

    public InscripcionDto(int idInscripcion, MateriaDto materia, AlumnoDto alumno) {
        this.idInscripcion = idInscripcion;
        this.materia = materia;
        this.alumno = alumno;
    }

    public InscripcionDto(int idInscripcion, MateriaDto materia, AlumnoDto alumno, Date fecha, String observacion) {
        this.idInscripcion = idInscripcion;
        this.materia = materia;
        this.alumno = alumno;
        this.fecha = fecha;
        this.observacion = observacion;
    }

    public int getIdInscripcion() {
        return idInscripcion;
    }

    public void setIdInscripcion(int idInscripcion) {
        this.idInscripcion = idInscripcion;
    }

    public MateriaDto getMateria() {
        return materia;
    }

    public void setMateria(MateriaDto materia) {
        this.materia = materia;
    }

    public AlumnoDto getAlumno() {
        return alumno;
    }

    public void setAlumno(AlumnoDto alumno) {
        this.alumno = alumno;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public String getObservacion() {
        return observacion;
    }

    public void setObservacion(String observacion) {
        this.observacion = observacion;
    }

}
