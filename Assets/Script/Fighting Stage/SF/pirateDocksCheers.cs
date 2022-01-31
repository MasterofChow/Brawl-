// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class pirateDocksCheers : MonoBehaviour
// {
//     private AudioSource source;
//     public AudioClip hooray;
//     public AudioClip letsGo;
//     private int timeDelay;
//     private int chosenSF;
//     // Start is called before the first frame update
//     void Start()
//     {
//         source.clip = letsGo;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         StartCoroutine(pirateSF());
//     }
    
//     IEnumerator pirateSF()
//     {
//         timeDelay = Random.Range(10, 30);
//         chosenSF = Random.Range(0, 2);
//         if (chosenSF == 1)
//         {
//             source.clip = letsGo;
//         }
//         else 
//         {
//             source.clip = hooray;
//         }
//         yield return new WaitForSeconds(timeDelay);
//         source.Play();
//     }
// }
