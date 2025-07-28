using UnityEngine;
using TMPro;

public class UpgInfo : MonoBehaviour
{
    public GM gameManager; // GM 스크립트를 연결할 변수
    public TextMeshProUGUI UpgText; // UI 텍스트

    void Update()
    {
        UpgText.text = $"Get Gold: {gameManager.GetMoreGold}\n" +
            $"Get Crystal: {gameManager.GetCrystal} \n" 
          
        ;
    }
}