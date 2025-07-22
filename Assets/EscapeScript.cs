using UnityEngine;
using UnityEngine.UI;

public class EscapeScript : MonoBehaviour
{
    public GM gameManager;

    public void Update()
    {
        if (gameManager.Ending == true)
        {
            transform.localPosition = new Vector3(0, 5, 0);
        }
    }
}