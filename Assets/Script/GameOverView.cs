using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverView : MonoBehaviour
{
    public Text KillBossText;
    public Text KillEnemyText;

    // Start is called before the first frame update
    void Start()
    {
        KillBossText.text = "" + EnemyDeathManager.killBossNum;
        KillEnemyText.text = "" + EnemyDeathManager.killEnemyNum;
        EnemyDeathManager enemyDeathManager= GameObject.Find("EnemyDeathManager").GetComponent<EnemyDeathManager>();
        GameObject.Find("EnemyDeathManager").GetComponent<EnemyDeathManager>().setNewEnemyDeath();
    }


    public void onClickBtn()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main");
    }

}
