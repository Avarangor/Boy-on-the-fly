using System.Security.Principal;
using UnityEngine;

public class generar : MonoBehaviour
{
    public GameObject edificioPrefab;
    public float heightRange = 1f;
    public float maxTime = 1.75f;
    private float timer;
    void Start()
    {
        generador();
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > maxTime)
        {
            generador();
            timer = 0; 
        }
    }

    public void generador()
    {
        Vector3 generadorPosition = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject newEdificio;
        newEdificio = Instantiate(edificioPrefab, generadorPosition, Quaternion.identity);
        Destroy(newEdificio, 15f); 
    }
}
