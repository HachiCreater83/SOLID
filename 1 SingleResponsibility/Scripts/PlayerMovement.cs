using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    //�v���C���[�̈ړ��֘A���܂Ƃ߂��N���X
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
