﻿// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using System.ComponentModel.DataAnnotations;

namespace MyFabulousCreatures.Models;

public record Creature(string Type, [Range(1, 3)] int Age = 0);