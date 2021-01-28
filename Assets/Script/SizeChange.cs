/// <summary>
/// 使物体增大或缩小
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour
{

    /// <summary>
    /// 控制物体增大
    /// </summary>
    /// <param name="obj">需要变大的物体</param>
    public void GettingBigger(GameObject obj)
    {
        float t = obj.transform.localScale.x;
        obj.transform.localScale = new Vector3(0, 0, 0);
        StartCoroutine(SlowlyGettingBigger(obj, t));//调用携程函数
    }

    IEnumerator SlowlyGettingBigger(GameObject obj, float t)
    {
        for (; obj.transform.localScale.x <= t;)
        {
            obj.transform.localScale = new Vector3(obj.transform.localScale.x + 0.01f, obj.transform.localScale.y + 0.01f);//每循环一次增大0.1
            yield return new WaitForSeconds(0.01f);
        }

    }

    /// <summary>
    /// 控制物体缩小后清除自身
    /// </summary>
    /// <param name="obj">需要缩小的物体</param>
    public void ShrinkingObjects(GameObject obj)
    {
        // Destroy(obj.GetComponent<Rigidbody2D>());//删除物体上的刚体组件
        Destroy(obj.GetComponent<CollisionDetection>());//删除物体上的CollisionDetection函数
        Destroy(obj.GetComponent<CircleCollider2D>());//删除物体上的碰撞体组件
        StartCoroutine(SlowlyShrinking(obj));//调用携程函数
    }

    IEnumerator SlowlyShrinking(GameObject obj)
    {

        for (; obj.transform.localScale.x > 0;)
        {
            obj.transform.localScale = new Vector3(obj.transform.localScale.x - 0.01f, obj.transform.localScale.y - 0.01f);//每循环一次增大0.1
            yield return new WaitForSeconds(0.005f);
        }
        Destroy(obj);


    }

}
