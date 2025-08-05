using TMPro;
using UnityEngine;

public class CombatantView : MonoBehaviour
{
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private SpriteRenderer spriteRenderer;
    public int MaxHealth { get; private set; }
    public int CurrentHealth { get; private set; }
    protected void SetupBase(int health, Sprite Image)
    {
        MaxHealth = CurrentHealth = health;
        spriteRenderer.sprite = Image;
        UpdateHealthText();
    }
    private void UpdateHealthText()
    {
        healthText.text = "HP: " + CurrentHealth;
    }
}
