using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class totorial_text : MonoBehaviour
{
    string[] texts = new string[4] {"0","���� �⺻���� ���۹��� �����ϰڽ��ϴ�.\n\n�̵��� ���� ��Ʈ�ѷ��� ���̽�ƽ���� �� �� �ֽ��ϴ�.\nŬ���� �ƹ� ��Ʈ�ѷ��� ���� Ŭ���ϰ� ���� ���� �����ϰ�,���� ��ư�� ���� �Ͻ� �� �ֽ��ϴ�.\n������ �÷����ϴ� ����� �ٶ󺸴� ���� �ٶ󺾴ϴ�.", "�������� �⺻������ ���� ���� ȿ���� ������, �� ������ ���� �ֽ��ϴ�.\n �������� ȹ���Ϸ��� �����ʿ� ��� �ִ� ���������� �������� ���� ��, ȹ���ϱ� ��ư�� �����ø� ȹ���� �˴ϴ�. ", "Ʃ�丮���� ��ġ�̽��ϴ�.���� ������ ����ּ���!"};
    public TextMeshProUGUI main_text;
    public GameObject item_traing;
    public GameObject fide_out;
    public GameObject tr_button;
    public int count=0;
    public void Onclick()
    {
        switch(count)
        {
            case 0:{
                    tr_button.SetActive(true);   
                    }break;
            case 1: item_traing.SetActive(true); break;
            case 3: { 
                    fide_out.SetActive(true);
                    StartCoroutine(scene_move());
                    } break;
        }
        count += 1;
            main_text.text = texts[count];
    }
    IEnumerator scene_move()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("main");
    }
}
