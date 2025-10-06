using UnityEngine;

public class Edificios : MonoBehaviour
{

    public float speed = 0.75f; 
        void Start()
    {
        
    }

        void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; 
    }
}
