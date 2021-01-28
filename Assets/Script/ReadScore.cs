/// <summary>
/// 跨脚本读取分数
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadScore : MonoBehaviour
{

    private float score;
    public Text sc;

    // Use this for initialization
    void Start()
    {
        score = PlayerPrefs.GetFloat("score");//读取分数
        sc.text = score.ToString() + "分";
    }


}
