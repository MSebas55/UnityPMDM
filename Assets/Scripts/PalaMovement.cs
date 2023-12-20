using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PalaMovement : MonoBehaviour
{
    public float speed = 2;
    public KeyCode upKey, downKey;

    private Vector2 _direction;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
       _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _direction = Vector2.zero;

        if (Input.GetKey(upKey))
        {
            _direction = new Vector2(0, 1);
        }
        else if(Input.GetKey(downKey))
        {
            _direction = new Vector2(0, -1);
        }
    }

    void FixedUpdate()
    {
        _rb.velocity = _direction * speed;
    }
}
