using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numeros : MonoBehaviour
{
    public int numero1;
    public int numero2;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = numero1; i <= numero2; i++)
        {
            Debug.Log(i);
        }

        for (int i = 25; i >= 4; i--)
        {
            if (i == 13)
            {
                continue;
            }
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
