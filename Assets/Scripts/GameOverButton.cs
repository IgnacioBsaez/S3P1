using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverButton : MonoBehaviour
{
    public GameManager manager;
    private void OnMouseDown()
    {
        GameManager.manager.felicidad++;
        GameManager.manager.ChequearSiGano();
    }

}
