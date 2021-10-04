using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public float speed;
    public Transform[] backgrounds;

    float leftPosX = 0f;
    float rightPosX = 0f;
    float xScreenHalfSixe;
    float yScreenHalfSize;


    void Start()
    {
        yScreenHalfSize = Camera.main.orthographicSize;
        xScreenHalfSixe = yScreenHalfSize * Camera.main.aspect;

        leftPosX = -(xScreenHalfSixe * 3);
        rightPosX = xScreenHalfSixe * 2 * backgrounds.Length;
    }

    void Update()
    {
        for(int i=0; i < backgrounds.Length; i++)
        {
            if (DataManager.Instance.PlayerDie == false && DataManager.Instance.Finish == false)
            {
                backgrounds[i].position += new Vector3(-DataManager.Instance.speed, 0, 0)* Time.deltaTime;

                if (backgrounds[i].position.x < leftPosX)
                {
                    Vector3 nextPos = backgrounds[i].position;
                    nextPos = new Vector3(nextPos.x + rightPosX, nextPos.y, nextPos.z);
                    backgrounds[i].position = nextPos;
                }
            }
            else
            {
                backgrounds[i].position += new Vector3(0, 0, 0) * Time.deltaTime;
            }

        }
        

    }
   
}