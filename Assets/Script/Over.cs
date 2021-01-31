/// <summary>
/// 用于碰到线时游戏结束
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over : MonoBehaviour
{
    public float t = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        t = 0;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        t += Time.deltaTime;
        if (other.transform.tag != "Air")
        {
            if (t >= 2.0f)
            {
                GameObject.Find("CodeControl").GetComponent<ScoreControl>().SaveScore();//保存分数
                SceneManager.LoadScene("Over");//切换场景
            }
        }
    }

}
