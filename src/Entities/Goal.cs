// SPDX-License-Identifier: LGPL-3.0-or-later
// Copyright (C) 2021 SOSIEL Inc. All rights reserved.

using System;

using SOSIEL.Enums;

namespace SOSIEL.Entities
{
    public class Goal : IEquatable<Goal>
    {
        public string Name { get; set; }

        public GoalTendency Tendency { get; set; }

        public string ReferenceVariable { get; set; }

        public bool ChangeFocalValueOnPrevious { get; set; }

        public double ReductionPercent { get; set; }

        public string FocalValueReferenceVariable { get; set; }

        public bool RankingEnabled { get; set; }

        public bool IsCumulative { get; set; }

        public Goal()
        {
            RankingEnabled = true;
        }

        /// <summary>
        /// Compares two Goal objects
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Goal other)
        {
            return ReferenceEquals(this, other) || (other != null && Name == other.Name);
        }

        public override bool Equals(object obj)
        {
            //check on equality by object reference or goal name
            return base.Equals(obj) || Equals(obj as Goal);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public static bool operator ==(Goal a, Goal b)
        {
            return ReferenceEquals(a, b)
                ? true
                : ((object)a == null || (object)b == null ? false : a.Equals(b));
        }

        public static bool operator !=(Goal a, Goal b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
