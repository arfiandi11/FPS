using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
	{
   public static int score;
   Text ScoreText;
   Text AmmoText;
	  
	 
	   // Update is called once per frame
       void Start(){
           ScoreText = GameObject.Find ("Score").GetComponent<Text>();
           AmmoText = GameObject.Find ("Ammo").GetComponent<Text>();
       }
	   void Update()
    {
      
        ScoreText.text = "Score : " + score;
        AmmoText.text = WeaponController.ammo + "/" + WeaponController.ammoMag;
    }
	  
	   public void ResetScore()
    {
       score = 0;
    }

}
