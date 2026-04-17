using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{

    string nombre = "martin";
    int edad = 16;
    float estatura = 1.79f;
    bool esDonante = true;
    
    // Start is called before the first frame update
    void Start()
    {
        string mensajeDonante;

        if (esDonante){
            mensajeDonante = "y soy donante";
        }

        else{
            mensajeDonante = "y no soy donante";
        }
        Debug.Log(" Mi nombre es " +  nombre + ",  tengo " + edad + ", y mido " + estatura + mensajeDonante);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
