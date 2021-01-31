/// <summary>
/// 胜利
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{

    public GameObject victoryAnimation;//胜利动画

    // Use this for initialization
    void Start()
    {
        GameObject.Find("CodeControl").GetComponent<VoiceControl>().PlayVictory();//播放胜利声音
        GameObject.Instantiate(victoryAnimation);
    }


}
