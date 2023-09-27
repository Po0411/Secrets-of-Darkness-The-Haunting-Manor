using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_spwner : MonoBehaviour
{
    [SerializeField]
    private int max_item = 0;
    [SerializeField]
    private Collider[] spwn_zoen;
    [SerializeField]
    private GameObject key_item;

    private void Start()
    {
        for(int i=0;i<=max_item-1;i++)
        {
           float rangeX=Random.Range((spwn_zoen[i].bounds.size.x/2 )* -1, spwn_zoen[i].bounds.size.x/2);//약간 이상한 곳에 스폰됨
           float rangeZ = Random.Range((spwn_zoen[i].bounds.size.z/2)* -1, spwn_zoen[i].bounds.size.z/2);//약간 이상한 곳에 스폰됨

            key_item =Instantiate(key_item,key_item.transform.position=new Vector3(rangeX, 0, rangeZ), Quaternion.identity);
        }
         
    }
}
