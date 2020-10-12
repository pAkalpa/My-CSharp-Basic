To Compile DLL = mcs /target:library /out:exam.dll exam.cs


To Compile Main Program = mcs /reference:exam.dll examMain.cs


To Run Program = mono examMain.exe
