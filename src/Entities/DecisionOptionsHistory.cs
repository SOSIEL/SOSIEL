// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (C) 2021 SOSIEL Inc. All rights reserved.

using System.Collections.Generic;

namespace SOSIEL.Entities
{
    public class DecisionOptionsHistory
    {
        public List<DecisionOption> Matched { get; private set; }
        public List<DecisionOption> Activated { get; private set; }
        public List<DecisionOption> Blocked { get; private set; }

        public DecisionOptionsHistory()
        {
            Matched = new List<DecisionOption>();
            Activated = new List<DecisionOption>();
            Blocked = new List<DecisionOption>();
        }

        public DecisionOptionsHistory(
            IEnumerable<DecisionOption> matched,
            IEnumerable<DecisionOption> activated,
            IEnumerable<DecisionOption> blocked = null
        ) : this()
        {
            Matched.AddRange(matched);
            Activated.AddRange(activated);
            if (blocked != null) Blocked.AddRange(blocked);
        }

        public DecisionOptionsHistory CreateCopy()
        {
            return new DecisionOptionsHistory(Matched, Activated, Blocked);
        }
    }
}
