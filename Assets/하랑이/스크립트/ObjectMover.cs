using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public Transform objectToMove; // �̵��� ��ü�� Transform
    public float moveSpeed = 5f; // �̵� �ӵ�
    private bool isPlayerInside = false; // �÷��̾ Ʈ���� �ȿ� �ִ��� ����

    private Vector3 startPosition; // �̵� ���� ��ġ
    private Vector3 targetPosition; // �̵� ��ǥ ��ġ

    private void Start()
    {
        startPosition = objectToMove.position; // ���� ��ġ ����
        targetPosition = new Vector3(-22.0f, objectToMove.position.y, objectToMove.position.z); // ��ǥ ��ġ ����
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾� �±׸� ����Ͽ� �浹�� ���� ������Ʈ�� �÷��̾����� Ȯ��
        {
            isPlayerInside = true;
            StartCoroutine(MoveAndDestroy());
            Debug.Log("Ȯ��");
        }
    }

    private IEnumerator MoveAndDestroy()
    {
        // �÷��̾ Ʈ���� �ȿ� ���� �� ��ü�� �̵��մϴ�.
        if (objectToMove != null)
        {
            while (objectToMove.position.x > -22.0f)
            {
                // ��ǥ ��ġ�� �����Ͽ� �̵��մϴ�.
                objectToMove.position = Vector3.MoveTowards(objectToMove.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }

            // �̵��� �Ϸ�Ǹ� �ش� ������Ʈ�� �����մϴ�.
            Destroy(objectToMove.gameObject);
        }
    }
}