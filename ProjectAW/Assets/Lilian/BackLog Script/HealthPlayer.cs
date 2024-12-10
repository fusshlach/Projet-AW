using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

//public class HealthPlayer : MonoBehaviour
//{
//    public float _playerHealth;
//    public Image _healthImpact;

//    // Start is called before the first frame update
//   void Start()
//    {
//       _playerHealth = 100;
//   }

//   private void OnTriggerStay(Collider other)
//    {
//        if (other.gameObject.name == "DamageZone")
//       {
//            PlayerTakingDamage(0.5f);
//        }

//        if (other.gameObject.name == "SafeZone")
//        {
//            PlayerNotTakingDamage(0.5f);
//        }
//    }

//    void HealthDamageImpact()
//    {
//        float transparency = 1f - (_playerHealth / 100);
//        color imageColor = color.white;
//        imageColor.a = transparency;
//        _healthImpact.color = imageColor;
//    }

//    void PlayerTakingDamage(float Damage)
//    {
//        if (_playerHealth > 0)
//        {
//            _playerHealth -= Damage;
//           Debug.Log("Le joueur prend des dommages");
//        }

       
//    }

//    void PlayerNotTakingDamage(float Health)
//    {
//        if (_playerHealth < 100)
//        {
//            _playerHealth += Health;
//            Debug.Log("player is not taking damage");
//       }
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        HealthDamageImpact();
//    }
//}
