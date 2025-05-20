using Unity.VisualScripting;
using UnityEngine;

public class Carculator : MonoBehaviour
{
    public int num1;
    public int num2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           Debug.Log(AddMethod(num1, num2));
        }    
        if (Input.GetKeyDown(KeyCode.S))
        {
           Debug.Log(MinusMethod(num1, num2));
        }    
    }

    int AddMethod(int _num1, int _num2)
    {
        return _num1 + _num2;   
    }

    int MinusMethod(int _num1, int _num2)
    {
        return _num1 - _num2;  
    }
}
