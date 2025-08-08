using SerializeReferenceEditor;
using UnityEditor.Rendering;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Perk")]
public class NewMonoBehaviourScript : ScriptableObject
{
    [field: SerializeField] public Sprite Image { get; private set; }
    [field: SerializeReference, SR] public PerkCondition PerkCondition { get; private set; }
    [field: SerializeReference, SR] public AutoTargetEffect AutoTargetEffect { get; private set; }
    [field: SerializeField] public bool UseAutoTarget { get; private set; } = true;
    [field: SerializeField] public bool UseActionCasterAsTarget { get; private set; } = false;
}
