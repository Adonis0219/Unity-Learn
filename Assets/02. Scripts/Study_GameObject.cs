using System;
using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;
    
    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;
    
    private void Start()
    {
        Debug.Log("�����Ǿ����ϴ�.");
        CreateAmongus();
    }

    void CreateAmongus()
    {
        // ���ӿ�����Ʈ �����ϴ� ���
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.AddComponent<DestroyEvent>();
        obj.name = "Amongus";
        
        destroyObj = obj;
    }
    
    
}
