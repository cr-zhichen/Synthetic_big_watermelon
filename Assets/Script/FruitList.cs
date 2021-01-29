/// <summary>
/// 用来保存水果列表与随机生成水果
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitList : MonoBehaviour
{

    public GameObject[] fruitList;//生成水果列表

    //随机获取水果
    public GameObject RandomReturnOfFruits()
    {
        if (fruitList.Length >= 4)//判断总水果是否大于4个
        {
            int randomNumber = Random.Range(0, 4);
            GameObject i = fruitList[randomNumber];
            return i;
        }
        else
        {
            int randomNumber = Random.Range(0, fruitList.Length);
            GameObject i = fruitList[randomNumber];
            return i;
        }
    }


}
