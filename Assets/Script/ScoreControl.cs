/// <summary>
/// 保存和控制分数显示
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{

    private int score = 0;//定义分数
    public Text scoreDisplay;//定义分数显示UI

    /// <summary>
    /// 分数增加函数
    /// </summary>
    /// <param name="i">要增加的分数</param>
    public void ScoreIncrease(int i)
    {
        score += i;//分数增加
        ScoreDisplay();
    }

    /// <summary>
    /// 显示分数
    /// </summary>
    public void ScoreDisplay()
    {
        scoreDisplay.text = score.ToString() + "分";
    }

}
