using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    // Even though this class is short, it violates single-responsibility.
    // Too many things will cause the class to update, and extending the class will be more difficult.

    public class UnrefactoredPlayer : MonoBehaviour
    {
        //入力軸の名前
        [SerializeField] private string _inputAxisName;

        //座標関連
        [SerializeField] private float _positionMultiplier;
        private float _yPosition;

        //サウンド関連
        private AudioSource _bounceSfx;

        private void Start()
        {
            _bounceSfx = GetComponent<AudioSource>();
        }

        private void Update()
        {
            //入力を受け取って位置を変更する
            float delta = Input.GetAxis(_inputAxisName) * Time.deltaTime;
            _yPosition = Mathf.Clamp(_yPosition + delta, -1, 1);
            transform.position = new Vector3(transform.position.x, _yPosition * _positionMultiplier, transform.position.z);
        }

        private void OnTriggerEnter(Collider other)
        {
            //何かに当たったら音を鳴らす
            _bounceSfx.Play();
        }
    }
}
