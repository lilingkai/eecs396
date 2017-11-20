using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class MenuButton : MonoBehaviour
{
    protected readonly Vector3 hiddenPosition = new Vector3(500000, 500000, 500000);
    protected Vector3 visiblePosition;
    protected Button _button;

    // Use this for initialization
    protected virtual void Start()
    {
        _button = gameObject.GetComponent<Button>();
        visiblePosition = _button.transform.position;
        Hide();
        _button.onClick.AddListener(OnClick);
    }

    protected abstract void OnClick();

    public virtual void Appear()
    {
        _button.transform.position = visiblePosition;
    }

    public virtual void Hide()
    {
        _button.transform.position = hiddenPosition;
    }
}
