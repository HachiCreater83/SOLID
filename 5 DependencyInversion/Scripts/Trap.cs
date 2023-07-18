using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.DIP
{
    //�X�C�b�`�ŋN������g���b�v�N���X
    public class Trap : MonoBehaviour, ISwitchable
    {
        private bool isActive;
        public bool IsActive => isActive;

        public void Activate()
        {
            isActive = true;
            Debug.Log("The trap is active.");
        }

        public void Deactivate()
        {
            isActive = false;
            Debug.Log("The trap is inactive.");
        }
    }
}
