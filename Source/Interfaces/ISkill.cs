﻿using Entropy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurnItUp.Locations;
using TurnItUp.Skills;

namespace TurnItUp.Interfaces
{
    public interface ISkill
    {
        TargetMap CalculateTargetMap(Board board);
    }
}
