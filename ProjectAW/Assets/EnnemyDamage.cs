//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EnnemyDamage : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }

//    private void OnTriggerEnter(Collider collision)
//    {
//        if (Collision.tag == "Enemy")
//        {
//            gameObject.transform.parent = collision.gameObject.transform;
//            Destroy(Rigidbody);
//            GetComponent<BoxCollider>().enabled = false;
//        }

//        if (Collision.tag == "Player")
//        {
//            var healthComponent = collision.GetComponent<Health>();
//            if (healthComponent != null )
//            {
//                healthComponent.TakeDamage(1);
//            }
//        }
//    }

//}
