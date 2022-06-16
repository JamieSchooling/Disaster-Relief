using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;

    [SerializeField] int money = 0;
    TMP_Text moneyText;

    private void Awake()
    {
        instance = this;
        ScoreCalculator.OnScoreUpdated += UpdateMoney;
    }

    private void OnLevelWasLoaded(int level)
    {

        ScoreCalculator.OnScoreUpdated += UpdateMoney;
    }

    // Start is called before the first frame update
    void Start()
    {
        moneyText = GameObject.FindGameObjectWithTag("MoneyText").GetComponent<TMP_Text>();
        DontDestroyOnLoad(gameObject);
        ScoreCalculator.OnScoreUpdated += UpdateMoney;
        moneyText.text = money.ToString();
    }

    public void UpdateMoney(int _money)
    {
        money += _money;
        moneyText.text = money.ToString();
    }

    public void Buy(int amount)
    {
        if (money < amount)
        {
            money -= amount;
        }
    }
}
