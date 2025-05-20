using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;

    private Vector3 moveVec;
    
    private void Update()
    {
        moveVec = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")).normalized;
        
        transform.position += moveSpeed * Time.deltaTime * moveVec;

        transform.LookAt(transform.position + moveVec);
    }
}   
    
