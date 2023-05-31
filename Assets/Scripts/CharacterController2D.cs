using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;



public class CharacterController2D : MonoBehaviour
{
    public GameObject Player;

    private Rigidbody2D _rigidbody2D;

    private Vector3 _velocity;
    [SerializeField] private float _movementSmoothing = 0.3f; // Lissage du mouvement
    [SerializeField] private float _jumpForce = 400f; // Multiplicateur de force de saut
    [SerializeField] private LayerMask _whatIsGround; // LayerMask indicant c'est qu'est le sol pour le saut du joueur
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private bool _grounded;
    const float _groundedRadius = .2f; // Rayon pour déterminer si le joueur est grounded
    private bool _facingRight = true;
    public bool Grounded
    {
        get => _grounded;
        set => _grounded = value;
    }
    
    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    public BoolEvent OnCrouchEvent;
    private bool _wasCrouching = false;
    // Start is called before the first frame update

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();
        if (OnCrouchEvent == null)
            OnCrouchEvent = new BoolEvent();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool wasGrounded = _grounded;
        // _grounded = false;
        
        if(_grounded) OnLandEvent.Invoke();
        
        // Collider2D[] colliders = Physics2D.OverlapCircleAll(_groundCheck.position, _groundedRadius, _whatIsGround);
        /* for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                _grounded = true; 
                if(!wasGrounded) OnLandEvent.Invoke();
            }
        } */
        
        // float moveInput = Input.GetAxisRaw("Horizontal");
    }

    public void Move(float move, bool crouch, bool jump)

    {
        Vector3 targetVelocity = new Vector2(move * 10f, _rigidbody2D.velocity.y);
        _rigidbody2D.velocity =
            Vector3.SmoothDamp(_rigidbody2D.velocity, targetVelocity, ref _velocity, _movementSmoothing);
        if (move > 0 && !_facingRight)
        {
            Flip();
        }
        else if (move < 0 && _facingRight)
        {
            Flip();
        }
    if (_grounded && jump)
        {
            _grounded = false;
            _rigidbody2D.AddForce(new Vector2(0f, _jumpForce));
        }
    }

    private void Flip()
    {
        _facingRight = !_facingRight;
        Debug.Log("Flip" +_facingRight);
        transform.Rotate(0f, 180f, 0);
    }

}
