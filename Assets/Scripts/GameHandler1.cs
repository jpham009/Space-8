//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameHandler : MonoBehaviour
//{
//    // Start is called before the first frame update
//    [SerializeField] private HealthBar healthbar; 
//    private void Start()
//    {
//        float health = 1f; 

//        FunctionPeriodic.Create(() =>
//        {
//            if (health > .01f)
//            {
//                health -= .01f;
//                healthBar.SetSize(health);

//                if(health < .3f) //Under 30% health
//                {
//                    if (health * 100f % 3 == 0)
//                    {
//                        healthbar.SetColor(Color.white);
//                    }
//                    else
//                    {
//                        healthbar.SetColor(Color.white);
//                    }
                    
//                }
//            }
//        }, .03f);
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
