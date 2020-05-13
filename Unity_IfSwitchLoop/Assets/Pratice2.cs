using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pratice2 : MonoBehaviour
{

   
    public Text WaterStatus;
    private bool result;
    public Dropdown WaterSwitch;



    // Update is called once per frame
    void Update()
    {
        //print(WaterSwitch.value);

        result = (WaterSwitch.value>0) ? true : false;

        if(!result)
        {
            WaterStatus.text = "回複血量";            
        }
        else
            WaterStatus.text = "回複魔力";
    }
}
