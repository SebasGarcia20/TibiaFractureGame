﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespuesTiempo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tutorial;
    public CameraLook hcameralook;
    public float tiempo;
    void Start()
    {Debug.Log("esperar tiempo");
        StartCoroutine ("Esperar");
        if(hcameralook != null){
            hcameralook = GameObject.Find("Main Camera").GetComponent<CameraLook>();
        }
        
        
    }

    // Update is called once per frame
    public IEnumerator Esperar(){
        Debug.Log("esperar entro");
        yield return new WaitForSeconds (tiempo);
        if(tutorial != null)
        {
        Debug.Log("esperar entro");
        GameObject.Find("Player").GetComponent<PlayerMove>().enabled = false;
        hcameralook.enabled = false;
        tutorial.SetActive(true);
        }

        if(hcameralook != null){
            hcameralook.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }

    }
    
}
