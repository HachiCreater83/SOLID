using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    //�v���C���[�̃T�E���h�֘A�̋@�\���܂Ƃ߂��N���X
    public class PlayerAudio : MonoBehaviour
    {

        private AudioSource bounceSfx;

        private void Start()
        {
            bounceSfx = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter(Collider other)
        {
            //�����ɓ��������特��炷
            bounceSfx.Play();
        }
    }
}
