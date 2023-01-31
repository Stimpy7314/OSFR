@echo off
TITLE=OSFR Multiplayer
set /p address=IP:

:ChooseName
   set /p name=Character Name:
   If "%name%" == "" (
      GOTO ChooseName
   )

:ChooseGender
   set /p gender=Gender (Male/Female):
   if "%gender%" == "" (
      GOTO ChooseGender
   )

:ChooseRace
   set /p race=Race (Human/Pixie):
   if "%race%" == "" (
      GOTO ChooseRace
   )

If "%gender%" == "Female" (
    if "%race%" == "Human" (
       set guid=2
    ) else (
       set guid=5
    )
) else if "%gender%" == "Male" (
    if "%race%" == "Human" (
       set guid=3
    ) else (
       set guid=4
    )
) else If "%gender%" == "female" (
    if "%race%" == "human" (
       set guid=2
    ) else (
       set guid=5
    )
) else if "%gender%" == "male" (
    if "%race%" == "human" (
       set guid=3
    ) else (
       set guid=4
    )
) else (
   set guid=6816812
)

@echo Starting FreeRealms...

start /min FreeRealms.exe inifile=ClientConfig.ini Guid=%guid% Server=%address%:20260 Ticket=%name% Internationalization:Locale=8 ShowMemberLoadingScreen=0 Country=US key=m80HqsRO9i4PjJSCOasVMg== CasSessionId=Jk6TeiRMc4Ba38NO

exit /B