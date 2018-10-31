using System;
using System.Collections.Generic;
using System.Text;

namespace InfernoInfinity
{
    public interface IGem
    {
        GemClarity Clarity { get; }

        int AgilityBonus { get; }

        int StrengthBonus { get; }

        int VitalityBonus { get; }
    }
}
