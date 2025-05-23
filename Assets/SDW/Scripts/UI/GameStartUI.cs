using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartUI : MonoBehaviour
{
    [Header("Main Menu")]
    [SerializeField] private Button m_mainMenuButton;
    [SerializeField] private string m_sceneName;

    [Header("Exit")]
    [SerializeField] private Button m_exitButton;
    
    [Header("UIs")]
    [SerializeField] private GameObject m_inventoryContainer;
    [SerializeField] private GameObject m_currentTimeContainer;
    [SerializeField] private GameObject m_playerStatusUI;
    [SerializeField] private GameObject m_interactionContainer;
    [SerializeField] private GameObject m_centerPoint;
    
    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        m_inventoryContainer.SetActive(false);
        m_interactionContainer.SetActive(false);
        m_playerStatusUI.SetActive(false);
        m_centerPoint.SetActive(false);
        
        m_currentTimeContainer.SetActive(false);
        m_mainMenuButton.onClick.AddListener(() => GameManager.Instance.ChangeScene(m_sceneName));
        m_exitButton.onClick.AddListener(GameManager.Instance.Exit);
    }


    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        GameManager.Instance.IsPaused = false;
        GameManager.Instance.IsGameOver = false;
        m_inventoryContainer.SetActive(true);
        m_interactionContainer.SetActive(true);
        m_playerStatusUI.SetActive(true);
        m_centerPoint.SetActive(true);
        
        m_currentTimeContainer.SetActive(true);
        m_exitButton.onClick.RemoveAllListeners();

    }
}
