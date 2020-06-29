using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarraProgresso : MonoBehaviour
{
    public float max;
    public float atual=11;
    public float min=0;
    
    public Image fill;
    
    public Controle control;
    public float timer=1; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        max = control.cooldown;
        
        atual = control.cooldown - control.tempo;

      
        
        float fillAmount = (float)atual /(float)max;
        fill.fillAmount = fillAmount;

        
    }
}
