using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �迭�� ����Ʈ�� ���Ͽ� ����غ��� ���� Ŭ����
/// </summary>
public class Study_Array : MonoBehaviour
{
    public int[] arrayNum = new int[5] { 1, 2, 3, 4, 5};

    public List<int> listNum = new List<int>();

    private void Start()
    {
        listNum.Add(1);
        listNum.Add(2);
        listNum.Add(3);
        listNum.Add(4);
        listNum.Add(5);

        Debug.Log($"���� ����Ʈ�� �ִ� ������ �� : {listNum.Count}");
        Debug.Log($"���� ����Ʈ�� ������ ������ : {listNum[listNum.Count - 1]}");
    }
}

 