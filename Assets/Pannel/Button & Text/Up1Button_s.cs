using UnityEngine;
using UnityEngine.UI;

public class Up1Button_s : MonoBehaviour
{
    public GM gameManager;

    private int n = 1;
    private int prg = 0;
    public void OnButtonClick()
    {
        if (gameManager.Gold >= gameManager.Up1Cost)
        {
            gameManager.Gold -= gameManager.Up1Cost;
            gameManager.GetMoreGold += n*2;

            if (prg <= 5)
            {
                gameManager.Up1Cost += 50;
            }
            else if (prg <= 5 && prg <= 10)
            {
                gameManager.Up1Cost += 100;
            }
            else if (prg <= 10 && prg <= 40)
            {
                gameManager.Up1Cost += 300;
            }
            else if (prg <= 40 && prg <= 50)
            {
                gameManager.Up1Cost += 1000;
            }
            else
            {
                gameManager.Up1Cost += 5000;
            }

            n += 1;
            prg += 1;

        }
    }
}