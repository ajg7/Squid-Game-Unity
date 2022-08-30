using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController playerController;
    [SerializeField] float playerSpeed = 5.0f;

    private void Start()
    {
        
        playerController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Movement(horizontal, vertical);
    }

    void Movement(float horizontal, float vertical)
    {
        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical);
        float speed = Mathf.Clamp01(moveDirection.magnitude) * playerSpeed;
        moveDirection.Normalize();
        playerController.SimpleMove(moveDirection * speed);
    }
   
}
