using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NoiseFilterFactory 
{
    public static INoiseFilter CreateNoiseFiler(NoiseSettings settings) 
    {
        switch (settings.filterType) 
        {
            case NoiseSettings.FilterType.Simple:
                return new SimpleNoiseFilter(settings.simpleNoiseSettings);
            case NoiseSettings.FilterType.Rigid:
                return new RigidNoiseFilter(settings.rigidNoiseSettings);
        }
        return null;
    }
}
