using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class srpt_PlayerMovement : MonoBehaviour
{
    public float Horizontal;
    public float Vertical;
    public float Speed;
    public float RotationSpeed;
    void Start()
    {

    }

    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * Vertical * Speed * Time.deltaTime;
        transform.Rotate(Vector3.up, Horizontal * RotationSpeed * Time.deltaTime);
    }
    }

