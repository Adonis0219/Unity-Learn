using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    
    // 자전 속도
    public float rotSpeed = 10f;
    // 공전 속도
    public float revSpeed = 10f;
    
    public bool isRev = false;
    
    void Update()
    {
        // 자전을 하는 기능
        transform.Rotate(rotSpeed * Time.deltaTime * Vector3.up);
        
        if (isRev) 
        // 공전을 하는 기능
            transform.RotateAround(targetPlanet.position, Vector3.up, revSpeed * Time.deltaTime);
    }
}