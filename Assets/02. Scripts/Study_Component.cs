using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Study_Component : MonoBehaviour
{
    // ��� ���� (�ʵ�)
    public GameObject obj;

    // ��� ���� (�ʵ�)
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

        Debug.Log($"�̸� : {obj.name}");
        Debug.Log($"�±� : {obj.tag}");
        Debug.Log($"��ġ : {obj.transform.position}");
        Debug.Log($"ȸ�� : {obj.transform.eulerAngles}");
        Debug.Log($"ũ�� : {obj.transform.localScale}");

        Debug.Log($"�޽� : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"���� : {obj.GetComponent<MeshRenderer>().material}");
        
        obj.GetComponent<MeshRenderer>().enabled = false;
    }

    void FindMainCam()
    {
        // Find the GameObject named "Main Camera"
        // ��ȣ ���� �̸��� ���� ���� ������Ʈ�� ã�Ƽ�
        // obj�� �Ҵ�
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