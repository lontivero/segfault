dotnet publish Library/Library.csproj /p:InvariantGlobalization=true /p:NativeLib=Static -c Release -r linux-x64 --self-contained -o lib

ILCOMPILER_PATH=$HOME/.nuget/packages/runtime.linux-x64.microsoft.dotnet.ilcompiler/7.0.0
ILCOMPILER_FX_PATH=$ILCOMPILER_PATH/framework
ILCOMPILER_SDK_PATH=$ILCOMPILER_PATH/sdk
cp $ILCOMPILER_SDK_PATH/lib{bootstrapper,bootstrapperdll,Runtime.WorkstationGC}.a ./lib/
cp $ILCOMPILER_FX_PATH/lib{System.Native,System.Security.Cryptography.Native.OpenSsl}.a ./lib/
gcc -Wall -ggdb Main/main.c -L$(pwd)/lib -l:Library.a ./lib/libRuntime.WorkstationGC.a ./lib/libbootstrapper.a ./lib/libbootstrapperdll.a ./lib/libSystem.Native.a ./lib/libSystem.Security.Cryptography.Native.OpenSsl.a -lm -lstdc++ -ldl