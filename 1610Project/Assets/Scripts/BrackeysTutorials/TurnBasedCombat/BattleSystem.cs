using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState {START, PLAYERTURN, ENEMYTURN, WON, LOST}
public class BattleSystem : MonoBehaviour
{
    //from BrackeyTutorial

    public Unit playerUnitSO;
    public Unit enemyUnitSO;

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform playerSpawnPoint;
    public Transform enemySpawnPoint;

    public Text DialogueText;

    public BattleHud enemyHud;
    public BattleHud playerHud;

    public BattleState state;
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    private void SetupBattle()
    {
        Instantiate(playerPrefab, playerSpawnPoint);
        Instantiate(enemyPrefab, enemySpawnPoint);

        DialogueText.text = enemyUnitSO.unitName + " appears before you...";
        
        enemyHud.setHUD(enemyUnitSO);
        playerHud.setHUD(playerUnitSO);
    }
}
