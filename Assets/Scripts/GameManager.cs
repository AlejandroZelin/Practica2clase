using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    float Tiempo;
    private bool Final;
    public TMP_Text TextoTiempo;
    public TMP_Text TextoFinal;
    public GameObject Panel;
    public GameObject Terrain;
    public GameObject Personaje;
    public GameObject Decoracion;
    private bool Muerto = false;
    
    public void JuegoFin() {  Final = true; }
    public void Moriste() {  Final = true; Muerto = true; }
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if (!Final) 
        {
            Tiempo += Time.deltaTime;
            double pasos = Math.Round(Tiempo, 2);
            TextoTiempo.text = pasos.ToString();
        }
        else 
        {
            if (!Muerto)
            {
                Tiempo += Time.deltaTime;
                double pasos = Math.Round(Tiempo, 2);
                TextoFinal.text = "Felicidades, lo has terminado en " + pasos + " segundos";
            }

            Terrain.SetActive(false);
            Personaje.SetActive(false);
            Decoracion.SetActive(false);
            Panel.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
