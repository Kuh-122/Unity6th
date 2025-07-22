using TMPro;
using UnityEngine;

public class Up3Text_s : MonoBehaviour
{
    public GM gameManager;
    public TextMeshProUGUI PrcText;

    private void Update()
    {
        PrcText.text = $"GetCrystal: +1%\n" + $"Cost: {gameManager.Up3Cost}";
    }

}
