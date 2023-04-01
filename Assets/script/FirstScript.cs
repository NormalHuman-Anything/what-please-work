using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        int Level = 10;
        float HP = 24.5f;
        double MP = 56.1;
        bool is_next_level = false;

        if (is_next_level == true)
        {
            Debug.Log("다음 레벨로 넘어갑니다.");
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i + 1 + "번째 숫자");
        }

        //배열 리스트

        //배열 -> 자료형[] 배열이름 = new 자료형[배열 크기]

        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = (i + 1) * 10;
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log((i + 1) + "번쨰 숫자는 = " + arr[i]);
        }

        //리스트 - > 동적할당 (o)  ->  list<자료형> 리스트 이름 = new List<자료형>();
        List<int> list = new List<int>();
        list.Add(12);
        list.Add(56);
        list.Add(98);

        foreach (int i in list)
        {
            Debug.Log(i);
        }
        */

        Class2 people = new Class2();
        people.age = 10;
        people.height = 177.9f;
        people.name = "사람";
        people.Print2();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
