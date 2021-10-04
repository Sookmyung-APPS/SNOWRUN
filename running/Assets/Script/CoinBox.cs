using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0)
        {
            DataManager.Instance.score += 10;
            SoundManager.Instance.PlaySound("Coin");


            gameObject.SetActive(false);
        }
    }
}
