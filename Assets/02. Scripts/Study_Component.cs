using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Study_Component : MonoBehaviour
{
    // 멤버 변수 (필드)
    public GameObject obj;

    // 멤버 변수 (필드)
    public string changeName;

    public Mesh mesh;
    public Material material;
    
    // Start is called before the first frame update
    void Start()
    {

    }
    
    private void Update()
    {
        
    }

    void CreateCube()
    {
        obj = new GameObject("Cube");
        
        obj.AddComponent<MeshFilter>().mesh = mesh;
        obj.AddComponent<MeshRenderer>().material = material;
        obj.AddComponent<BoxCollider>();
    }

    void LogObjInfo()
    {
        obj = GameObject.FindGameObjectWithTag("Player");

        Debug.Log($"이름 : {obj.name}");
        Debug.Log($"태그 : {obj.tag}");
        Debug.Log($"위치 : {obj.transform.position}");
        Debug.Log($"회전 : {obj.transform.eulerAngles}");
        Debug.Log($"크기 : {obj.transform.localScale}");

        Debug.Log($"메쉬 : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"재질 : {obj.GetComponent<MeshRenderer>().material}");
        
        obj.GetComponent<MeshRenderer>().enabled = false;
    }

    void FindMainCam()
    {
        // Find the GameObject named "Main Camera"
        // 괄호 안의 이름이 같은 게임 오브젝트를 찾아서
        // obj에 할당
        obj = GameObject.Find("Main Camera");
        
        obj.name = changeName;
    }
    
    void MakeCube()
    {
        this.AddComponent<MeshFilter>().mesh = obj.GetComponent<MeshFilter>().mesh;
        this.AddComponent<MeshRenderer>().material = obj.GetComponent<MeshRenderer>().material;
        this.AddComponent<BoxCollider>();
        
        this.name = "Cube";
    }
}