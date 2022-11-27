using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    private Transform PlayerTransform;
    public Vector3 offset;
    public float smoothTime = 0.3f;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
         Vector3 temp = transform.position;
     temp.x = PlayerTransform.position.x + 2.5f;
      transform.position = temp;
        transform.position = Vector3.SmoothDamp(transform.position, temp , ref velocity, smoothTime);
    }
}
