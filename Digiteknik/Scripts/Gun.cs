// using UnityEngine;

// namespace Digiteknik {
// public class Gun : MonoBehaviour
// {
//     public float damage = 10f;
//     public float range = 100f;
//     public float impactForce = 30f;

//     public Camera fpsCam;
//     // public GameObject impactEffect;

//     // private HitMe script;

//     // void Start(){
//     //     script = FindObjectOfType<HitMe>();
//     // }

//     // Update is called once per frame
//     void Update()
//     {
        
//         if (Input.GetButtonDown("Fire1")) {
//             Shoot();
//         }
//     }

//     void Shoot() {
//         RaycastHit hit;

//        if  (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {
//         Debug.Log(hit.transform.name);

//         HitMe HitMe = hit.transform.GetComponent<HitMe>();
//         if(HitMe != null) {
//             HitMe.TakeDamage(damage);
//         }

//         if (hit.rigidbody != null) {
//             hit.rigidbody.AddForce(-hit.normal * impactForce);
//         }

//         // GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
//         // Destroy(impactGO, 2f);
//        }
//     }
// }

// }