using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public GM gameManager;
    public void OnClickButton()
    {
        if (gameManager.Crystal >= 1000)
        {
            gameManager.Crystal -= 1000;
        }
    }  
}