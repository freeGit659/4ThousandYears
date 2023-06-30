using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject currentSelectedCell;
    [SerializeField] PlayerManager playerManager;
    public static GameManager instance;
    public bool isSelect;
    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        isSelect = playerManager.isSelect;
    }
    public void MovePlayerToSelectedCell()
    {
        playerManager.transform.position = currentSelectedCell.transform.position;
        playerManager.isSelect = false;
    }
}
