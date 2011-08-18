#include <Windows.h>


// Called when the library is loaded and before dlopen() returns
void my_load(void)
{
    // Add initialization code…
}

// Called when the library is unloaded and before dlclose()
// returns
void my_unload(void)
{
    // Add clean-up code…
}


BOOL WINAPI DllMain(
  __in  HINSTANCE hinstDLL,
  __in  DWORD fdwReason,
  __in  LPVOID lpvReserved
)
{
    (void)lpvReserved;
    (void)hinstDLL;

    switch (fdwReason)
    {
    case DLL_PROCESS_ATTACH:
        my_load();
        break;
        
    case DLL_PROCESS_DETACH:
        my_unload();
        break;
    }
    
    return 0;
}

