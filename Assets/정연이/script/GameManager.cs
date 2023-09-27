using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameover_screen;
    [SerializeField]
    private GameObject gameclear_screen;
    [SerializeField]
    private TextMeshProUGUI Timer_text;
    [SerializeField]
    private TextMeshProUGUI key_count_text;
    [SerializeField]
    private float max_Time=300;
    [SerializeField]
    private int key_item_count;

    int min;
     float sec;

    public static GameManager GM = null;
    void Awake()
    {
        if (GM == null)
        {
            GM = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (GM != this)
                Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        min = (int)max_Time / 60;
        sec = 00;
    }

    private void Update()
    {
        if(sec <= 0)
        {
            if(min == 0)
                GameOver();
            else
            {
                min -= 1;
                sec = 59;
            }
        }

        sec -= Time.deltaTime;
        Timer_text.text = string.Format("{0:D1}:{1:D2}", min, (int)sec);

        key_count_text.text = key_item_count + " / 5";


    }

    public void GameOver()
    {
        gameover_screen.SetActive(true);
    }
    public void Key_Item_Acquisition()
    {
        key_item_count += 1;
    }
    void GameClear()
    {
        gameclear_screen.SetActive(true);
    }
}
