using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            DataManager.Instance.score += 1;
            SoundManager.Instance.PlaySound("Coin");
            DataManager.Instance.speed += 1;

            gameObject.SetActive(false);
        }
    }
}
