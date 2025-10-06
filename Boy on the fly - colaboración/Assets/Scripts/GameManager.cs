using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverCanvas;
    void Start()
    {
        Time.timeScale = 1; 
    }

    void Update()
    {

    }

    public void GameOver()
    {
        gameoverCanvas.SetActive(true);
        Time.timeScale = 0; 
    }

    public void reinicair()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene(). buildIndex); 

    }
}
