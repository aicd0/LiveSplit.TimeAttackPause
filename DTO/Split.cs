// Copyright (c) aicd0. All rights reserved.
// Licensed under the MIT License.

using System;

namespace LiveSplit.TimeAttackPause.DTO;

public record Split
{
    public TimeSpan? Time { get; set; }
    public string? Name { get; set; }
}