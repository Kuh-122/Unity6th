using UnityEngine;
using UnityEngine.UI;

public class Mining : MonoBehaviour
{
    public GM gameManager;

    public float percent = Random.Range(0f, 100);
 
public void OnClickButton()
    {
        for (int i = 1; i <= gameManager.Up2Pr; i++)
        {
            gameManager.Gold += gameManager.GetMoreGold;

            if (percent < gameManager.GetCrystal)
            {
                gameManager.Crystal += 1;
            }

        }

        if (gameManager.PSound == true)
        {
            Miningsound();
        }
    }

    ///////////////////////////////////////////// 사운드 관련 //////////////////////////////////////////////////

    public AudioSource SoundSource;
    public AudioClip Clip;
    public void Miningsound() 
    {
        SoundSource.PlayOneShot(Clip);
    }
}