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
                Debug.Log("소리끄기");
            }
            else
            {
                gameManager.PSound = true;
                Debug.Log("소리켜기");
            }
        }
        else
        {
            Debug.Log("나가라");
        }


        
    }
}