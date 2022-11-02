using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digiteknik {
    
    public class SpillerKontrol : MonoBehaviour
    {
        SceneInputs handlinger;

        private Rigidbody rb;

        Vector2 skub;
        float drej;

        Vector3 eulerRotPlus;  // Euler angles rotation i positiv retning
        Vector3 eulerRotMinus; // Rotation i negativ retning
        Vector3 eulerRot;      // Den faktiske rotation

        // public float bevHast = 10.0f;
        // public float rotHast = 10.0f;
        public float bulletHast = 40.0f;


        public float damage = 10f;
        public float range = 100f;

        public Camera fpsCam;

        public GameObject bulletPrefab;
             
        void Awake()
        {
            handlinger = new SceneInputs();

            handlinger.Gameplay.Skyyyd.performed += ctx => Skyd();
        }

        void OnEnable() {
            handlinger.Gameplay.Enable();
        }

        void OnDisable() {
            handlinger.Gameplay.Disable();
        }


        void Skyd() {
       
            // Lav et projektil fra Bullet Prefab
            Vector3 mundingPos = transform.position + transform.forward * 3;
            var bullet = (GameObject)Instantiate(
                bulletPrefab,
                mundingPos,
                transform.rotation
            );
            Destroy(bullet, 5f);
            // BlinkMedLampe ();

            // Giv projektilet fart
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletHast;
        
            RaycastHit hit;

            if  (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit)) {
             // Debug.Log(hit.transform.name);
            }

            HitMe HitMe = hit.transform.GetComponent<HitMe>();
            if(HitMe != null) {
                HitMe.TakeDamage(damage);
            }
        }
    }
    
}
