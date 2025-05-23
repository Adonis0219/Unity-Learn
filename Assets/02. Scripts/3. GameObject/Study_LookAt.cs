using UnityEngine;
using UnityEngine.Serialization;

public class Study_LookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab;
    public Transform firePos;

    private float t;

    public float atkSpeed = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()    // 1�� ���� -> ����
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()   // ���𰡸� ���������� �ٶ� ��
    {
        turretHead.LookAt(targetTf);

        t += Time.deltaTime;

        if (t > atkSpeed)
        {
            t = 0;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
