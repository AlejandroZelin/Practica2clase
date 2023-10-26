using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject Personaje;
    public float offestZ, offsetY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Personaje.transform.position; para que siga al personaje
        transform.position = new Vector3(Personaje.transform.position.x, Personaje.transform.position.y + 3, Personaje.transform.position.z - 5);
    }
}
