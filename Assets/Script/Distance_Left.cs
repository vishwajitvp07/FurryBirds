using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Distance_Left : MonoBehaviour
{
    public Transform plane;
    public Text distanceLeft;
    public int dis;



    void Update()
    {

        if (plane.position.x > 0)
        {
            distanceLeft.text = "" + (dis - plane.position.x).ToString("0");
        }
        if (plane.position.x >= dis - 10)
        {
            Destroy(distanceLeft);
        }
    }
}
