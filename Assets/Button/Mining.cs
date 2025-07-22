using UnityEngine;
using UnityEngine.UI;

public class Mining : MonoBehaviour
{
    public GM gameManager;
    public float percent;
    public void Awake()
    {
        percent = Random.Range(0f, 100);
    }

    public void OnClickButton()
    {
        for (int i = 1; i <= gameManager.Up2Pr; i++) 
        {
            gameManager.Gold += gameManager.GetMoreGold;

            if (percent < gameManager.GetCrystal) // ũ����Ż ŉ��
            {
                gameManager.Crystal += 1;
            }

            percent = Random.Range(0f, 100); // ���� ����
        }

        if (gameManager.PSound == true)
        {
            Miningsound();
        }
    }

    ///////////////////////////////////////////// ���� ���� //////////////////////////////////////////////////

    public AudioSource SoundSource;
    public AudioClip Clip;
    public void Miningsound() 
    {
        SoundSource.PlayOneShot(Clip);
    }
}