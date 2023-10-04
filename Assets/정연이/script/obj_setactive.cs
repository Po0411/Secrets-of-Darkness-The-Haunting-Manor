using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_setactive : MonoBehaviour
{
    [SerializeField]
    private Collider triger;
    [SerializeField]
    private GameObject set_obj;
    [SerializeField]
    private bool T_or_F;
    [SerializeField]
    private bool tag_in;
    [SerializeField]
    private string tag_name;

    private void OnTriggerEnter(Collider other)
    {
        other = triger;
        if (tag_name != null)
        {
            if (T_or_F)
                set_obj.SetActive(true);
            else
                set_obj.SetActive(false);
        }
        else if(other.tag==tag_name) 
        {
            if (T_or_F)
                set_obj.SetActive(true);
            else
                set_obj.SetActive(false);
        }
    }
}
