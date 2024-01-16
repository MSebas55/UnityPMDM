using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public KeyCode upkey;
    public float fuerza = 10;
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upkey))
        {
            rigidbody2D.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }
    }
}
