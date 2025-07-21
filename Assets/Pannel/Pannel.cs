using UnityEngine;
using UnityEngine.UI;

public class Pannel : MonoBehaviour
{
    public GM gameManager;

    private void Awake()
    {
        gameObject.SetActive(false);
    }
    public void ShowPannel()
    {
     
        gameObject.SetActive(true);
    }
    public void ClosePannel()
    {

        gameObject.SetActive(false);
    }
}
