//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Manager_Player : MonoBehaviour
{
    public Image damageScreen;
    public Slider healthBar;
    public int life = 10;
    int maxLife;
    Color alphacolor;

    

    // Start is called before the first frame update
    void Start()
    {
        maxLife = life;
        healthBar.maxValue = maxLife;
        alphacolor = damageScreen.color;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = life;

        if(Input.GetKeyDown(KeyCode.U))
            TakeDamage();
        else if(Input.GetKeyDown(KeyCode.I))
            HealDamage();
    }

    //method to take damage
    private void TakeDamage()
    {
        if (life > 0)
            life--;

        alphacolor.a += .1f;
        damageScreen.color = alphacolor;
    }

    //Method to heal
    private void HealDamage()
    {
        if (life < maxLife)
        life++;

        alphacolor.a -= .1f;
        damageScreen.color = alphacolor;
    }
}
