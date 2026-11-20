using UnityEngine;
using UnityEngine.InputSystem;

public class Contollers : MonoBehaviour

{
public InputActionAsset amandasPlayerAction;
public Animator amandasAnimator;

void Update()
{
  if (amandasPlayerAction.FindAction("Move").IsPressed())
  {
    amandasAnimator.SetBool("walk", true);
  }
  else amandasAnimator.SetBool("walk", false);
}

}
