using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class obj_Interaction : MonoBehaviour
{
    RaycastHit hit;
    float interaction_length = 1.5f;
    public GameObject interract_text;
    Animator animator;

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * interaction_length, Color.green, 0.3f);
        if (Physics.Raycast(transform.position, transform.forward, out hit, interaction_length))
        {
            if (hit.transform.tag == "item")
            {
                interract_text.SetActive(true);

            }
            else if(hit.transform==null|| hit.transform.tag != "item")
            {
                interract_text.SetActive(false);
            }
        }
    }
    void Onclick()
    {
        Destroy(gameObject);
    }
}
