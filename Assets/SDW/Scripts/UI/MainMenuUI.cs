using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button m_exitButton;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        
        if (GameManager.Instance.Graphics.IsFirstTime)
        {
            GameManager.Instance.Graphics.SetBrightness(0.5f);
        }
    }

    private void OnEnable()
    {
        m_exitButton.onClick.AddListener(GameManager.Instance.Exit);
    }

    private void OnDisable()
    {
        m_exitButton.onClick.RemoveAllListeners();
    }
}
