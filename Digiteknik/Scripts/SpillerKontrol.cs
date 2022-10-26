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

        public float bevHast = 10.0f;
        public float rotHast = 10.0f;
        public float bulletHast = 40.0f;

        public GameObject bulletPrefab;
             
        void Awake()
        {
            handlinger = new SceneInputs();

            handlinger.Gameplay.Skyyyd.performed += ctx => Skyd();

            handlinger.Gameplay.FlytSpiller.performed += ctx => skub = ctx.ReadValue<Vector2>();
            handlinger.Gameplay.FlytSpiller.canceled += ctx => skub = Vector2.zero;

            handlinger.Gameplay.RoterSpiller.performed += ctx => drej = ctx.ReadValue<float>();
            handlinger.Gameplay.RoterSpiller.canceled += ctx => drej = 0;
        }

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            eulerRotPlus = new Vector3(0, rotHast, 0);
            eulerRotMinus = new Vector3(0, -rotHast, 0);
            eulerRot = eulerRotPlus;
        }

        void OnEnable() {
            handlinger.Gameplay.Enable();
        }

        void OnDisable() {
            handlinger.Gameplay.Disable();
        }

        // Update is called once per frame
        void Update()
        {
            // JumpAndGravity();
			// GroundedCheck();
			Flyt();
            Drej();
		}
        
        void Flyt() {
                if (skub != Vector2.zero) {
                    rb.velocity = transform.forward * skub.y * bevHast + transform.right * skub.x * bevHast;
                }
                else {
                    rb.velocity = Vector3.zero;
                }           
        }

        void Drej() {            
                if (drej != 0) {
                    eulerRot = drej > 0 ? eulerRotPlus : eulerRotMinus;
                    transform.Rotate(eulerRot, Space.World);
                }            
        }

        void Skyd() {
            // Lav et projektil fra Bullet Prefab
            Vector3 mundingPos = transform.position + transform.forward * 3;
            var bullet = (GameObject)Instantiate(
                bulletPrefab,
                mundingPos,
                transform.rotation
            );
            // BlinkMedLampe ();

            // Giv projektilet fart
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletHast;
        
        }

    }
}
