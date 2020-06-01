using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using uOSC;
using System;

public class PortChange : MonoBehaviour
{
    public InputField inputField;
    int PortNumber = 39541;
    public Text text;

    public void SetPortNumber()
    {
        inputField = inputField.GetComponent<InputField>();
        PortNumber = Int32.Parse(inputField.text);
        //text = text.GetComponent<Text>();
        //Debug.Log("���ݒl�F" + inputField.text);
        GameObject.Find("PortText").GetComponent<Text>().text = "���M�|�[�g�ԍ��F" + inputField.text;
        this.GetComponent<uOscClient>().port = PortNumber;
        this.GetComponent<uOscClient>().OnDisable();
        this.GetComponent<SampleBonesSend>();
        //this.GetComponent<uOscClient>().OnEnable();
        //this.targetText.text = "���M�|�[�g�ԍ��F" + PortNumber;
    }
}