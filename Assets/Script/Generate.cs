/// <summary>
/// 点击水果下落
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    private bool hasItBeenGenerated = false;//定义是否已在游戏中生成物体
    private GameObject fruitInTheScene;//定义用来保存场景中未落下的水果
    private float time = 1;//计时

    // Update is called once per frame
    void Update()
    {

        //用作延迟生成物体
        if (time < 0.3f)
        {
            time += Time.deltaTime;
        }
        else
        {
            //判断场景中没有生成物体
            if (!hasItBeenGenerated)
            {
                GameObject i = this.GetComponent<FruitList>().RandomReturnOfFruits();//获取随机出来的水果
                fruitInTheScene = GameObject.Instantiate(i);//实例化物体

                this.GetComponent<SizeChange>().GettingBigger(fruitInTheScene);//使物体缓慢变大

                hasItBeenGenerated = !hasItBeenGenerated;//更改hasItBeenGenerated状态
            }

            //判断是否点击
            if (Input.GetMouseButton(0))
            {
                //// float mousePosition_x = Input.mousePosition.x;//获取点击位置(只需要x轴位置)//这样获取的不是世界坐标系 所以废弃

                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);//获取点击位置
                fruitInTheScene.transform.position = new Vector3(mousePosition.x, 8, 0);//更改水果在场景中的位置
            }

            //判断是否完成点击
            if (Input.GetMouseButtonUp(0))
            {
                fruitInTheScene.GetComponent<Rigidbody2D>().simulated = true;//让水果获得重力
                fruitInTheScene = null;//清除保存的水果
                hasItBeenGenerated = !hasItBeenGenerated;//更改hasItBeenGenerated状态

                time = 0;

            }
        }


    }

}
