using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Time.timeScale = 1;
        }

    }
}
