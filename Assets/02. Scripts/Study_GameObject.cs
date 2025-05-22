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
        Debug.Log("생성되었습니다.");
        CreateAmongus();
    }

    void CreateAmongus()
    {
        // 게임오브젝트 생성하는 기능
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.AddComponent<DestroyEvent>();
        obj.name = "Amongus";
        
        destroyObj = obj;
    }
    
    
}
