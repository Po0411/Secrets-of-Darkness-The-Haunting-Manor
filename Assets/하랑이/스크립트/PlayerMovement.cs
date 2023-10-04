using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �̵� �ӵ�



    private void Update()
    {
        // Ű���� �Է��� �����Ͽ� �̵� ������ ����մϴ�.
        float horizontalInput = Input.GetAxis("Horizontal"); // �¿� �̵�
        float verticalInput = Input.GetAxis("Vertical"); // �յ� �̵�

        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // �̵� ���⿡ ���� ���� ������Ʈ�� �̵���ŵ�ϴ�.
        if (moveDirection != Vector3.zero)
        {
            // �̵� ���͸� ���� ��ǥ�� ��ȯ�Ͽ� �̵��մϴ�.
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        }
    }
}
