using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;
    public int felicidad;
    public int felicidadMaxima;

    private void Awake()
    {
        manager = this;
    }
    public void GameOver()
        {
            // boton game over
            print("GAME OVER");
        }

    public void WinGame() 
        {
        print("gano");
        }

    public void ResetGame() { }

    public void ChequearSiGano()
    {
        if(felicidad >= felicidadMaxima)
        {
            WinGame();
        }
    }


}
