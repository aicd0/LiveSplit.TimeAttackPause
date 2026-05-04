// Copyright (c) aicd0. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;

using LiveSplit.Model;

using Newtonsoft.Json;

using Run = LiveSplit.TimeAttackPause.DTO.Run;

namespace LiveSplit.TimeAttackPause.IO;

public static class SplitStateImporter
{
    public static void ImportState(string filepath, LiveSplitState state, ITimerModel timerModel)
    {
        // read all the text from the file as string
        string jsonString = File.ReadAllText(filepath);
        Run? runDto = JsonConvert.DeserializeObject<Run>(jsonString);
        if (runDto == null)
        {
            return;
        }

        timerModel.Start();

        int i = 0;
        foreach (ISegment? segment in state.Run)
        {
            segment.SplitTime = new Time(runDto.TimingMethod, runDto.Splits[i].Time);
            i += 1;
        }

        state.CurrentSplitIndex = runDto.CurrentSplitIndex;
        state.AdjustedStartTime = TimeStamp.Now - runDto.CurrentTime.GetValueOrDefault(TimeSpan.Zero);
        state.IsGameTimeInitialized = true;
        timerModel.Pause();
    }
}