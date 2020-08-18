using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quices : MonoBehaviour
{
    public GameObject respuesta;
    public GameObject tutorial;
    public GameObject tutorial1;
    //public string scene;
    public GameObject pregunta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame ()
    {
        if(respuesta != null)
        {
        Debug.Log("abrir");
        //SceneManager.LoadScene("jugar1");
        pregunta.SetActive(false);
        respuesta.SetActive(true);
        }
    }


    public void cerrarAlertAndContinue ()
    {
        if (tutorial != null)
        {   
            GameObject.Find("Player").GetComponent<PlayerMove>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<CameraLook>().enabled = true;
            tutorial.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;

        }
        if(tutorial1 != null)
        {
        Debug.Log("abrir");
        //SceneManager.LoadScene("jugar1");
        tutorial1.SetActive(true);
        GameObject.Find("Player").GetComponent<PlayerMove>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<CameraLook>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        }


    }
}
