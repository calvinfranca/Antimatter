using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DanoPerso : MonoBehaviour
{
    // Start is called before the first frame update
    public int dano;   
    public int vidamaxima;
    public int vidaatual;

    public BarraVida barravida;



    void Start()
    {
        vidaatual = vidamaxima;
        barravida.VidaMaxima(vidamaxima);
    }

    // Update is called once per frame
    void Update()
    {
        if (vidaatual <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Derrota");
        }
        
        
    }

   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
            Dano(dano);

    }
    public void Dano(int xDmg)
    {
        vidaatual -= xDmg;
        barravida.SetVida(vidaatual);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Cura"))
        {
            vidaatual = vidaatual + 5;
        }

    }
}   
