using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 이동 속도



    private void Update()
    {
        // 키보드 입력을 감지하여 이동 방향을 계산합니다.
        float horizontalInput = Input.GetAxis("Horizontal"); // 좌우 이동
        float verticalInput = Input.GetAxis("Vertical"); // 앞뒤 이동

        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // 이동 방향에 따라 게임 오브젝트를 이동시킵니다.
        if (moveDirection != Vector3.zero)
        {
            // 이동 벡터를 월드 좌표로 변환하여 이동합니다.
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        }
    }
}
