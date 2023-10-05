using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_spwner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spwn_obj;
    [SerializeField]
    private int spwn_item_index = 5;

    int[] trash_count;
    int randomindex = 0;

    private void Start()
    {
        trash_count = new int[spwn_obj.Length];

        int spwn_count = 0;
        bool retry = false;

        for (int i = 0; i <= 100; i++)
        {
            if (spwn_count == spwn_item_index)
                break;

            randomindex = Random.Range(1, 10);
            for (int L = 0; L <= trash_count.Length - 1; L++)
            {
                if (trash_count[L] == randomindex)
                {
                    retry = true;
                    break;
                }
            }
            if (retry)
            {
                retry = false;
                continue;
            }
            trash_count[spwn_count] = randomindex;
            spwn_count++;
            spwn_obj[randomindex-1].SetActive(true);
        }
    }
}
