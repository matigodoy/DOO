/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package edu.ubp.doo.dao;

import java.lang.reflect.InvocationTargetException;

/**
 *
 * @author agustin
 */
public abstract class FabricaDao {

    public static Dao getDao(String nombreClase){
        try {            
            return (Dao) Class.forName(FabricaDao.class.getPackageName() + "." + nombreClase).getDeclaredConstructor().newInstance();
        } catch (ClassNotFoundException | IllegalAccessException | IllegalArgumentException | InstantiationException | NoSuchMethodException | SecurityException | InvocationTargetException e) {
            System.err.println(e);
            throw new IllegalArgumentException();
        }
    }
}
