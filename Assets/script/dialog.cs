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
        contexts[0] = "안녕하세요.";
        contexts[1] = "사람입니다.";
        contexts[2] = "저는 캐나다에서 살고있습니다.";
        contexts[3] = "한국어 잘못해요.";
        contexts[4] = "돌아가고 싶어요.";
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
