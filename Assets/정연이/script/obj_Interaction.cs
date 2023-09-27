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
            Debug.Log(hit);
            if (hit.transform.tag == "item")
            {
                interract_text.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if(hit.transform.GetComponent<item_st>().this_KeyItem)
                        GameManager.GM.Key_Item_Acquisition();
                    else
                    {
                        switch(hit.transform.GetComponent<item_st>().item_index)
                        {
                            case 0:
                                {
                                    Debug.Log("test_item");
                                    interract_text.SetActive(false);
                                    Destroy(hit.transform.gameObject);
                                }
                                break;
                        }
                    }
                }
            }
            else if(hit.transform==null|| hit.transform.tag != "item")
            {
                interract_text.SetActive(false);
            }
        }
    }
}
