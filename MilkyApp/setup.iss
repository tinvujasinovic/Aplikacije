; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{812E296A-6764-4DED-8929-251E47E8C1A5}
AppName=MilkyApp
AppVersion=1.5
;AppVerName=MilkyApp 1.5
AppPublisher=MilkyApp
DefaultDirName={pf}\MilkyApp
DisableProgramGroupPage=yes
OutputBaseFilename=MilkyAppSetup
SetupIconFile=E:\FOI\3.godina\PI (2)\Milky\iconM.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "E:\FOI\3.godina\PI (2)\MilkyApp\MilkyApp\MilkyApp\bin\Release\MilkyApp.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\FOI\3.godina\PI (2)\MilkyApp\MilkyApp\MilkyApp\bin\Release\MilkyApp.exe.config"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\MilkyApp"; Filename: "{app}\MilkyApp.exe"
Name: "{commondesktop}\MilkyApp"; Filename: "{app}\MilkyApp.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\MilkyApp.exe"; Description: "{cm:LaunchProgram,MilkyApp}"; Flags: nowait postinstall skipifsilent

