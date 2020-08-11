using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    // Start is called before the first frame update    
public Transform theDest;
public CameraLook hcameralook;
void OnMouseDown() 
{
    //GetComponent<BoxCollider>().enabled =  false;
    GetComponent<Rigidbody>().useGravity = false;
    this.transform.position = theDest.position;
    this.transform.parent = GameObject.Find("Destination").transform;
}

void OnMouseUp() {
    Debug.Log("hstop");
    this.transform.parent = null;
    GetComponent<Rigidbody>().useGravity = true;
    //GetComponent<BoxCollider>().enabled = true;
}

void OnTriggerEnter (Collider collider) 
{
    Debug.Log("collider");
    Debug.Log(collider);
    GameObject objeto1 = GameObject.Find("cilindro1");
    if (collider.gameObject.name == "fractura") 
    {
        
        GameObject.Find("Main Camera").GetComponent<CameraLook>().enabled = false;
        GameObject.Find("Player").GetComponent<PlayerMove>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        
    }
}

}
