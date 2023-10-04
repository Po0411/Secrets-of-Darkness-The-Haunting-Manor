using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    // �浹�� ���۵� �� ȣ��˴ϴ�.
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ������Ʈ�� "Playe" ������Ʈ���� Ȯ���մϴ�.
        if (other.CompareTag("Playe"))
        {
            // "Playe" ������Ʈ�� �浹�ϸ� ���ϴ� �ڵ带 �����մϴ�.
            // ���⿡���� "ObjectMover" ��ũ��Ʈ�� �ִ� ���� ������Ʈ�� ã�Ƽ� �ش� ��ũ��Ʈ�� InteractWithPlaye �Լ��� ȣ���մϴ�.
            ObjectMover objectMover = GetComponentInParent<ObjectMover>();
            if (objectMover != null)
            {
                objectMover.SurpriseScript();
            }
        }
    }
}
