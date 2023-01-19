using System.Collections.Generic;
using Sirenix.OdinInspector;

namespace Cooking.Editor.LevelsData
{
    public class Sweetness
    {
        [ValueDropdown("GetSweetnessNames")] public string name;

        private IEnumerable<string> GetSweetnessNames() => new List<string>() {
            "Tort1", "Tort2", "Tort3", "Tort4"
        };
    }
}