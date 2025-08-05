using TMPro;
using UnityEngine;

public class EnemyView : CombatantView
{
    [SerializeField] private TMP_Text attackText;
    public int AttackPower { get; set; }
    public void Setup()
    {
        AttackPower = 10;
        UpdateAttackText();
        SetupBase(40, null);
    }
    private void UpdateAttackText()
    {
        attackText.text = "ATK: " + AttackPower;
    }
}
