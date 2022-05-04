using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;
    public int score;
    public float tiempo;
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoTime;
    public TextMeshProUGUI textoWin;

    private void Awake()
    {
        manager = this;
    }
    public void MostrarScore()
    {
        textoScore.text = "score= " + score;

    }

    private void Update()
    {
        tiempo += Time.deltaTime;
        textoTime.text = "tiempo: " + (int)tiempo;
        if(score == 30)
        {
            YouWin();
        }
    }

    private void YouWin()
    {
        textoWin.IsActive();
    }

    private void GameOver()
    {

    }
}
