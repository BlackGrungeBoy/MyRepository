using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SimpleClassConsole {
    public class TravelTimeComparator : IComparer<Airplane> {
        public int Compare([AllowNull] Airplane x, [AllowNull] Airplane y) {
            return (int) x.GetTotalTime() - (int) y.GetTotalTime();
        }
    }
}
