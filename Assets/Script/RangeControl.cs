/// <summary>
/// 控制物体不超过边界
/// 此脚本已被AirWall脚本替代
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeControl : MonoBehaviour
{

    Vector2 worldPosLeftBottom;
    Vector2 worldPosTopRight;

    void Start()
    {
        worldPosLeftBottom = Camera.main.ViewportToWorldPoint(Vector2.zero);
        worldPosTopRight = Camera.main.ViewportToWorldPoint(Vector2.one);
    }

    private void Update()
    {
        LimitPosition(this.transform);

    }

    public void LimitPosition(Transform trNeedLimit)
    {
        trNeedLimit.position = new Vector3(Mathf.Clamp(trNeedLimit.position.x, worldPosLeftBottom.x + 0.3f, worldPosTopRight.x - 0.3f),
                                           Mathf.Clamp(trNeedLimit.position.y, worldPosLeftBottom.y, worldPosTopRight.y));



    }

}
