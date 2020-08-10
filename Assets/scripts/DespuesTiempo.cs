using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespuesTiempo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tutorial;
    public CameraLook hcameralook;
    
    void Start()
    {
        StartCoroutine ("Esperar");
        if(hcameralook != null){
            hcameralook = GameObject.Find("Main Camera").GetComponent<CameraLook>();
        }
        
        
    }

    // Update is called once per frame
    IEnumerator Esperar(){
        yield return new WaitForSeconds (5);
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
