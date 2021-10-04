using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // 충돌처리
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.CompareTo("Player") == 0)
        {
            DataManager.Instance.score += 1;
            SoundManager.Instance.PlaySound("Coin");

            int temp3 = DataManager.Instance.score % 100;
            


            if (DataManager.Instance.score > 0 && temp3 == 0)
            {


                    DataManager.Instance.speed += 1;

                

            }
            gameObject.SetActive(false);
        }
    }
}
