using UnityEngine;
using UnityEngine.UI;

namespace DI
{
    public class AttackDI : MonoBehaviour
    {
        [SerializeField] private Button baseAtkButton;
        [SerializeField] private Button specialAtkButton;
        [SerializeField] private Button magicAtkButton;
        
        [SerializeField] private BaseAttack baseAttack;
        [SerializeField] private SpecialAttack specialAttack;
        [SerializeField] private MagicAttack magicAttack;
        [SerializeField] private Player player;
        void Start()
        {
            baseAtkButton.onClick.AddListener(() =>
            {
                player.SetAttackType(baseAttack);
                player.Attack();
            });
            specialAtkButton.onClick.AddListener(() =>
            {
                player.SetAttackType(specialAttack);
                player.Attack();
            });
            magicAtkButton.onClick.AddListener(() =>
            {
                player.SetAttackType(magicAttack);
                player.Attack();
            });
        }
        
        
    }
}
