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
        obj.name = "Amongus";
        
        Transform objTransform = obj.transform;
        
        // objTransform.parent : �θ� ������Ʈ
        // objTransfrom.root : �ֻ��� �θ� ������Ʈ

        // Debug.Log($"ĳ������ �ڽ� ������Ʈ �� : {objTransform.childCount}");
        //
        // Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTransform.GetChild(0).name}");
        //
        // Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTransform.GetChild(objTransform.childCount - 1).name}");
    }
    
    
}
