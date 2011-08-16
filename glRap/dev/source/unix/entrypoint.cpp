void __attribute__ ((constructor)) my_load(void);
void __attribute__ ((destructor)) my_unload(void);

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

