using System.Runtime;
using System.Runtime.InteropServices;
using NBitcoin.Secp256k1;


namespace Library.Native;

// dotnet publish /p:NativeLib=Static -c Release -r linux-x64 --self-contained

public static class NativeInterface
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FE_ 
    {
        public readonly uint n0, n1, n2, n3, n4, n5, n6, n7, n8, n9;

        public FE_(uint n0, uint n1, uint n2, uint n3, uint n4, uint n5, uint n6, uint n7, uint n8, uint n9)
        {
            this.n0 = n0;
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
            this.n4 = n4;
            this.n5 = n5;
            this.n6 = n6;
            this.n7 = n7;
            this.n8 = n8;
            this.n9 = n9;
        }

        public static implicit operator FE_ (FE fe) =>
            new (fe.n0, fe.n1, fe.n2, fe.n3, fe.n4, fe.n5, fe.n6, fe.n7, fe.n8, fe.n9);

        public static implicit operator FE (FE_ fe) =>
            new (fe.n0, fe.n1, fe.n2, fe.n3, fe.n4, fe.n5, fe.n6, fe.n7, fe.n8, fe.n9);
    }
    
    [RuntimeExport("testsegfault")]
    public static FE_ TestSegfault()
    {
        return EC.G.x;
    }
}