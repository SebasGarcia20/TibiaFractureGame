using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public GameObject quiz;
    public CameraLook hcameralook;
    
    // Update is called once per frame
     void Start()
    {
    
        if(hcameralook != null){
            hcameralook = GameObject.Find("Main Camera").GetComponent<CameraLook>();
        }
        
        
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 100.0f))
        {
            if(hit.transform != null)
            {
                if (hit.transform.gameObject.name == "Magnificient_glass")
                {
                    //PrintName(hit.transform.gameObject);
                    //Destroy(hit.transform.gameObject);
                    Debug.Log("abrir2");
                    quiz.SetActive(true);
                    GameObject.Find("Player").GetComponent<PlayerMove>().enabled = false;
                    hcameralook.enabled = false;
                    Cursor.lockState = CursorLockMode.None;
                }

                if (hit.transform.gameObject.name == "image_4")
                {
                    Debug.Log("Correcto!");
                    // GameObject.Find("Player").GetComponent<PlayerMove>().enabled = false;
                    // hcameralook.enabled = false;
                    // Cursor.lockState = CursorLockMode.None;
                }

            }
        }
    }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }

    private void launchQuestion()
    {
        
    }
}
