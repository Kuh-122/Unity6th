using JetBrains.Annotations;
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

            if (percent > gameManager.GetCrystal)
            {
                Debug.Log("でででででで");
            }

        }

        if (gameManager.PSound == true)
        {
            Miningsound();
        }
    }

    ///////////////////////////////////////////// 紫錘球 淫恵 //////////////////////////////////////////////////

    public AudioSource SoundSource;
    public AudioClip Clip;
    public void Miningsound() 
    {
        SoundSource.PlayOneShot(Clip);
    }
}