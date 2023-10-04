using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurpriseScript : MonoBehaviour
{

    public Transform targetTransform; // 이동할 대상 오브젝트의 Transform 컴포넌트를 Inspector에서 설정할 수 있도록 public 변수를 사용합니다.
    public float speed = 5.0f; // 이동 속도를 조절할 수 있는 변수입니다.

    private Vector3 startPosition; // 이동 시작 위치를 저장할 변수입니다.
    private Vector3 targetPosition; // 이동 목표 위치를 저장할 변수입니다.
    private bool isMoving = false; // 현재 이동 중인지 여부를 나타내는 변수입니다.

    private void Start()
    {
        startPosition = transform.position; // 시작 위치를 현재 오브젝트의 위치로 설정합니다.
        targetPosition = new Vector3(11.0f, transform.position.y, transform.position.z); // 목표 위치를 (11, 현재 y, 현재 z)로 설정합니다.
    }

    private void Update()
    {
        if (!isMoving)
        {
            // 아직 이동 중이 아니라면 이동 시작
            isMoving = true;
            StartCoroutine(MoveToTarget());
        }
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
                // 이동이 완료되면 이동 중지
                isMoving = false;
            }

            yield return null;
        }
    }

    //================================================================================================================
    public GameObject objectToDelete;
    public GameObject objectToDelete1;

    private void OnTriggerEnter(Collider other)
    {

        // 진입한 오브젝트가 플레이어인지 확인합니다.
        if (other.CompareTag("Player"))
        {
            // 플레이어가 트리거에 진입하면 objectToDelete 오브젝트를 삭제합니다.
            Destroy(objectToDelete);
            Destroy(objectToDelete1);

            // 다른 동작을 수행하거나 추가적인 로직을 추가할 수 있습니다.

        }

    }
}
