using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    
    private void Update()
    {
        // // 부드럽게 증가하는 값
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");
        
        // 딱 떨어지는 값
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        Vector3 dir = new Vector3(h, 0f, v).normalized;

        transform.position += moveSpeed * Time.deltaTime * dir;
        
        transform.LookAt(transform.position + dir);
    }
}   
    
