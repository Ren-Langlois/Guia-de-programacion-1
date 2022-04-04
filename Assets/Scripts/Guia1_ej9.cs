using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//9. Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del total aportó cada una 
//(indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y 
//luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 


public class Guia1_ej9 : MonoBehaviour
{
    // Start is called before the first frame update
    public string pers1;
    public int cap1;
    public string pers2;
    public int cap2;
    public string pers3;
    public int cap3;

    void Start()
    {
        int captotal = cap1 + cap2 + cap3;
        int por1 = cap1 * 100 / captotal ;
        int por2 = cap2 * 100 / captotal ;
        int por3 = cap3 * 100 / captotal ;

       
        Debug.Log("Nombre: " + pers1 + ", capital aportado: $" + cap1 + ", Porcentaje del capital: %" + por1 + ", Monto total aportado: $" + captotal);
        Debug.Log("Nombre: " + pers2 + ", capital aportado: $" + cap2 + ", Porcentaje del capital: %" + por2 + ", Monto total aportado: $" + captotal);
        Debug.Log("Nombre: " + pers3 + ", capital aportado: $" + cap3 + ", Porcentaje del capital: %" + por3 + ", Monto total aportado: $" + captotal);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
