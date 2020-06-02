using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using uOSC;
using System;
using System.Reflection;

public class PortChange : MonoBehaviour
{
    public InputField inputField;
    int AddressNumber = 0;
    int PortNumber = 39541;
    public Text text;
    uOscClient uClient;

    void Start()
    {
        uClient = this.GetComponent<uOSC.uOscClient>();
    }
    public void SetPortNumber()
    {
        //���̓t�H�[�����f�[�^�擾�Aint�^�ɕϊ��A�\��
        inputField = inputField.GetComponent<InputField>();
        PortNumber = Int32.Parse(inputField.text);
        GameObject.Find("PortText").GetComponent<Text>().text = "���M�|�[�g�ԍ��F" + inputField.text;

        uClient.enabled = false;
        var type = typeof(uOSC.uOscClient);
        var portfield = type.GetField("port", BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Instance);
        portfield.SetValue(uClient, PortNumber);
        uClient.enabled = true;
        //this.GetComponent<uOscClient>().OnEnable();
        //this.targetText.text = "���M�|�[�g�ԍ��F" + PortNumber;
    }
}