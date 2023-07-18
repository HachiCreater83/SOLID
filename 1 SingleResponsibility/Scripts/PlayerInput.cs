using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    //�v���C���[�̓��͊֘A���܂Ƃ߂��N���X
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
