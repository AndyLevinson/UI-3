using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class contraseña : MonoBehaviour


{
    
    public Inputfield ingresodatos;
    public string password = "Contraseña";

//cuando el usuario presione el boton Aceptar
//se debe escribir un mensaje en la consola
//si el texto de inputPassword coincide con 
//la contraseña predeterminada escribir "Access granted"
//sino esceibir "Access denied"



{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ejercicio()
    {

        if (ingresodatos.text == password)
        {
            Debug.log("Access granted");

        }

        else
        {
            Debug.log("Access denied");



        }
    }
}