using UnityEngine;
using UnityEngine.UI;

public class Up3Button_s : MonoBehaviour
{
    public GM gameManager;

    public void OnButtonClick()
    {
        if(gameManager.Gold > gameManager.Up3Cost)
        {
            gameManager.Gold -= gameManager.Up3Cost;
            gameManager.GetCrystal += 1;

            gameManager.Up3Cost += 500;
        }
    }

    

}
