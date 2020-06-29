using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boss : MonoBehaviour
{
    public GameObject projetil;
    public float timer = 0.5f;
    public float timer2 = 1f;
    public float wandertime;
    public float velocidade;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timer2 -= Time.deltaTime;
        
        if (wandertime > 0)
        {
            transform.Translate(Vector3.forward * velocidade);
            
       
        }
        else
        {
            wandertime = 3.0f;
            //Wander();
        }
        
        if (timer2 <= 0.0f)
        {
            transform.Rotate(0, 45, 0);
            timer2 = 1f;
        }
        if (timer <= 0.0f)
        {
            GameObject currentball = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball1 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
            currentball1.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball2 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
            currentball2.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball3 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
            currentball3.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball4 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
            currentball4.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball5 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
            currentball5.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball6 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
            currentball6.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            transform.Rotate(0, 45, 0);
            GameObject currentball7 = Instantiate(projetil, transform.position + transform.forward * 4, projetil.transform.rotation);
            currentball7.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            


            timer = 0.5f;


        }

    }

    private void Wander()
    {
        transform.eulerAngles = new Vector3(0, UnityEngine.Random.Range(0, 360), 0);
    }
}
