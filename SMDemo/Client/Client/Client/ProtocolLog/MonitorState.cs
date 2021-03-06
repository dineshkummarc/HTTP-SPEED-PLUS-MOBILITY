﻿//-----------------------------------------------------------------------
// <copyright file="MonitorState.cs" company="Microsoft Open Technologies, Inc.">
//
// Copyright 2012 Microsoft Open Technologies, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace Client.Benchmark
{
    /// <summary>
    /// Protocol monitor states.
    /// </summary>
    public enum MonitorState
    {
        /// <summary>
        /// Protocol Monitor is active.
        /// </summary>
        MonitorOn,

        /// <summary>
        /// Protocol Monitor is inactive.
        /// </summary>
        MonitorOff,

        /// <summary>
        /// Protocol Monitor statistics are reset.
        /// </summary>
        MonitorReset,

        /// <summary>
        /// Protocol Monitor is in error state.
        /// </summary>
        MonitorError
    }
}
