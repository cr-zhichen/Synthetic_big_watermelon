/// <summary>
/// 场景切换
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{

    public void 开始游戏()
    {
        SceneManager.LoadScene("Game");
    }

    public void 返回菜单()
    {
        SceneManager.LoadScene("Index");
    }

}
