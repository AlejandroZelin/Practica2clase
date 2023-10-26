using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class movimiento : MonoBehaviour
{
    Rigidbody fisicas;
    AudioSource audio;
    ParticleSystem particle;
    public float movX, movZ;
    public float speed = 10;
    public bool estaSuelo = false;
    public bool quieroSaltar = false;
    private int puntuacion;
    public TMP_Text puntuacionText;
    GameManager gameManager;
    public bool dobleSalto = false;
    void Start()
    {
        fisicas = GetComponent<Rigidbody>();
        particle = GetComponent<ParticleSystem>();
        audio = GameObject.Find("SonidoRecoger").GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        puntuacion = 0;
    }

    
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        if (quieroSaltar)
        {
            fisicas.AddForce(Vector3.up * 10, ForceMode.Impulse);
            quieroSaltar = false;
        }
        else
        {
            if (!dobleSalto && Input.GetButtonDown("Jump"))
            {
                dobleSalto = true;
                quieroSaltar = true;
            }
        }
        
        if (puntuacion == 4)
        {
            gameManager.JuegoFin();
        }
    }

    private void FixedUpdate()
    {
        Vector3 nuevaVelocidad = new Vector3(movX * speed, fisicas.velocity.y, movZ * speed);
        fisicas.velocity = nuevaVelocidad;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terreno"))
        {
            dobleSalto = false;

            if (Input.GetButtonDown("Jump"))
            {
                quieroSaltar = true;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coleccionable"))
        {
            particle.Play();
            audio.Play();
            puntuacion++;
            puntuacionText.text = puntuacion.ToString();
        }
    }
}
