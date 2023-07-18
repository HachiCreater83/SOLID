using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.SRP
{
    // Even though this class is short, it violates single-responsibility.
    // Too many things will cause the class to update, and extending the class will be more difficult.

    public class UnrefactoredPlayer : MonoBehaviour
    {
        //���͎��̖��O
        [SerializeField] private string _inputAxisName;

        //���W�֘A
        [SerializeField] private float _positionMultiplier;
        private float _yPosition;

        //�T�E���h�֘A
        private AudioSource _bounceSfx;

        private void Start()
        {
            _bounceSfx = GetComponent<AudioSource>();
        }

        private void Update()
        {
            //���͂��󂯎���Ĉʒu��ύX����
            float delta = Input.GetAxis(_inputAxisName) * Time.deltaTime;
            _yPosition = Mathf.Clamp(_yPosition + delta, -1, 1);
            transform.position = new Vector3(transform.position.x, _yPosition * _positionMultiplier, transform.position.z);
        }

        private void OnTriggerEnter(Collider other)
        {
            //�����ɓ��������特��炷
            _bounceSfx.Play();
        }
    }
}
