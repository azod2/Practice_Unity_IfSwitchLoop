using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pratice1 : MonoBehaviour
{
    public Slider _slider ;
    private float _hp;
    public float hp { get => _slider.value; }
    
    
    
    public Text hp_result;
    


    // Start is called before the first frame update
    void Start()
    {
        _slider.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hp>=70)
            hp_result.text = "安全";
        else if (hp < 70 &&hp >= 30)
            hp_result.text = "警告";
        else
            hp_result.text = "危險";


    }
}
