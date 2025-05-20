using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// 클래스와 구조체를 비교하기 위한 클래스
/// </summary>
public class Study_ClassStruct : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("클래스--------------------------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($"c1 : {c1.number}  / c2 : {c2.number}"); // 10 10

        c1.number = 100;
        Debug.Log($"c1 : {c1.number}  / c2 : {c2.number}"); // 100 100
        
        Debug.Log("구조체--------------------------------------");
        Study_Struct s1 = new Study_Struct(20);
        Study_Struct s2 = s1;
        Debug.Log($"s1 : {s1.number}  / s2 : {s2.number}"); // 20 20

        s1.number = 200;
        Debug.Log($"s1 : {s1.number}  / s2 : {s2.number}"); // 200 20
    }
}

public class Study_Class
{
    public int number;
    
    // 생성자
    public Study_Class(int _number)
    {
        this.number = _number;
    }
}

public struct Study_Struct
{
    public int number;
    
    // 생성자
    public Study_Struct(int _number)
    {
        this.number = _number;
    }
}