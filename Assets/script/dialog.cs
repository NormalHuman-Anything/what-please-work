using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialog : MonoBehaviour
{
    [SerializeField] private GameObject Dialogues;

    [SerializeField] private Text context ;
    [SerializeField] private Text name ;
    [SerializeField] private float Delay;

    string[] contexts = new string[10];
    int contextIndex = 0;
    bool isNext = false;



    void Start()
    {
        contexts[0] = "�ȳ��ϼ���.";
        contexts[1] = "����Դϴ�.";
        contexts[2] = "���� ĳ���ٿ��� ����ֽ��ϴ�.";
        contexts[3] = "�ѱ��� �߸��ؿ�.";
        contexts[4] = "���ư��� �;��.";
        contexts[5] = "help me i like english.";
        contexts[6] = "i really wanna stay my house.";
        contexts[7] = "HELP            ME.";

    }

    IEnumerator StartConversation()
    {
        

        string str = contexts[contextIndex];

        for (int i = 0; i < str.Length; i++)
        {
            context.text += str[i];
            yield return new WaitForSeconds(Delay);
        }
    }

    void SettingUI(bool flag)
    {
        Dialogues.SetActive(flag);
    }

    void EndConversation()
    {
        SettingUI(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(StartConversation());
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
          if (++contextIndex < contexts.Length)
                {
                    isNext = true;
                }
                else
                {
                    EndConversation();
                    isNext = false;
                }
            }
        
    }
}
