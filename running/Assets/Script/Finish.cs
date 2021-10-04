using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag.CompareTo("Player") == 0)
       {
                SoundManager.Instance.StopSound("Bg");
                DataManager.Instance.Finish = true;

       }
    }
}
