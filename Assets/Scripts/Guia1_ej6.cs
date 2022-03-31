using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0 
//    en una variable llamada num1 y muestre un mensaje por pantalla indicando 
//    "el  número es par" o "el número es impar". Deberá utilizar el operador “módulo” es el caracter  %.

public class Guia1_ej6 : MonoBehaviour
{
    // Start is called before the first frame update

    public int num1;
    void Start()
    {
        if(num1%2 == 0)
        {
            Debug.Log("El número es par");
        }
        else
        {
            Debug.Log("El número es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
