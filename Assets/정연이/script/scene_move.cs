using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_move : MonoBehaviour
{
    [SerializeField]
    private bool this_click;//��ư Ŭ������ �۵��ϴ��� �ƴ��� üũ
    [SerializeField]
    private string load_name;

    void OnClick()
    {
        if(this_click)
        {
            SceneManager.LoadScene(load_name);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (!this_click && other.tag == "Player")
        {
            DontDestroyOnLoad(other.gameObject);
            SceneManager.LoadScene(load_name);
        }
    }
}
