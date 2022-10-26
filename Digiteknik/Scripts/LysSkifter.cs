using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


namespace Digiteknik {
    public class LysSkifter : MonoBehaviour
    {

        private GameControl script;

        // Random rd = new Random();
        // int raNum = Range.Random(0f,40000f);
        
        void Start(){
            script = FindObjectOfType<GameControl>();
        }
        // Lampe ID kan skiftes fra Unity Editor
        public string lampeID = "23"; 
        // Hue adresse og brugerID skal skiftes her i koden
        private string hueURL = "http://192.168.50.206/api/"; // Husk at være på Digitek-netværket
        private string brugerID ="HHghRbgPFj7vJj1jpv-dkrSnfLvcNebF1-Js7kcS"; // Indsæt din egen brugernøgle

        public IEnumerator SkiftOnOff(int skiftType, int hueT, int briT, int satT) {
            string webURLString = hueURL + brugerID + "/lights/" + lampeID + "/state";

            // on state
            string dataString = "{\"on\":";
            if (skiftType == 0) {dataString += "false,";}
            else {dataString += "true,";}

            // farve skift
            string hueString = " \"hue\":";
            if (hueT == 254) {hueString += "254,";} // 254: rød // hueString += "254,";
            else if(hueT == 1) {hueString += "21845,";} // hvis man har vundet, skal den vise grøn (1 = vundet)
            else if(hueT == 0) {hueString += "1000,";} // hvis man har tabt, skal den vise rød (0 = tabt)
            else {hueString += "10423,";}

            // brightness skift
            string briString = " \"bri\":";
            if (briT == 254) {briString += "254,";} // 254: rød
            else if(briT == 1) {briString += "254,";} // hvis man har vundet, skal den vise grøn (1 = vundet)
            else if(briT == 0) {briString += "255,";} // hvis man har tabt, skal den vise rød (0 = tabt)
            else {briString += "21845,";}

            // saturation skift
            string satString = " \"sat\":";
            if (satT == 254) {satString += "175 }";} // 254: rød
            else if(satT == 1) {satString += "175 }";} // hvis man har vundet, skal den vise grøn (1 = vundet)
            else if(satT == 0) {satString += "255 }";} // hvis man har tabt, skal den vise rød (0 = tabt)
            else {satString += "21845 }";}


            Debug.Log(lampeID + ", " + webURLString + ", " + dataString + hueString + briString + satString);
            byte[] myData = System.Text.Encoding.UTF8.GetBytes(dataString + hueString + briString + satString);
            using (UnityWebRequest www = UnityWebRequest.Put(webURLString, myData))
            {
                yield return www.SendWebRequest();

                if (www.result != UnityWebRequest.Result.Success)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("Pære nr. " + lampeID + " har nu skiftet til " + dataString + hueString + briString);
                }
            }            
        }


        
    }
}



// "23": {
// 		"state": {
// 			"on": true,
// 			"bri": 254,
// 			"hue": 34,
// 			"sat": 254,
// 			"effect": "none",
// 			"xy": [
// 				0.6949,
// 				0.3013
// 			],
// 			"ct": 555,
// 			"alert": "select",
// 			"colormode": "hs",
// 			"mode": "homeautomation",
// 			"reachable": true