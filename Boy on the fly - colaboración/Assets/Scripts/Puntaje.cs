using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public TextMeshProUGUI puntajeText;
    public TextMeshProUGUI bestPuntajeText;

    private int puntaje;

    void Start()
    {
        puntajeText.text = puntaje.ToString();
        bestPuntajeText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();   
    }
   
    public void UpdateBestScore()
    {
        if (puntaje > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", puntaje);
            bestPuntajeText.text = puntaje.ToString();
        }
    }

    public void UpdateScore()
    {
        puntaje++;
        puntajeText.text = puntaje.ToString();
        UpdateBestScore();
    }
}
