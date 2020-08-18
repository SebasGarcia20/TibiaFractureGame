using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraVida : MonoBehaviour
{
    public float maxHealth = 100f;
    float curHealth;
    public string respuesta;
    public UnityEngine.UI.Image barra;
    Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = barra.fillAmount;
        myAnim = GetComponent<Animator>();
        curHealth = maxHealth*100;
        barra.fillAmount = curHealth / (100);
        if(respuesta == "incorrecta")
        { 
            Debug.Log(curHealth);
            myAnim = GetComponent<Animator>();
            //curHealth -= col.GetComponent<BulletManager>().damageValue; codigo apra cuando choque con algo
            curHealth -= 20;
            barra.fillAmount = curHealth / (100);
        }
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
