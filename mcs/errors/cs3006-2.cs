// cs3006.cs: Overloaded method 'CLSClass.Test(out bool)' differing only in ref or out, or in array rank, is not CLS-compliant
// Line: 11

using System;
[assembly: CLSCompliant(true)]

public abstract class CLSClass {
   public void Test(bool a) {
   }

   public abstract void Test(out bool b);
}
