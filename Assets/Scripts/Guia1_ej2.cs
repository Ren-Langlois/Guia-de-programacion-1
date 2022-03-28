using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia1_ej2 : MonoBehaviour
{
    //2. Realizá un programa que, siendo num1 y num2 variables enteras con valores 4 y 5,  
    //  respectivamente, realice la operación correspondiente y muestre el resultado en pantalla: 
    //  a.Suma
    //  b.Producto

    // Start is called before the first frame update

    public int num1;
    public int num2;
    void Start()
    {
        num1 = 4;
        num2 = 5;

        int ressum = num1 + num2;
        Debug.Log(ressum);
        int respro = num1 * num2;
        Debug.Log(respro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
