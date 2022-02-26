using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SelectData
{
    public class RaceStart : MonoBehaviour
    {
        private MyGameManagerData myGameManagerData;

        private void Start()
        {
            myGameManagerData = FindObjectOfType<MyGameManager>().GetMyGameManagerData();

            //ここを生成から呼び出しに変える
            Instantiate(myGameManagerData.GetCharacter(), Vector3.zero, Quaternion.identity);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}