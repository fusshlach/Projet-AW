using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int _maxHealth = 3;
    public int _currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        _currentHealth = _maxHealth;
    }

    void TakeDamage(int amount)
    {
        _currentHealth -= amount;

        if(_currentHealth < 0)
        {
            //Le joueur est mort 
            //Placer animation ici
            //Afficher l'écran de Game Over
        }
    }

    void Heal(int amount)
    {
        _currentHealth += amount;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
}
