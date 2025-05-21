using System;
using Unity.VisualScripting;
using UnityEngine;

public class Study_Component : MonoBehaviour
{
    public GameObject obj;

    public string changeString;

    private void Start()
    {
        // Find the GameObject named "Main Camera"
        // 괄호 안의 이름이 같은 게임 오브젝트를 찾아서
        // obj에 할당
        obj = GameObject.Find("Main Camera");
        
        obj.name = changeString;
    }

    void MakeCube()
    {
        this.AddComponent<MeshFilter>().mesh = obj.GetComponent<MeshFilter>().mesh;
        this.AddComponent<MeshRenderer>().material = obj.GetComponent<MeshRenderer>().material;
        this.AddComponent<BoxCollider>();
        
        this.name = "Cube";
        obj.name = "바보";
    }
}