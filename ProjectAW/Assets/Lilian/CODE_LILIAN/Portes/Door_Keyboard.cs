using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Keyboard : MonoBehaviour
{
    public bool _key = false; // Indique si le joueur a la clé
    private bool joueurDansZone = false; // Vérifie si le joueur est dans la zone de la porte

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            joueurDansZone = true; // Le joueur est dans la zone
            Debug.Log("Appuie sur 'E' pour ouvrir la porte !");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            joueurDansZone = false; // Le joueur quitte la zone
        }
    }

    private void Update()
    {
        if (joueurDansZone && _key && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Porte ouverte !");
            Destroy(gameObject); // Détruit la porte
        }
    }
}
