using UnityEngine;

public class Mateo : MonoBehaviour
{

    public float velocity = 2;
    public Rigidbody2D rb2D;


    public float rotationSpeed = 25;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.linearVelocity = Vector2.up * velocity;
        }

        transform.rotation = Quaternion.Euler(0, 0, rb2D.linearVelocity.y * rotationSpeed * Time.deltaTime * 5);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        FindAnyObjectByType<GameManager>().GameOver();
    }
}
