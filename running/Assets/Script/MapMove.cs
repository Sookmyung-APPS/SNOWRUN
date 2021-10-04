using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{

    private void Update()
    {


        if (DataManager.Instance.PlayerDie == false && DataManager.Instance.Finish == false) 
        {
       
            transform.Translate(-DataManager.Instance.speed * Time.deltaTime, 0, 0);

        }
        else
        {
            transform.Translate(0, 0, 0);
        }
    }

}
