using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    private HealthSystem _healthSystem;

    private int maxHealth;
    private int health;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Awake()
    {
        _healthSystem = GetComponent<HealthSystem>();
    }

    void Start()
    {
        maxHealth = _healthSystem.GetMaxHealth();
        health = _healthSystem.GetHealth();
    }

    /*void Update()
    {
        //maxHealth = _healthSystem.GetMaxHealth();
        //health = _healthSystem.GetHealth();

        Debug.Log("Vida: " + health); // no le da tiempo a que le llegue el 0, muere antes

        if (health > maxHealth)
            health = maxHealth;

        for (int i = 0; i < hearts.Length; i++)
        {
            // Para vaciar los corazones
            if (i < health)
                hearts[i].sprite = fullHeart;
            else
                hearts[i].sprite = emptyHeart;

            // Para ampliar o reducir la vida máxima
            if (i < maxHealth)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
        }
    }*/

    private void UpdateHealth(int _health)
    {
        if (_health > maxHealth)
            _health = maxHealth;

        for (int i = 0; i < hearts.Length; i++)
        {
            // Para vaciar los corazones
            if (i < _health)
                hearts[i].sprite = fullHeart;
            else
                hearts[i].sprite = emptyHeart;
        }
    }
    private void UpdateMaxHealth(int _maxHealth)
    {
        if (health > _maxHealth)
            health = _maxHealth;

        for (int i = 0; i < hearts.Length; i++)
        {
            // Para ampliar o reducir la vida máxima
            if (i < _maxHealth)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
        }
    }

    void OnEnable()
    {
        GetComponent<HealthSystem>().LifeUpdated += UpdateHealth;
        GetComponent<HealthSystem>().MaxLifeUpdated += UpdateMaxHealth;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().LifeUpdated -= UpdateHealth;
        GetComponent<HealthSystem>().MaxLifeUpdated -= UpdateMaxHealth;
    }
}