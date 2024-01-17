using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public KeyCode rightkey, leftkey, upkey;
    public float speed;
    public float fuerza = 10;
    private Rigidbody2D _rb;
    private Vector2 _dir;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _dir = Vector2.zero;
        if (Input.GetKey(leftkey)) 
        {
            _dir = new Vector2(- 1, 0);
            _spriteRenderer.flipX = true;

        } else if (Input.GetKey(rightkey))
        {
            _dir = new Vector2(1, 0);
            _spriteRenderer.flipX = false ;
        }
        if (Input.GetKeyDown(upkey))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 0);
            _rb.AddForce(Vector2.up * fuerza * _rb.gravityScale, ForceMode2D.Impulse);
        }
        //animations
        if (_dir != Vector2.zero)
        {
            _animator.SetBool("isWalking", true);
        } else
        {
            _animator.SetBool("isWalking", false);
        }

    }
    private void FixedUpdate()
    {
        Vector2 nVel = _dir * speed;
        nVel.y = _rb.velocity.y;
        _rb.velocity = nVel;
    }

}
