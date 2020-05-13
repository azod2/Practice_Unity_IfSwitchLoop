using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pratice3 : MonoBehaviour
{
    public GameObject cube;

    private void CreatFloor()
    {
        for (float i = 0; i <= 4.5f; i+=0.5f)
        {
            for (float j = 0; j <= i; j+=0.5f)
            {
                Instantiate(cube, new Vector3(i, j, 0), Quaternion.identity);

            }                      
        }      
    }
         


    void Start()
    {
        cube.transform.localScale= new Vector3(23f, 23f, 0f);
        CreatFloor();
    }


}
