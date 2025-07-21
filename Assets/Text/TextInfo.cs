using UnityEngine;
using TMPro;

public class TextInfo : MonoBehaviour
{
    public GM gameManager; // GM 스크립트를 연결
    public TextMeshProUGUI goldText; // 텍스트

    void Update()
    {
        goldText.text = $"Gold: {gameManager.Gold}\n" + //G
            $"Crystal: {gameManager.Crystal}";
    }
}