using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculos1 : MonoBehaviour
{

    int num1 = 15;
    int num2 = 7;
    int resultado;
    // Start is called before the first frame update
    void Start()
    {
        resultado = num1 + num2;
        Debug.Log("El resultado es: " + resultado);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
