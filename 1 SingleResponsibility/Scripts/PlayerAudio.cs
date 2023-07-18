using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    //プレイヤーのサウンド関連の機能をまとめたクラス
    public class PlayerAudio : MonoBehaviour
    {

        private AudioSource bounceSfx;

        private void Start()
        {
            bounceSfx = GetComponent<AudioSource>();
        }

        private void OnTriggerEnter(Collider other)
        {
            //何かに当たったら音を鳴らす
            bounceSfx.Play();
        }
    }
}
