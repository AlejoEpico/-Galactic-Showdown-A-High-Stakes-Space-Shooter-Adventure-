using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyIA : MonoBehaviour
{
    public int vida = 3;
    public int comportamiento = 1;   // 1 -> Perseguir    2 -> Patrullar
    GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.Find("Player");
        if (jugador == null)
        {
            Debug.LogError("No se pudo encontrar el objeto jugador.");
        }
        else
        {
            comportamiento = Random.Range(1, 3); //Al crearse el enemigo, puede salir con comportamiento 1, o 2, aleatoriamente
            InvokeRepeating("CambiarDireccion", 3, 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (comportamiento == 1) // perseguir
        {
            transform.LookAt(jugador.transform);
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = transform.forward * 2;
            }
        }
        else // patrullar
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = transform.forward;
            }
        }
    }

    void CambiarDireccion()
    {
        transform.Rotate(0, Random.Range(0, 360), 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider != null)
        {
            if (collision.collider.name == "Player")
            { 
                Debug.Log("It's a damage");
                FindObjectOfType<Player>().myDamage();
            }
            if (collision.collider.tag == "Bala")
            {
                Destroy(collision.collider.gameObject);
                vida = vida - 1;
                if (vida == 0)
                    Destroy(gameObject);
            }
        }
    }
}
