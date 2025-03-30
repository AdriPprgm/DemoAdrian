
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ReturnController : MonoBehaviour
{
    private UIDocument returns;

    private Button returnButton;

    void OnEnable()
    {
        returns = GetComponent<UIDocument>();
        var root = returns.rootVisualElement;
        returnButton = root.Q<Button>("ReturnButton");

        returnButton.RegisterCallback<ClickEvent>(ReturnMenu);
    }

    private void ReturnMenu(ClickEvent evt)
    {
        SceneManager.LoadScene(0);
    }
}
