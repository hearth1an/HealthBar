using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class ButtonHandler : MonoBehaviour
{
    private Button _button;

    private void OnEnable()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeValue);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeValue);
    }

    public abstract void ChangeValue();
}
