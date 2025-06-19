using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int numero1;
    public int numero2;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        for (int i = 3; i <= 30; i += 3)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
