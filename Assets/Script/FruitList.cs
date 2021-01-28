﻿/// <summary>
/// 用来保存水果列表与随机生成水果
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FruitList : MonoBehaviour
{

    public GameObject[] fruitList;//生成水果列表

    //随机获取水果
    public GameObject RandomReturnOfFruits()
    {
        System.Random rd = new System.Random();
        if (fruitList.Length >= 5)//判断总水果是否大于5个
        {
            int randomNumber = rd.Next(0, 5);
            GameObject i = fruitList[randomNumber];
            return i;
        }
        else
        {
            int randomNumber = rd.Next(0, fruitList.Length);
            GameObject i = fruitList[randomNumber];
            return i;
        }
    }


}
