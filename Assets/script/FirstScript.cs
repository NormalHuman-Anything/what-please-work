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
            Debug.Log("���� ������ �Ѿ�ϴ�.");
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i + 1 + "��° ����");
        }

        //�迭 ����Ʈ

        //�迭 -> �ڷ���[] �迭�̸� = new �ڷ���[�迭 ũ��]

        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = (i + 1) * 10;
        }

        for (int i = 0; i < 5; i++)
        {
            Debug.Log((i + 1) + "���� ���ڴ� = " + arr[i]);
        }

        //����Ʈ - > �����Ҵ� (o)  ->  list<�ڷ���> ����Ʈ �̸� = new List<�ڷ���>();
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
        people.name = "���";
        people.Print2();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
