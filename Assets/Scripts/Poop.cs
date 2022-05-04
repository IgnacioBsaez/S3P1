using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour
{
    public void DesactivarObjeto()
    {
        GameManager.manager.score += 5;
        GameManager.manager.MostrarScore();
        gameObject.SetActive(false);
    }
}
