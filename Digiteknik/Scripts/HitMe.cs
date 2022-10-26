using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digiteknik {
	public class HitMe : MonoBehaviour {

        public GameObject explosionprefab;

        public int pointValue = 1;

        private GameControl script;
        private LysSkifter scriptf;

        

        void Start(){
            script = FindObjectOfType<GameControl>();
            scriptf = FindObjectOfType<LysSkifter>();

            // int randomNumber = Random.Range(0, 254);

            //  StartCoroutine(scriptf.SkiftOnOff(0, 254, 254, 254));
        }

        void OnCollisionEnter(Collision other){
            print ("hit: " + other.gameObject.tag);
            if (other.gameObject.CompareTag ("Player")) {
                // print ("farvetjek");
                int randomNumber = Random.Range(0, 1);
                StartCoroutine(scriptf.SkiftOnOff(1, randomNumber, 254, 254)); // 1,254,254,254
                Explode();
            }
        }

        void Explode(){
            // print ("AAARGHHH! - Jeg døøør, siger keglen");
            
            var ildkugle = (GameObject)Instantiate(
                explosionprefab,
                transform.position,
                transform.rotation
            );

            Destroy(gameObject);
            script.AddScore(pointValue);

        }

    }
}



/*
OPGAVER 
OPRET EN PREFAB DU KAN RAMME (fx din kegle)
- - - - - - - -
Vi har nu en bane vi kan trille på og nogle kegler vi kan ramme! 
I disse opgaver gennemgår vi hvordan man laver keglen til et target 
- giver det et script som kan forstå det bliver ramt, affyrer en eksplosion,
tæller et point og gør andre fornuftige ting for ting der bliver plaffet ned.

Find din kegle. Tilføj dette script (HitMe.cs) til din kegle
Gem den som en prefab og kald den Kegle eller lignende, hvis ikke du allerede
har gjort det. Hvis keglen allerede er en prefab, så skal du åbne prefab'en 
og lægge scriptet ind der, ellers ligger det ikke på dem alle


*/