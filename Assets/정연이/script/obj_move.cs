using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_move : MonoBehaviour
{
    [SerializeField]
    private GameObject move_obj;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) // �÷��̾� �±׸� ����Ͽ� �浹�� ���� ������Ʈ�� �÷��̾����� Ȯ��
        {
            move_obj.transform.position = new Vector3(0.3f, 5, -12.9f);
        }
    }
}
