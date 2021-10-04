using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float jump = 4f; //ù��° ���� ��
    public float jump2 = 10f; //�ι�° ���� ��

    int jumpCount = 0;
    // ��ư�� ���� �Լ�

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
    //�ٴڰ� �浹��(���� �� �����ϸ�) ����
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
