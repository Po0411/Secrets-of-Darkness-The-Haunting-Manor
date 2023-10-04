using UnityEngine;
using System.Collections; // �� �κ��� �߰��ؾ� �մϴ�.


public class MoveAndDestroyObjectOnTrigger : MonoBehaviour
{
    public Transform objectToMove; // �̵��� ��ü�� Transform
    public float moveSpeed = 2.475f; // �̵� �ӵ�
    public float destroyDelay = 3.0f; // ��ü �ı� ������ �ð�
    private bool isPlayerInside = false; // �÷��̾ Ʈ���� �ȿ� �ִ��� ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �÷��̾� �±׸� ����Ͽ� �浹�� ���� ������Ʈ�� �÷��̾����� Ȯ��
        {
            isPlayerInside = true;
            StartCoroutine(MoveAndDestroy());
        }
    }

    private IEnumerator MoveAndDestroy()
    {
        // �÷��̾ Ʈ���� �ȿ� ���� �� ��ü�� �̵��մϴ�.
        if (objectToMove != null)
        {
            Vector3 targetPosition = new Vector3(0.069f, objectToMove.position.y, objectToMove.position.z);
            while (objectToMove.position.x > 0.069f)
            {
                // ��ǥ ��ġ�� �����Ͽ� �̵��մϴ�.
                objectToMove.position = Vector3.MoveTowards(objectToMove.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }

            // �̵��� �Ϸ�� �� ���� �ð� �ڿ� ��ü�� �ı��մϴ�.
            yield return new WaitForSeconds(destroyDelay);
            Destroy(objectToMove.gameObject);
            
        }
    }
}
