using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    [SerializeField] private Button UIStartButton;
    [SerializeField] private Button UIShootButton;
    [SerializeField] private Button UIResetButton;

    public static event Action OnUIStartButtonClicked;
    public static event Action OnUIShootButtonClicked;
    public static event Action OnUIResetButtonClicked;
    

    // Start is called before the first frame update
    void Start()
    {
        UIStartButton.onClick.AddListener(OnStartButtonClicked);
        UIShootButton.onClick.AddListener(OnShootButtonClicked);
        UIResetButton.onClick.AddListener(OnResetButtonClicked);
        
        UIShootButton.gameObject.SetActive(false);
    }


    void OnStartButtonClicked()
    {
        OnUIStartButtonClicked?.Invoke();

        UIStartButton.gameObject.SetActive(false);
        UIShootButton.gameObject.SetActive(true);
    }

    void OnShootButtonClicked()
    {
        OnUIShootButtonClicked?.Invoke();
    }

    void OnResetButtonClicked()
    {
        OnUIResetButtonClicked?.Invoke();

        UIStartButton.gameObject.SetActive(true);
        UIShootButton.gameObject.SetActive(false);

    }
}
