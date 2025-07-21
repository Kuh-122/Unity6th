using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public GM gameManager;
   
    public void OnClickButton()
    {


        if (gameManager != null)
        {
            if (gameManager.PSound == true)
            {
                gameManager.PSound = false;
                Debug.Log("�Ҹ�����");
            }
            else
            {
                gameManager.PSound = true;
                Debug.Log("�Ҹ��ѱ�");
            }
        }
        else
        {
            Debug.Log("������");
        }


        
    }
}