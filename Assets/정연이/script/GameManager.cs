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
    private GameObject early_obstacles;
    [SerializeField]
    private GameObject finall_ui;
    [SerializeField]
    private GameObject finall_obj;
    [SerializeField]
    private GameObject main_ui;
    [SerializeField]
    private GameObject ghost_1;
    [SerializeField]
    private GameObject ghost_2;
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
        }
        else
        {
            if (GM != this)
                Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        re_Time(max_Time);
    }

    private void Update()
    {
        if(sec <= 0)
        {
            if(min == 0)
            {
                GameOver();
            }
            else
            {
                min -= 1;
                sec = 59;
            }
        }
        sec -= Time.deltaTime;
        Timer_text.text = string.Format("{0:D1}:{1:D2}", min, (int)sec);

        key_count_text.text = key_item_count + " / 5";

        itemchker();

    }

    public void GameOver()
    {
        gameover_screen.SetActive(true);
    }
    public void Key_Item_Acquisition()
    {
        key_item_count += 1;
    }

    void final()
    {
        re_Time(20f);
        main_ui.SetActive(false);
        finall_ui.SetActive(true);
        finall_obj.SetActive(true);

    }

    void re_Time(float re_time_index)
    {
        if (re_time_index < 60)
        {
            min = 0;
            sec = re_time_index;
        }
        else
        {
            min = (int)re_time_index / 60;
            sec = re_time_index - (60*min);
        }
    }

    void itemchker()
    {
        switch (key_item_count)
        {
            case 1:
                {
                    Destroy(early_obstacles);
                }
                break;
            case 2:
                {
                    ghost_1.SetActive(true);
                }
                break;
            case 4:
                {
                    ghost_2.SetActive(true);
                }
                break;
            case 5:
                {
                    final();
                }
                break;
        }
    }
}
