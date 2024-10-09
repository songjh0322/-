using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject talkPanel;
    public Text Talktext;
    public GameObject scanObjct;
    public bool isAction; //상태 저장용 변수 추가
    public void Action(GameObject scanObj)
    {
        if (isAction)
        { //Exit Action
            isAction = false;
        }
        else
        { //Enter Action
            isAction = true;
            scanObjct = scanObj;
            Talktext.text = "이것의 이름은 " + scanObj.name + "이라고 한다.";
        }
        talkPanel.SetActive(isAction);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
