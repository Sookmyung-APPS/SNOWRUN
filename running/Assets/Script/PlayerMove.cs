using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float jump = 4f; //첫번째 점프 값
    public float jump2 = 10f; //두번째 점프 값

    int jumpCount = 0;
    // 버튼에 넣을 함수

    void Update()
    {
        if (!DataManager.Instance.PlayerDie) 
        { 

            if (Input.GetKeyDown(KeyCode.Space) && jumpCount == 0)
            {
                SoundManager.Instance.PlaySound("Jump");
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump, 0);
                jumpCount += 1;
            }
            else if (Input.GetKey(KeyCode.Space) && jumpCount == 1)
            {
                SoundManager.Instance.PlaySound("Jump");
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, jump2, 0);
                jumpCount += 1;
            }
        }
       


    }
    //바닥과 충돌시(점프 후 착지하면) 동작
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.CompareTo("Land") == 0)
        {
            jumpCount = 0;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Enemy") == 0)
        {
            DataManager.Instance.PlayerDie = true;


        }
    }

   
}
