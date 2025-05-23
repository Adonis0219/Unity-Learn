using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    
    private void Update()
    {
        // // �ε巴�� �����ϴ� ��
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");
        
        // �� �������� ��
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        Vector3 dir = new Vector3(h, 0f, v).normalized;

        transform.position += moveSpeed * Time.deltaTime * dir;
        
        transform.LookAt(transform.position + dir);
    }
}   
    
