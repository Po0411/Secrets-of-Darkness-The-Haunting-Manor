using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    public Transform objectToMove; // 이동할 물체의 Transform
    public float moveSpeed = 5f; // 이동 속도
    private bool isPlayerInside = false; // 플레이어가 트리거 안에 있는지 여부

    private Vector3 startPosition; // 이동 시작 위치
    private Vector3 targetPosition; // 이동 목표 위치

    private void Start()
    {
        startPosition = objectToMove.position; // 시작 위치 설정
        targetPosition = new Vector3(-22.0f, objectToMove.position.y, objectToMove.position.z); // 목표 위치 설정
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 플레이어 태그를 사용하여 충돌한 게임 오브젝트가 플레이어인지 확인
        {
            isPlayerInside = true;
            StartCoroutine(MoveAndDestroy());
            Debug.Log("확인");
        }
    }

    private IEnumerator MoveAndDestroy()
    {
        // 플레이어가 트리거 안에 있을 때 물체를 이동합니다.
        if (objectToMove != null)
        {
            while (objectToMove.position.x > -22.0f)
            {
                // 목표 위치로 보간하여 이동합니다.
                objectToMove.position = Vector3.MoveTowards(objectToMove.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }

            // 이동이 완료되면 해당 오브젝트를 삭제합니다.
            Destroy(objectToMove.gameObject);
        }
    }
}