/// <summary>
/// 空气墙生成
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirWall : MonoBehaviour
{

    public GameObject airWall;
    private GameObject _airWall;
    private GameObject _airWall2;

    Vector2 worldPosLeftBottom;
    Vector2 worldPosTopRight;

    void Start()
    {
        worldPosLeftBottom = Camera.main.ViewportToWorldPoint(Vector2.zero);
        worldPosTopRight = Camera.main.ViewportToWorldPoint(Vector2.one);

        Debug.Log(worldPosLeftBottom.x);

        _airWall = GameObject.Instantiate(airWall);
        _airWall2 = GameObject.Instantiate(airWall);

    }

    private void Update()
    {
        _airWall.transform.position = new Vector3(worldPosLeftBottom.x - 5, 0, 0);
        _airWall2.transform.position = new Vector3(worldPosTopRight.x + 5, 0, 0);

    }




    // }

}
