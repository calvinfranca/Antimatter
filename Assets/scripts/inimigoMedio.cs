using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoMedio : MonoBehaviour
{
    public GameObject projetil;
    public float timer = 0.5f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            GameObject currentball = Instantiate(projetil, transform.position + transform.forward * 2, projetil.transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);
            


            timer = 0.2f;


        }

    }
}
