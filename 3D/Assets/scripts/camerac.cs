using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerac : MonoBehaviour
{
    public Transform player;

    // ����ֵ�Ͳ������
    public Light flashlight;
    public Light flashlight2;


    // ��ҽű�����
    public Player playerScript;

    private void Start()
    {
        // Ĭ�Ϲر��ֵ�Ͳ
        if (flashlight != null)
        {
            flashlight.enabled = false;

        }
        if (flashlight2 != null)
        {
            flashlight2.enabled = false;
        }
    }

    private void Update()
    {
               // ����Ƿ���F��
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlashlight();
        }
        
    }
    // �л��ֵ�Ͳ���صĹ���
    private void ToggleFlashlight()
    {
        if (flashlight != null)
        {
            flashlight.enabled = !flashlight.enabled;
        }
        if (flashlight2 != null)
        {
            flashlight2.enabled = !flashlight2.enabled;
        }
    }
}