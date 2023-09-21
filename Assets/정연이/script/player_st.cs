using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_st : MonoBehaviour
{
    [SerializeField]
    private int hp=3;
    [SerializeField]
    private int stamina = 100;
    [SerializeField]
    private int key_item_Count = 0;

    private static player_st player_St = null;

    void Awake()
    {
        if (null == player_St)
        {
            player_St = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static player_st Player_St
    {
        get
        {
            if (null == Player_St)
            {
                return null;
            }
            return Player_St;
        }
    }


    IEnumerator Damage(int damage,float wait_time)
    {
        yield return new WaitForSeconds(wait_time);
        hp -= damage;
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void Key_Item_Acquisition()
    {
        key_item_Count += 1;
    }
    public void Runnig()
    {
        stamina -= 1;
    }
}
