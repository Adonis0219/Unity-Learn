using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 배열과 리스트를 비교하여 출력해보기 위한 클래스
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

        Debug.Log($"현재 리스트에 있는 데이터 수 : {listNum.Count}");
        Debug.Log($"현재 리스트의 마지막 데이터 : {listNum[listNum.Count - 1]}");
    }
}

 