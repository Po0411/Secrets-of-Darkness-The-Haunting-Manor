using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secen_move : MonoBehaviour
{
    public string scene_name;
    public GameObject in_out;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            in_out.SetActive(true);
            SceneManager.LoadScene(scene_name);
            
        }
    }
}
