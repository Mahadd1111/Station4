using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerEquipment : MonoBehaviour
{
    [SerializeField] private Torch torch;
    [SerializeField] private Radio radio;

    // Automatically called by Player Input
    public void OnTorch(InputValue value)
    {
        if (!value.isPressed) return;

        bool turningOn = !torch.IsOn;

        if (turningOn)
        {
            radio.SetRadio(false);
        }

        torch.SetTorch(turningOn);
    }

    // Automatically called by Player Input
    public void OnRadio(InputValue value)
    {
        if (!value.isPressed) return;

        bool turningOn = !radio.IsOn;

        if (turningOn)
        {
            torch.SetTorch(false);
        }

        radio.SetRadio(turningOn);
    }
}
