﻿using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]
public class RelativeMovement : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    public float moveSpeed = 6.0f;
    public float rotSpeed = 5.0f;
    private CharacterController _charController;
    private Animator _animator;

    void Start()
    {
       _charController = GetComponent<CharacterController>();
       _animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 movement = Vector3.zero;

        float horInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        if (horInput != 0 || vertInput != 0)
        {
            movement.x = horInput * moveSpeed;
            movement.z = vertInput * moveSpeed;
            movement = Vector3.ClampMagnitude(movement, moveSpeed);

            Quaternion tmp = target.rotation;
            target.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);
            movement = target.TransformDirection(movement);
            target.rotation = tmp;

            Quaternion direction = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Lerp(transform.rotation, direction, rotSpeed * Time.deltaTime);
        }

      //  _animator.SetFloat("Speed", movement.sqrMagnitude);


        


        movement *= Time.deltaTime;
        _charController.Move(movement);
    }
}