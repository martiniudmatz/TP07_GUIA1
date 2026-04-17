using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculosPersonalizados : MonoBehaviour
{

    public float num1;
    public float num2;

    // Start is called before the first frame update
    void Start()
    {
        float suma = num1 + num2;
        float resta = num1 - num2;
        float multiplicacion = num1 * num2;
        float division = num1 / num2;


        Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 + " es: " + suma);
        Debug.Log("El resultado de la resta entre " + num1 + " y " + num2 + " es: " + resta);
        Debug.Log("El resultado de la multiplicacion entre " + num1 + " y " + num2 + " es: " + multiplicacion);
        Debug.Log("El resultado de la division entre " + num1 + " y " + num2 + " es: " + division);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
