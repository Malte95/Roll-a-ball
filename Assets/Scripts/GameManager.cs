using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [Header("UI")]
    public GameObject popupPanel;
    public float popupDelay = 1.2f;
    public Button playAgainButton;

    public void ShowPopup()
    {
        Invoke(nameof(ActivatePopup), popupDelay);
    }
    private void ActivatePopup()
    {
        if (popupPanel != null)
        {
            popupPanel.SetActive(true);

            EventSystem.current.SetSelectedGameObject(playAgainButton.gameObject);
        }
        else
        {
            Debug.LogWarning("PopupPanel is not assigned (Inspector).");
        }
    }


    public void OnPlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        // If Popup is visable and "Enter" is pressed
        if (popupPanel.activeSelf &&
       (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            OnPlayAgain();
        }
    }
}
