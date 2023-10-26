using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionEsfera : MonoBehaviour
{
    public GameObject PuntoGiro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(PuntoGiro.transform.position, Vector3.up, 40 * Time.deltaTime);
    }
}
