using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public GM gameManager;
    public Pannel Pannel;

   public void OnButtonClick()
    {
        if (gameManager.shop == false)
        {
            gameManager.shop = true;
            Pannel.ShowPannel();
        }
        else
        {
            gameManager.shop = false;
            Pannel.ClosePannel();
        }
    }
}
