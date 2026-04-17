using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariable : MonoBehaviour
{

    int variableUno = 2;
    float variableDos = 8;
    string variableTres = "Hola, variable nueva";
    bool variableCuatro = true;





    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log(variableUno);
        Debug.Log(variableDos);
        Debug.Log(variableTres);
        Debug.Log(variableCuatro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
