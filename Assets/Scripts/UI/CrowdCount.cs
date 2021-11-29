using UnityEngine;
using TMPro;

public class CrowdCount : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _currentCrowdAmountText;

    private int _currentCrowdAmountNumber;

    public static CrowdCount Instance { get; private set; }


    void Awake()
    {
        Instance = this;
    }


    public void IncreaseCrowdAmount()
    {
        _currentCrowdAmountText.text = (++_currentCrowdAmountNumber).ToString();
    }


    public void DecreaseCrowdAmount()
    {
        _currentCrowdAmountText.text = (--_currentCrowdAmountNumber).ToString();

        CheckIfAllDied();
    }


    private void CheckIfAllDied()
    {
        if (_currentCrowdAmountNumber <= 0)
        {
            LoseScreen.Instance.GameLost();
        }
    }
}
