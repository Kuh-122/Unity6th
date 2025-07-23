using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public GM gameManager;
    public void OnClickButton()
    {
        if (gameManager.Crystal >= 300)
        {
            gameManager.Crystal -= 300;
            gameManager.Ending = true;
        }
    }  
}