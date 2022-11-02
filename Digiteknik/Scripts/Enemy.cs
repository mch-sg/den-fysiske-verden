// using UnityEngine;

// public class Enemy : MonoBehaviour
// {
//     public float health = 50f;

//     public GameObject explosionprefab;


//     public int pointValue = 1;

//     // private GameControl script;
//     // private LysSkifter scriptf;

        
//     // void Start(){
//     //     script = FindObjectOfType<GameControl>();
//     //     scriptf = FindObjectOfType<LysSkifter>();
//     // }

//     public void TakeDamage(float amount) {

//         health -= amount;

//         if(health <= 0f) {
//             Die();
//         }
//     }

//     void Die() {
//             var ildkugle = (GameObject)Instantiate(
//                 explosionprefab,
//                 transform.position,
//                 transform.rotation
//             );

//             Destroy(gameObject);
//             // script.AddScore(pointValue);
        
//     }
// }
