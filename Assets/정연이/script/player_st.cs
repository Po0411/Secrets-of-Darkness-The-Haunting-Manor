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

    public static player_st player_St = null;

    void Awake()
    {
        if (player_St==null)
        {
            player_St = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if(player_St!=this)
                Destroy(this.gameObject);
        }
    }

    public IEnumerator Damage(int damage_index)
    {
        yield return 0;
        hp -= damage_index;
        Debug.Log(hp);
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
    public void Helaing()
    {
        hp += 1;
    }
}
