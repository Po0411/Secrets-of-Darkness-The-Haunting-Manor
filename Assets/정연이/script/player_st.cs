using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_st : MonoBehaviour
{
    [SerializeField]
    private int hp=3;

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
    public void Helaing()
    {
        hp += 1;
    }
}
