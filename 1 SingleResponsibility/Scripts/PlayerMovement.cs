using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    //プレイヤーの移動関連をまとめたクラス
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float positionMultiplier;
        private float yPosition;

       
        private void Update()
        {
            transform.position = new Vector3(transform.position.x, yPosition * positionMultiplier, transform.position.z);
        }
    }
}
