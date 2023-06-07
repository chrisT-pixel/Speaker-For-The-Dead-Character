using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkingAnimation : MonoBehaviour{

  Animator animator;
  int randomNumber;

  void Start(){
    animator = GetComponent<Animator>();
  }

  public void PlayCharacterThinking(){

      //random number can be 1 or 2
      randomNumber = UnityEngine.Random.Range(1, 3);
      animator.SetBool("isIdle", false);

      if(randomNumber < 2){
        animator.SetBool("isThinking", true);
      }

      else{
        animator.SetBool("isThinkingHeadShake", true);
      }

  }

  public void PlayCharacterIdle(){

      animator.SetBool("isWaving", false);
      animator.SetBool("isTalking", false);
      animator.SetBool("isTalkingArmMovements", false);
      animator.SetBool("isIdle", true);

  }

  public void PlayCharacterWaving(){

      animator.SetBool("isIdle", false);
      animator.SetBool("isWaving", true);

  }

  public void PlayCharacterTalking(){

      //random number can be 1 or 2
      randomNumber = UnityEngine.Random.Range(1, 3);
      animator.SetBool("isThinking", false);
      animator.SetBool("isThinkingHeadShake", false);

      if(randomNumber < 2){
        animator.SetBool("isTalking", true);
      }

      else{
        animator.SetBool("isTalkingArmMovements", true);
      }

  }

}
