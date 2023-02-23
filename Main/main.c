/* gcc -Wall main.c -L. -l:WabiSabi.a libRuntime.WorkstationGC.a libbootstrapper.a libbootstrapperdll.a libSystem.Native.a libSystem.Security.Cryptography.Native.OpenSsl.a -lm -lstdc++ -ldl */
#include <stdio.h>

struct FE {
    __uint32_t n0, n1, n2, n3, n4, n5, n6, n7, n8, n9;
};

struct GE {
    struct FE x;
    struct FE y;
    int infinity;
};

struct FE test();
struct FE testsegfault();
int testint();


int main(){
    struct FE G = testsegfault();
    printf ("%u %u %u", G.n0, G.n1, G.n2);
    return 0;
}