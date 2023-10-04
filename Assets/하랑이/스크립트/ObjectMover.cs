using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public Transform targetTransform; // �̵��� ��� ������Ʈ�� Transform ������Ʈ�� Inspector���� ������ �� �ֵ��� public ������ ����մϴ�.
    public float speed = 5.0f; // �̵� �ӵ��� ������ �� �ִ� �����Դϴ�.

    private Vector3 startPosition; // �̵� ���� ��ġ�� ������ �����Դϴ�.
    private Vector3 targetPosition; // �̵� ��ǥ ��ġ�� ������ �����Դϴ�.
    private bool isMoving = false; // ���� �̵� ������ ���θ� ��Ÿ���� �����Դϴ�.


    private void Start()
    {
        startPosition = transform.position; // ���� ��ġ�� ���� ������Ʈ�� ��ġ�� �����մϴ�.
        targetPosition = new Vector3(11.0f, transform.position.y, transform.position.z); // ��ǥ ��ġ�� (11, ���� y, ���� z)�� �����մϴ�.
    }

    private IEnumerator MoveToTarget()
    {
        float journeyLength = Vector3.Distance(startPosition, targetPosition);
        float startTime = Time.time;

        while (isMoving)
        {
            float distanceCovered = (Time.time - startTime) * speed;
            float journeyFraction = distanceCovered / journeyLength;
            transform.position = Vector3.Lerp(startPosition, targetPosition, journeyFraction);

            if (journeyFraction >= 1.0f)
            {
                isMoving = false;
                // ���⿡�� �ʿ��� �ڵ带 �����մϴ�.
            }

            yield return null;
        }
    }

    //================================================================================================================
    public GameObject objectToDelete;
    public GameObject objectToDelete1;



    private void OnTriggerEnter(Collider other)
    {

        // ������ ������Ʈ�� �÷��̾����� Ȯ���մϴ�.
        if (other.CompareTag("Player"))
        {
            // �÷��̾ Ʈ���ſ� �����ϸ� objectToDelete ������Ʈ�� �����մϴ�.
            Destroy(objectToDelete);
            Destroy(objectToDelete1);
            MoveToTarget();
        }
    }
}
