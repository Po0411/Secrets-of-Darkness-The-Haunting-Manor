using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    // 충돌이 시작될 때 호출됩니다.
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 "Playe" 오브젝트인지 확인합니다.
        if (other.CompareTag("Playe"))
        {
            // "Playe" 오브젝트와 충돌하면 원하는 코드를 실행합니다.
            // 여기에서는 "ObjectMover" 스크립트가 있는 게임 오브젝트를 찾아서 해당 스크립트의 InteractWithPlaye 함수를 호출합니다.
            ObjectMover objectMover = GetComponentInParent<ObjectMover>();
            if (objectMover != null)
            {
                objectMover.SurpriseScript();
            }
        }
    }
}
