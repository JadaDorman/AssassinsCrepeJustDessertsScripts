using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    [SerializeField] private Text uiText;
    // Timer is in Seconds
    [SerializeField] private float mainTimer;
    //public GameObject UIFail;
    public GameObject UITimer;
    //public GameObject UISuccess;
    public static float timer;
    private bool canCount = false;
    private bool strt = false;
    public static bool doOnce = false;
    public static bool fail = false;

    void Start()
    {
        if (strt == true)
        {
            timer = mainTimer;
        }
    }

    void Update()
    {
        if (timer > 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            string minutes = Mathf.Floor(timer / 60).ToString("0");
            string seconds = (timer % 60).ToString("00");

            uiText.text = string.Format("{0}:{1}", minutes, seconds);
        }

        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0:00";
            timer = 0.0f;
            GameOver();
        }
    }

    public void ResetBtn()
    {
        timer = mainTimer;
        canCount = true;
        doOnce = false;
        strt = true;
        fail = false;
    }

    void GameOver()
    {

        if (strt)
        {
           
            fail = true;
           
           
        }
       /* if (strt == true)
        {
            if (UISuccess.activeSelf == false)
            {
                UIFail.SetActive(true);
            }
            //UITimer.SetActive(false);
            strt = false;

        } */
    }
}
