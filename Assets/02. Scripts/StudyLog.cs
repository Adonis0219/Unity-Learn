using System.Collections;
using UnityEngine;

/// <summary>
/// 유니티 에디터에 있는 Console View에 로그를 출력하기 위한 테스트 클래스
/// </summary>
public class StudyLog : MonoBehaviour
{
    void Start()
    {
        Debug.Log("스타트");           // 일반적인 로그 출력
        Debug.LogWarning("스타트");    // 경고 로그 출력
        Debug.LogError("스타트");      // 에러 로그 출력
    }

    void Update()
    {
        Debug.Log("업데이트");
    }
}
