using UnityEngine;
using UnityEngine.UI;

// WTF is wrong?

public class Up3Button_s : MonoBehaviour
{
    public GM gameManager;

    public void OnButtonClick()
    {
        if(gameManager.Gold > gameManager.Up3Cost)
        {
            gameManager.Gold -= gameManager.Up3Cost;
            gameManager.GetCrystal += 1;
        }
    }

    

}
