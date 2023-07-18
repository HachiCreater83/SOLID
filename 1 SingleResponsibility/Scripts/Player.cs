using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    //RequireComponentはスクリプトがアタッチされたオブジェクトに対象のコンポーネントがなければ自動でアタッチしてくれる
    [RequireComponent(typeof(PlayerAudio), typeof(PlayerInput), typeof(PlayerMovement))]
  
    //プレイヤー全体の制御用のクラス
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
