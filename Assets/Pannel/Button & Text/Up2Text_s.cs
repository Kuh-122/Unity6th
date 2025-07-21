using UnityEngine;
using TMPro;
public class Up2Text_s : MonoBehaviour
{
    public GM gameManager;
    public TextMeshProUGUI PrcText;

    private void Update()
    {
        PrcText.text = $"PlusClicks: (Limit 4)\n" +
            $"Cost: {gameManager.Up2Cost}";
    }
}