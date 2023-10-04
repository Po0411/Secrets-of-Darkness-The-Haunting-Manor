using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_move : MonoBehaviour
{
    [SerializeField]
    private GameObject move_obj;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) // 플레이어 태그를 사용하여 충돌한 게임 오브젝트가 플레이어인지 확인
        {
            move_obj.transform.position = new Vector3(0.3f, 5, -12.9f);
        }
    }
}
