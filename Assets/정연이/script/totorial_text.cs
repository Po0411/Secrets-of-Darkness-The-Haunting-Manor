using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class totorial_text : MonoBehaviour
{
    string[] texts = new string[4] {"0","이제 기본적인 조작법을 설명하겠습니다.\n\n이동은 왼쪽 컨트롤러의 조이스틱으로 할 수 있습니다.\n클릭은 아무 컨트롤러의 빔을 클릭하고 싶은 곳에 조준하고,검지 버튼을 눌러 하실 수 있습니다.\n시점은 플레이하는 사람이 바라보는 곳을 바라봅니다.", "아이템은 기본적으로 빛을 내는 효과가 있으며, 맵 곳곳에 숨어 있습니다.\n 아이템을 획득하려면 오른쪽에 들고 있는 손전등으로 아이템을 비춘 후, 획득하기 버튼을 누르시면 획득이 됩니다. ", "튜토리얼을 마치셨습니다.이제 게임을 즐겨주세요!"};
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
