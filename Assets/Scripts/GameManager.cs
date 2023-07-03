using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject currentSelectedCell;
    [SerializeField] PlayerManager playerManager;
    [SerializeField] EnemyManager enemyManager;
    public static GameManager instance;
    public bool isSelect;
    private enum Round
    {
        round1, round2, round3, round4, warring
    } Round round = Round.round1;
    private enum quantityEnemy
    {

    }
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        enemyManager.num = 1;
    }
    void Update()
    {
        isSelect = playerManager.isSelect;
        GameScript();
    }
    private void GameScript()
    {
        switch(round)
        {
            case Round.round1:
                if (enemyManager.num > 0) enemyManager.SpawnEnemy("EnemyLv1");
                if (enemyManager.transform.childCount == 0) 
                {
                    enemyManager.spawnComplete = false;
                    enemyManager.num = 3;
                    round = Round.round2; 
                } 
                break;
            case Round.round2:
                if (enemyManager.num > 0) enemyManager.SpawnEnemy("EnemyLv1");
                if (enemyManager.transform.childCount == 0)
                {
                    enemyManager.spawnComplete = false;
                    round = Round.round3;
                }
                break;



        }
    }
    public void MovePlayerToSelectedCell()
    {
        playerManager.transform.position = currentSelectedCell.transform.position;
        playerManager.isSelect = false;
    }
}
