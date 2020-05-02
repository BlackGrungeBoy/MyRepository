using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SimpleClassConsole {
    class StartDateComparator : IComparer<Airplane> {
        public int Compare([AllowNull] Airplane x, [AllowNull] Airplane y) {
            return (int) y.GetStartDate().ToDateTime().Subtract(x.GetStartDate().ToDateTime()).TotalMinutes;
        }
    }
}
