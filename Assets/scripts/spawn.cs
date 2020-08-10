using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    void Start()
    {
        Instantiate(prefab,transform.position,transform.rotation); //instanciar un objeto en esa posición en esa rotación
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
