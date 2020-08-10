using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tutorial;
    public string scene;
    public void PlayGame ()
    {
        if(tutorial != null)
        {
        Debug.Log("abrir");
        //SceneManager.LoadScene("jugar1");
        tutorial.SetActive(true);
        }
    }

    public void ChangeScene ()
    {
        if(scene != null){
            SceneManager.LoadScene(scene);
        }
    }

    public void cerrarAlert ()
    {
        Debug.Log(tutorial);
        if(tutorial != null)
        {
        Debug.Log("cerrar");
        //SceneManager.LoadScene("jugar1");
        tutorial.SetActive(false);
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


    }
    

}

