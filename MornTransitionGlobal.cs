using MornGlobal;
using UnityEngine;

namespace MornTransition
{
    [CreateAssetMenu(menuName = "Morn/" + nameof(MornTransitionGlobal), fileName = nameof(MornTransitionGlobal))]
    public sealed class MornTransitionGlobal : MornGlobalBase<MornTransitionGlobal>
    {
        protected override string ModuleName => nameof(MornTransition);
        [SerializeField] private string[] _transitionNames;
        public string[] TransitionNames => _transitionNames;
    }
}