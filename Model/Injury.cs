using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PCKSystem.Model
{
    ///<Summary>
    ///Specifies the injury to the body
    ///</Summary>
    public enum Injury
    {
        [Description("Złamanie otwarte")]
        O,
        [Description("Złamanie zamniknięte")]
        Z,
        [Description("Zwichnięcie")]
        W,
        [Description("Stłuczenie")]
        S,
        [Description("Rana")]
        R,
        [Description("Krwotok z rany")]
        K,
        [Description("Zmiażdżenie")]
        M,
        [Description("Amputacja")]
        A,
        [Description("Ból nieurazowy")]
        N,
        [Description("Oparzenie")]
        P,
        [Description("----")]
        D
    }
}
