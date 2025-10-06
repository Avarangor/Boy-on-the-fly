using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Sumarpuntos : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindAnyObjectByType<Puntaje>().UpdateScore(); 
        }
        
    }
        
 }

