using UnityEngine;
using UnityEngine.UI;

public class Up2Button_s : MonoBehaviour
{
    public GM gameManager;

    public void OnClickButton()
    {
        if (gameManager.Up2Pr <= 4)
        {

            if (gameManager.Gold >= gameManager.Up2Cost)
            {
                gameManager.Gold -= gameManager.Up2Cost;
                gameManager.Up2Pr += 1;

                gameManager.Up2Cost *= 2;

            }


        }

    }




}