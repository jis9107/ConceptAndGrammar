using UnityEngine;

namespace DI
{
    public class Player : MonoBehaviour
    {
        private IAttackType attackType;

        public void SetAttackType(IAttackType _attackType)
        {
            attackType = _attackType;
        }

        public void Attack()
        {
            attackType.Attack();
        }
    }
}

