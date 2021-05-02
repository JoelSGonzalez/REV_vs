^+g::
Process, Exist, Opera.exe
{
	If ! errorlevel
	{
		Run "C:\Users\jsoar\AppData\Local\Programs\Opera GX\launcher.exe"
		Sleep, 3000
	}
}
RunWait, C:\Users\jsoar\source\repos\REVOLUTION continues\Grafo.bat
FileRead, content, C:\Users\jsoar\source\repos\REVOLUTION continues\Grafo.txt
Clipboard := content
CoordMode, Mouse, Screen
Sleep, 2000
Click, 265, 453
Send, ^a
Send, ^v
Send, +{Tab}
Send, {Enter}
return