using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    //RequireComponent�̓X�N���v�g���A�^�b�`���ꂽ�I�u�W�F�N�g�ɑΏۂ̃R���|�[�l���g���Ȃ���Ύ����ŃA�^�b�`���Ă����
    [RequireComponent(typeof(PlayerAudio), typeof(PlayerInput), typeof(PlayerMovement))]
  
    //�v���C���[�S�̂̐���p�̃N���X
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerAudio playerAudio;
        [SerializeField] private PlayerInput playerInput;
        [SerializeField] private PlayerMovement playerMovement;

        private void Start()
        {
            playerAudio = GetComponent<PlayerAudio>();
            playerInput = GetComponent<PlayerInput>();
            playerMovement = GetComponent<PlayerMovement>();
        }
        
    }
}
