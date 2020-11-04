using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    float speed = 2f;
    public GameObject ball;
    void Awake()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }
    void Update()
    {
        
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            
            Vector3 newPos=ball.transform.position;
            if (touchPos.x >= ball.transform.position.x-0.3f && touchPos.x<=ball.transform.position.x+0.3f)
            {
                newPos.y += speed;
            }
            else
            {
                if (touchPos.x < 0)
                {
                    newPos.x -= speed * Time.deltaTime;
                }
                if (touchPos.x > 0)
                {
                    newPos.x += speed * Time.deltaTime;
                }
            }
           
            ball.transform.position = Vector3.Lerp(ball.transform.position, newPos, 1f);
            
        }
    }
}
