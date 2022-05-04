using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSelfDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    public float tiempo, timeScale;
    public GameObject gm;

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        timeScale = Time.timeScale;

        if (tiempo > 10)
        {
            Destroy(gm);
        }

    }
}
