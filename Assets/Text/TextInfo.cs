using UnityEngine;
using TMPro;

public class TextInfo : MonoBehaviour
{
    public GM gameManager; // GM ��ũ��Ʈ�� ����
    public TextMeshProUGUI goldText; // �ؽ�Ʈ

    void Update()
    {
        goldText.text = $"Gold: {gameManager.Gold}\n" + //G
            $"Crystal: {gameManager.Crystal}";
    }
}