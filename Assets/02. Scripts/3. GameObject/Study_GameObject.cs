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
        obj.name = "Amongus";
        
        Transform objTransform = obj.transform;
        
        // objTransform.parent : 부모 오브젝트
        // objTransfrom.root : 최상위 부모 오브젝트

        // Debug.Log($"캐릭터의 자식 오브젝트 수 : {objTransform.childCount}");
        //
        // Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTransform.GetChild(0).name}");
        //
        // Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTransform.GetChild(objTransform.childCount - 1).name}");
    }
    
    
}
