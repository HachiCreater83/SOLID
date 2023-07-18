using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    //プレイヤーの入力関連をまとめたクラス
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private string inputAxisName;
        public float Delta { get; private set; }

        private void Update()
        {
            Delta = Input.GetAxis(inputAxisName) * Time.deltaTime;
        }
    }
}
