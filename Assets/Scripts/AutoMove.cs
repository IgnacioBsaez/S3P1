using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float standarSpeed;
    private bool mustPatrol;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mustPatrol)
        {
            patrol();
        }
        
    }

    void patrol()
    {
        rb.velocity = new Vector2(standarSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }
}
