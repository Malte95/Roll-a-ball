using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UI")]
    public GameObject popupPanel;
    public float popupDelay = 1.2f;

    public void ShowPopup()
    {
        Invoke(nameof(ActivatePopup), popupDelay);
    }

    private void ActivatePopup()
    {
        if (popupPanel != null)
            popupPanel.SetActive(true);
        else
            Debug.LogWarning("PopupPanel is not assinged (Inspector");
    }
}
