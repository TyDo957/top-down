using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public Image filbar;
    public Slider hp;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

      
    }
   public void updatebar(int currenValue , int maxvalue)
    {
        filbar.fillAmount = (float)currenValue / (float)maxvalue;
       
       
    }

}
