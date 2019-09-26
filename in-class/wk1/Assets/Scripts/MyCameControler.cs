using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameControler : MonoBehaviour
{
   public bool axeRestored = false;
   public bool goodRed = false;
   public bool goodBlack = false;
   public bool badRed = false;
   public bool badBlack = false;
   public bool chickenRestored = false;

   public GameObject finishText;

   public void checkForVictory(){
       if(axeRestored && goodBlack && goodRed && badBlack && badRed && chickenRestored) {
        finishText.SetActive(true);
       }
   }

   public void axeWasRest(){
       this.axeRestored = true;
       checkForVictory();
   }
   public void goodredClip(){
       this.goodRed = true;
       checkForVictory();
   }
   public void goodBlackClip(){
       this.goodBlack = true;
       checkForVictory();
   }
   public void badRedClip(){
       this.badRed = true;
       checkForVictory();
   }
   public void badBlackClip(){
       this.badBlack = true;
       checkForVictory();
   }
   public void chickenWasRest(){
       this.chickenRestored = true;
       checkForVictory();
   }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
