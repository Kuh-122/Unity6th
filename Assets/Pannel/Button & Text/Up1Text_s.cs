using UnityEngine;
using TMPro;
public class Up1Text_s : MonoBehaviour
{
    public GM gameManager;
    public TextMeshProUGUI PrcText;

    private void Update()
    {
        PrcText.text = $"GetMoreGold: + {gameManager.GetMoreGold}\n" +
            $"Cost: {gameManager.Up1Cost}";
    }
}
