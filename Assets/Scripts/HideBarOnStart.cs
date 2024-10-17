using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBarOnStart : MonoBehaviour
{
    [SerializeField] private Canvas ARMagicBar;

    // Start is called before the first frame update
    void Start()
    {
        UIButtonHandler.OnUIStartButtonClicked += StartButtonClicked;
        UIButtonHandler.OnUIResetButtonClicked += OnResetButtonClicked;
    }

    private void StartButtonClicked()
    {
        ARMagicBar.enabled = false;

    }

    private void OnResetButtonClicked()
    {
        ARMagicBar.enabled = true;
    }

}
