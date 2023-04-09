using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
     public Material[] material;
     

    
    private void Update()
    {

        if (trigger.instance._trigger1.isTrigger == true)
        {
            material[0].color = Color.green;
        }
       
        
        if(trigger.instance._trigger2.isTrigger == true)
        {
            material[1].color = Color.green;
        }

        if (trigger.instance._trigger3.isTrigger == true)
        {
            material[2].color = Color.green;
        }
      
        if (trigger.instance._trigger4.isTrigger == true)
        {
            material[3].color = Color.green;
        }





        if (trigger.instance._trigger1.isTrigger == false)
        {
            material[0].color = Color.red;
        }
       
        if(trigger.instance._trigger2.isTrigger == false)
        {
            material[1].color = Color.red;
        }

        if (trigger.instance._trigger3.isTrigger == false)
        {
            material[2].color = Color.red;
        }
       
        if (trigger.instance._trigger4.isTrigger == false)
        {
            material[3].color = Color.red;
        }





    }

}
