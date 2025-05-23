using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public TMP_Text hpText;
    

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHPText();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            TakeDamage(20);
        }
        if (collision.collider.CompareTag("Skeleton"))
        {
            TakeDamage(40);
        }
        if (collision.collider.CompareTag("FallWorld"))
        {
            TakeDamage(100);
        }
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;

        UpdateHPText();

        if (currentHealth == 0)
        {
            Debug.Log("Player Died");
            SceneManager.LoadScene("GameOverScene");
            
        }
    }

    void UpdateHPText()
    {
        hpText.text = "HP: " + currentHealth;
    }
}