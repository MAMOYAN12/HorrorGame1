using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerac : MonoBehaviour
{
    public Transform player;

    // 添加手电筒的引用
    public Light flashlight;
    public Light flashlight2;


    // 玩家脚本引用
    public Player playerScript;

    private void Start()
    {
        // 默认关闭手电筒
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
               // 检测是否按下F键
        if (Input.GetKeyDown(KeyCode.F))
        {
            ToggleFlashlight();
        }
        
    }
    // 切换手电筒开关的功能
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