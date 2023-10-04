using UnityEngine;
using System.Collections; // 이 부분을 추가해야 합니다.


public class MoveAndDestroyObjectOnTrigger : MonoBehaviour
{
    public Transform objectToMove; // 이동할 물체의 Transform
    public float moveSpeed = 2.475f; // 이동 속도
    public float destroyDelay = 3.0f; // 물체 파괴 딜레이 시간
    private bool isPlayerInside = false; // 플레이어가 트리거 안에 있는지 여부

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 플레이어 태그를 사용하여 충돌한 게임 오브젝트가 플레이어인지 확인
        {
            isPlayerInside = true;
            StartCoroutine(MoveAndDestroy());
        }
    }

    private IEnumerator MoveAndDestroy()
    {
        // 플레이어가 트리거 안에 있을 때 물체를 이동합니다.
        if (objectToMove != null)
        {
            Vector3 targetPosition = new Vector3(0.069f, objectToMove.position.y, objectToMove.position.z);
            while (objectToMove.position.x > 0.069f)
            {
                // 목표 위치로 보간하여 이동합니다.
                objectToMove.position = Vector3.MoveTowards(objectToMove.position, targetPosition, moveSpeed * Time.deltaTime);
                yield return null;
            }

            // 이동이 완료된 후 일정 시간 뒤에 물체를 파괴합니다.
            yield return new WaitForSeconds(destroyDelay);
            Destroy(objectToMove.gameObject);
            
        }
    }
}
