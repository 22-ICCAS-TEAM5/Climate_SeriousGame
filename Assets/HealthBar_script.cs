using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar_script : MonoBehaviour
{
    private Image HealthBar;
    public float currentHealth;
    private float MaxHealth = 100f;
    PlayerController Player;
    Animator animator;

    private void Start()
    {
        //Find
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerController>();

    }

    private void Update()
    {
        currentHealth = Player.Health;
        HealthBar.fillAmount = currentHealth / MaxHealth;
        if (currentHealth <= 0)
        {

            animator.SetTrigger("die");

            SceneManager.LoadScene("GameOverScene");
        }
    }
    
}
