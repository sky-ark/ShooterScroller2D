using System;
using UnityEngine;

public class GroundStatus: MonoBehaviour
{
    private CharacterController2D _controller;

    private void Awake()
    {
        _controller = GameObject.Find("Player").GetComponent<CharacterController2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        /* if (other.gameObject.layer == LayerMask.NameToLayer("Walkable"))
        {
            Debug.LogWarning("Grounded: true");
            _controller.Grounded = true;
        } */
        
        Debug.LogWarning("Grounded: true");
        _controller.Grounded = true;
    }
}