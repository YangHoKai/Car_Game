using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        score = GameObject.Find("Score");


    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        distance.GetComponent<Text>().text = "距離目標還有 " + length.ToString("F2") + "m";
        float allscore = 100 / length;
        if (length >= 0)
        {
            score.GetComponent<Text>().text = "分數 " + allscore.ToString("F0") + " 分";
        }
        else
        {
            score.GetComponent<Text>().text = "分數 0 分";
        }

    }
}
