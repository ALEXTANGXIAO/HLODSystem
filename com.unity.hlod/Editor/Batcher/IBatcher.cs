﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.HLODSystem
{
    public interface IBatcher
    {
        
        void Batch(Vector3 rootPosition, List<HLODBuildInfo> targets, Action<float> onProgress);

    }
}