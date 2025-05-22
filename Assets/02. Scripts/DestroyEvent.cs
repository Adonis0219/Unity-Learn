using System;
using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    private void OnDestroy()
    {
        Debug.Log($"{gameObject.name}이 파괴되었습니다");
    }
}
