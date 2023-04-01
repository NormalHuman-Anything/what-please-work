using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class
{
    public int age;
    public float height;

    public void Print()
    {
        Debug.Log("age = " + age);
        Debug.Log("height = " + height);
    }
}

public class Class2 : Class
{
    public string name;
    public void Print2()
    {
        Print();
        Debug.Log("내 이름은 = " + name);
    }
}
