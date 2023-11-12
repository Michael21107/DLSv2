﻿using System;
using DLSv2.Core;

namespace DLSv2.Conditions
{
    internal class AudioModeActive : VehicleCondition
    {
        string audioMode;

        public override void Init(ManagedVehicle managedVehicle, string args)
        {
            base.Init(managedVehicle, args);

            if (!managedVehicle.AudioModes.ContainsKey(args))
            {
                throw new ArgumentException("Audio Mode must exist");
            }
            else
                audioMode = args;
        }

        public override bool Evaluate() => MV.ActiveAudioModes.Contains(audioMode);
    }
}