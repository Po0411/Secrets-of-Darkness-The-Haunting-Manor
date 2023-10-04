using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_del : MonoBehaviour
{
    public GameObject Destroy_obj;
    public void Onclick()
    {
        Destroy(Destroy_obj);
    }
}
