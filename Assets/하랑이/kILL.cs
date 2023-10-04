using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kILL : MonoBehaviour
{
    // 삭제할 오브젝트를 Unity Inspector에서 설정할 수 있도록 public 변수로 만듭니다.
    public GameObject objectToDelete;
    public GameObject objectToDelete1;


    int a = 0;


    AudioSource audioSource;

    void Start()
    {
        // 오디오 소스 설정 및 초기화 등의 코드
        audioSource = GetComponent<AudioSource>();
    }


    void PlayAudio()
    {
        // 오디오를 재생하려면 오디오 소스의 Play 메서드를 호출합니다.
        audioSource.Play();
    }

    // 플레이어가 트리거에 진입했을 때 호출되는 콜백 함수
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


        if (other.CompareTag("Player")) // 플레이어 태그를 사용하여 충돌한 게임 오브젝트가 플레이어인지 확인
        {
            if (a == 0)
            {
                PlayAudio();
                a++;
            }
        }
    }
}
