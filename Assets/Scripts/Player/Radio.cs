using UnityEngine;

public class Radio : MonoBehaviour
{
    [SerializeField] private GameObject activeIndicator;

    private bool isOn;

    public bool IsOn => isOn;

    private void Start()
    {
        SetRadio(false);
    }

    public void SetRadio(bool on)
    {
        isOn = on;

        if (activeIndicator != null)
        {
            activeIndicator.SetActive(on);
        }
    }
}
