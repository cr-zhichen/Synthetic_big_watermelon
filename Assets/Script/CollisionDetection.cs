using System;
/// <summary>
/// 小球的碰撞与合成
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private GameObject[] fruitList;//生成水果列表
    private bool isItDetected = true;//定义是否进行碰撞检测后逻辑判断

    // Use this for initialization
    void Start()
    {
        fruitList = GameObject.Find("CodeControl").GetComponent<FruitList>().fruitList;//跨脚本获取水果列表
    }


    void OnCollisionEnter2D(Collision2D other)//碰撞检测
    {
        if (isItDetected == true)//判断是否应该检测
        {
            if (other.transform.tag == this.tag)//判断碰撞物体的tag是否与自身一致
            {
                other.transform.GetComponent<CollisionDetection>().IgnoreDetection();//停止对方检测
                Transform v2 = other.transform;//保存被碰撞物体的位置
                string _tag = other.transform.tag;//获取被碰撞物体的Tag

                //判断是否超出最大水果限制
                if (Convert.ToInt32(_tag) < fruitList.Length)
                {
                    //在被碰撞的物体原有的位置上生成新物体
                    GameObject i = GameObject.Instantiate(fruitList[Convert.ToInt32(_tag)]);//! 由于物品Tag命名都为顺序数字 所以采用该办法
                    i.transform.position = v2.position;

                    i.GetComponent<Rigidbody2D>().simulated = true;//让水果获得重力

                    //TODO 增加分数

                    Destroy(this.gameObject);//清除自身
                    Destroy(other.gameObject);//清除自身
                }
                //当超出最大水果限制 游戏结束
                else
                {
                    //TODO 游戏结束
                }

            }
        }
    }

    /// <summary>
    /// 用来忽略检测
    /// </summary>
    public void IgnoreDetection()//用于忽略检测
    {
        isItDetected = false;//不进行检测
    }

}
