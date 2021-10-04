using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject EndPanel;
    public GameObject Finish;
    public GameObject Dead;
    public GameObject Dead1;
    public GameObject[] NumberImage;
    public Sprite[] Number;

    public Text timeTimer;

    private void Start()
    {
    }
    private void Update()
    {
        
        if (!DataManager.Instance.PlayerDie)
        {
            //점수 띄우기
            //100단위
            int temp = DataManager.Instance.score / 100;
            NumberImage[0].GetComponent<Image>().sprite = Number[temp];
            //10단위
            int temp2 = DataManager.Instance.score % 100;
            //0~9
            temp2 = temp2 / 10;
            NumberImage[1].GetComponent<Image>().sprite = Number[temp2];
            //1의단위
            int temp3 = DataManager.Instance.score % 10;
            NumberImage[2].GetComponent<Image>().sprite = Number[temp3];

        }
        
        if(DataManager.Instance.PlayerDie == true)
        {
            SoundManager.Instance.StopSound("Bg");
            EndPanel.SetActive(true);
        }

        if(DataManager.Instance.Finish == true)
        {
            SoundManager.Instance.StopSound("Bg");
            Dead.SetActive(false);
            Dead.SetActive(false);
            Finish.SetActive(true);
        }

    }

    public void Restart_Btn()
    {
        DataManager.Instance.score = 0;
        DataManager.Instance.speed = 4;
        DataManager.Instance.PlayerDie = false;

        SoundManager.Instance.PlaySound("Bg");

        SceneManager.LoadScene("SampleScene");

    }

    public void Again_Btn()
    {
        DataManager.Instance.score = 0;
        DataManager.Instance.speed = 4;
        DataManager.Instance.PlayerDie = false;
        DataManager.Instance.Finish = false;

        SoundManager.Instance.PlaySound("Bg");

        SceneManager.LoadScene("SampleScene");
        Finish.SetActive(false);

    }
 
}
