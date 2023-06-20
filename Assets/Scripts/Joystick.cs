using UnityEngine;

public class Joystick : MonoBehaviour
{
   public RectTransform joyStickObj;
   public RectTransform Knob;

   private void Awake()
   {
      joyStickObj = GetComponent<RectTransform>();
   }
}