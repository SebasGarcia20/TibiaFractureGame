using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_animation : MonoBehaviour
{
    public CameraLook hcameralook;
    public GameObject respuesta;
    TiempoAnimaciones despuesTiempo;
    // Start is called before the first frame update
    void Start()
    {
           
        
    }

    public void button_touch(){
        //GameObject.Find("Main Camera").GetComponent<CameraLook>().enabled = true;
        respuesta.SetActive(false);
        Debug.Log("esperar animacion");
        GameObject.Find("Player").GetComponent<Animation>().Play("moveRadiografias");

        //despuesTiempo=GameObject.FindGameObjectWithTag("DespuesT").GetComponent<DespuesTiempo>();
        //Canvas = GameObject.Find("Canvas");
        
        GameObject.Find("Player").GetComponent<TiempoAnimaciones>().enabled = true;
        despuesTiempo=GameObject.Find("Player").GetComponent<TiempoAnimaciones>();
        despuesTiempo.EsperaTiempo(); 

        //scriptT = FindObjectOfType<TiempoAnimaciones>();
        //scriptT.EsperaTiempo();
    }
}
