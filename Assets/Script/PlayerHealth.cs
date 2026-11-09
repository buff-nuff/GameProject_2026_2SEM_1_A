using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int MaxHealth = 100;
    [SerializeField] private int StartingHealth = 50;
    [SerializeField] private TextMeshProUGUI healthText;
    private int currentHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, MaxHealth);
        UpdateHealthText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > MaxHealth)
        {
            currentHealth = MaxHealth;
        }

        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        healthText.text = "HP " + currentHealth + "/" + MaxHealth;
    }
}
