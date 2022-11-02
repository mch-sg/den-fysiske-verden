using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // TextMeshPro pakken - giver mange flere muligheder for at shine teksterne op

namespace Digiteknik {
    public class GameControl : MonoBehaviour
    {
        // TextMeshPro objektet skal lægges ind
        public TextMeshProUGUI pointTekst;

        public TextMeshProUGUI tidTekst;
        public TextMeshProUGUI sceneTekst;

        public GameObject spawnPrefab;

        public int score = 1;
        public int tid = 30; // 30
        public int vind = 4;
        
        private LysSkifter scriptf;
        

        // Start is called before the first frame update
        void Start()
        {
            sceneTekst.enabled = false;
            pointTekst.text = "Score: " + score;

            scriptf = FindObjectOfType<LysSkifter>();

            //Coroutines er metoder som kan håndtere tid - som du ser nedenfor i metoden showStart venter metoden et par sekunder med WaitForSeconds()
            StartCoroutine (showStart("Bane"));
            StartCoroutine (showTime());

            // TÆNDER LAMPEN I BEGYNDELSEN
            StartCoroutine(scriptf.SkiftOnOff(1, 254, 254, 254));

        }


        //Viser resterende antal sekunder (= health)
        IEnumerator showTime(){
            while (tid >= 0) {
                tidTekst.text = tid.ToString() + " sek";
                yield return new WaitForSeconds (1);
                tid--;
            }
            if(tid <= 0 && score <= 4) { AfslutSpil(); }

        }

        void AfslutSpil(){
            StartCoroutine (showEnd("Din TABER!"));
            // StartCoroutine(scriptf.SkiftOnOff(0, 254, 254, 254));
            StartCoroutine(scriptf.SkiftOnOff(1, 0, 0, 0));
        }

        void VindSpil(){
            StartCoroutine(scriptf.SkiftOnOff(1, 1, 1, 1));
            StartCoroutine (showEnd("VUNDET!!!"));
        }

        public void AddScore(int s) {
            score += s;
            pointTekst.text = "Score: " + score;
            print ("Score er nu: " + score);
            StartCoroutine(SpawnKegle(2.0f));
            if(score == vind) { VindSpil(); };
        }

        //Viser introtekst i et antal sekunder
        IEnumerator showStart(string t){
            sceneTekst.text = t;
            sceneTekst.enabled = true;
            yield return new WaitForSeconds (2);
            sceneTekst.enabled = false;
        }

        //Viser sluttekst i et antal sekunder
        IEnumerator showEnd(string t){
            sceneTekst.text = t;
            sceneTekst.enabled = true;
            yield return new WaitForSeconds (4);
            /*sceneTekst.enabled = false;
            print ("Skifter scene");
            Scene thisScene = SceneManager.GetActiveScene();
            Debug.Log("Active Scene is '" + thisScene.name + "'.");
            SceneManager.LoadScene(1);*/
        }

        public IEnumerator SpawnKegle(float tid) {
            // vent den angivne tid
            yield return new WaitForSeconds(1);        
            
            // bestem et nyt sted at spawne en kegle (spawnPrefab)
            // bestem den nye kegles pointværdi?
            // instantier en ny kegle det sted på banen

            // sæt den nye kegles pointværdi?

            var spawnkegle = (GameObject)Instantiate(
                spawnPrefab,
                new Vector3(Random.Range(-45f,45f), 5f, Random.Range(-45f,45f)),
                transform.rotation
            );

            // spawnkegle.GetComponent<HitMe>().pointValue = 1;
        }
    }

}
