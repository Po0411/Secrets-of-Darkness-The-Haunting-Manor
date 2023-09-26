using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class trap_work : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
                switch (gameObject.GetComponentInChildren<trap_st>().trap_type)
                { 
                    case "spike":
                        {
                            animator.SetBool("spike_wark", true);
                            StartCoroutine(key_off("spike_wark", 1f));
                        
                        }
                        break;
                    case "rock":
                        {
                            animator.SetBool("rock_wark", true);
                            StartCoroutine(key_off("rock_wark", 1f));
                        }
                        break;
                    case "Noen":break;
                    default:
                        {
                        
                            Debug.LogWarning("존재하지 않는 함정입니다.");
                        }
                        break;
                }
        }
    }
    
    

    IEnumerator key_off(string key_name,float wait_time)
    {
        yield return new WaitForSeconds(wait_time);
        animator.SetBool(key_name, false);
    }
    
}
