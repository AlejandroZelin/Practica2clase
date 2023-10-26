using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiosCamara : MonoBehaviour
{
    public GameObject Personaje;
    public GameObject Enemigo;
    private bool CambioCamara = false;

    void Start()
    {
        transform.position = new Vector3(Personaje.transform.position.x, Personaje.transform.position.y + 3, Personaje.transform.position.z - 5);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.C)) 
        {
            if (CambioCamara)
            {
                CambioCamara = false;
            }
            else
            {
                
                CambioCamara = true;
            }
            
        }

        if (!CambioCamara)
        {
            transform.position = new Vector3(Personaje.transform.position.x, Personaje.transform.position.y + 3, Personaje.transform.position.z - 5);
        }
        else
        {
            transform.position = new Vector3(Personaje.transform.position.x, Personaje.transform.position.y + 2, Personaje.transform.position.z);
        }
        //transform.LookAt(Enemigo.transform.position); para que el personaje mire todo el rato al enemigo
    }

}
