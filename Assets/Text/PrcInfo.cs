using UnityEngine;
using TMPro;
public class PrcInfo : MonoBehaviour
{
    public GM gameManager;
    public TextMeshProUGUI PrcText;

    private void Update()
    {
        PrcText.text =
            $"MoreClickProgress (Max 5): {gameManager.Up2Pr}\n" +
            $"CrystalProgress (Max 20): {gameManager.GetCrystal}";
    }
}