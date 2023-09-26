using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_trap : MonoBehaviour
{
    [SerializeField]
    private GameObject ghost;
    [SerializeField]
    private GameObject item;

    private void Update()
    {
        if (item == null)
        {
            ghost.SetActive(true);
        }
    }

}
