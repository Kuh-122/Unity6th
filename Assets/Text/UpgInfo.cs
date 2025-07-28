using UnityEngine;
using TMPro;

public class UpgInfo : MonoBehaviour
{
    public GM gameManager; // GM ��ũ��Ʈ�� ������ ����
    public TextMeshProUGUI UpgText; // UI �ؽ�Ʈ

    void Update()
    {
        UpgText.text = $"Get Gold: {gameManager.GetMoreGold}\n" +
            $"Get Crystal: {gameManager.GetCrystal} \n" 
          
        ;
    }
}