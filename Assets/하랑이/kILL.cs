using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kILL : MonoBehaviour
{
    // ������ ������Ʈ�� Unity Inspector���� ������ �� �ֵ��� public ������ ����ϴ�.
    public GameObject objectToDelete;
    public GameObject objectToDelete1;


    int a = 0;


    AudioSource audioSource;

    void Start()
    {
        // ����� �ҽ� ���� �� �ʱ�ȭ ���� �ڵ�
        audioSource = GetComponent<AudioSource>();
    }


    void PlayAudio()
    {
        // ������� ����Ϸ��� ����� �ҽ��� Play �޼��带 ȣ���մϴ�.
        audioSource.Play();
    }

    // �÷��̾ Ʈ���ſ� �������� �� ȣ��Ǵ� �ݹ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        // ������ ������Ʈ�� �÷��̾����� Ȯ���մϴ�.
        if (other.CompareTag("Player"))
        {
            // �÷��̾ Ʈ���ſ� �����ϸ� objectToDelete ������Ʈ�� �����մϴ�.
            Destroy(objectToDelete);
            Destroy(objectToDelete1);

            // �ٸ� ������ �����ϰų� �߰����� ������ �߰��� �� �ֽ��ϴ�.

        }


        if (other.CompareTag("Player")) // �÷��̾� �±׸� ����Ͽ� �浹�� ���� ������Ʈ�� �÷��̾����� Ȯ��
        {
            if (a == 0)
            {
                PlayAudio();
                a++;
            }
        }
    }
}
