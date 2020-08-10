﻿using UnityEngine;

public class sonido : MonoBehaviour {

    // Reference to Audio Source component
    public AudioSource fuente;
    public AudioClip clip;

    void Start() {
        fuente.clip = clip;
    }

    public void Reproducir(){
        Debug.Log("hstop");
        //función que ejecutará el botón
        fuente.Stop ();
    }

    public void ReproducirAudio(){
        //función que ejecutará el botón
        fuente.Play ();
    }
}
