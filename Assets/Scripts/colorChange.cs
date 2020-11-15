using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This will get the OBJECT to CHANGE COLOR on KEY PRESS
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("R Key Press For RED");

            // This will get the OBJECT to CHANGE MATERIAL on KEY PRESS
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("P Key Press For Pink Material (blue)");

        }
    }

    /*public void ChangeColor()
    {
        Renderer render = GetComponent<Renderer>();
        render.material.SetColor("_Color", Color.red);
    }*/
}
