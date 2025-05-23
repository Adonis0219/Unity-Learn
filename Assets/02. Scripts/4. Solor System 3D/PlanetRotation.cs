using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    
    // ���� �ӵ�
    public float rotSpeed = 10f;
    // ���� �ӵ�
    public float revSpeed = 10f;
    
    public bool isRev = false;
    
    void Update()
    {
        // ������ �ϴ� ���
        transform.Rotate(rotSpeed * Time.deltaTime * Vector3.up);
        
        if (isRev) 
        // ������ �ϴ� ���
            transform.RotateAround(targetPlanet.position, Vector3.up, revSpeed * Time.deltaTime);
    }
}