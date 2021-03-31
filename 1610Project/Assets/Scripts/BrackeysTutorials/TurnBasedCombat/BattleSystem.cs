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

    public float seconds = 2f;
    public float enemyTurnDelay = 1f;
    private WaitForSeconds wfs;
    private WaitForSeconds enemyWfs;

    public BattleState state;
    void Start()
    {
        wfs = new WaitForSeconds(seconds);
        enemyWfs = new WaitForSeconds(enemyTurnDelay);
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        Instantiate(playerPrefab, playerSpawnPoint);
        Instantiate(enemyPrefab, enemySpawnPoint);

        DialogueText.text = enemyUnitSO.unitName + " appears before you...";
        
        enemyHud.setHUD(enemyUnitSO);
        playerHud.setHUD(playerUnitSO);

        yield return wfs;

        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        bool isDead = enemyUnitSO.TakeDamage(playerUnitSO.dmgStat);
        
        enemyHud.SetHP(enemyUnitSO.currentHp);
        DialogueText.text = playerUnitSO.unitName + " deals " + playerUnitSO.dmgStat + "!";
        
        yield return wfs;

        if (isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    IEnumerator EnemyTurn()
    {
        DialogueText.text = enemyUnitSO.unitName + " attacks!";

        yield return enemyWfs;

       bool isDead = playerUnitSO.TakeDamage(enemyUnitSO.dmgStat);
        
        playerHud.SetHP(playerUnitSO.currentHp);

        yield return enemyWfs;

        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
        }

    }

    void EndBattle()
    {
        if (state== BattleState.WON)
        {
            DialogueText.text = "You are victorious!";
        }
        else if (state == BattleState.LOST)
        {
            DialogueText.text = "You suffer a humiliating defeat.";
        }
    }
    
    void PlayerTurn()
    {
        DialogueText.text = "Choose an Action:";
    }
    

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN) return;

            StartCoroutine(PlayerAttack());
          
    }

    IEnumerator PlayerHeal()
    {
        playerUnitSO.Heal(5);
        
        playerHud.SetHP(playerUnitSO.currentHp);
        DialogueText.text = playerUnitSO.unitName + " has healed for 5 hit points.";

        yield return wfs;

        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
    }
    
    public void OnHealButton()
    {
        if (state != BattleState.PLAYERTURN) return;

            StartCoroutine(PlayerHeal());
          
    }
}
