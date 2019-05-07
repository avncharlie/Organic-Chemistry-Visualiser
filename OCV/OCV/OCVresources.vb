﻿Module OCVresources
    Public startupFolder As String = System.AppDomain.CurrentDomain.BaseDirectory & "resources\"
    Public tokenDefinitionsFile As String = startupFolder & "tokens.xml"

    Public scale As Double = 1

    Public alkaneSpacing As Double = 30
    Public alkaneRise As Double = 17

    Public alkeEneYneLineXOffsetPercentage As Double = 3 / 30   ' 0.1
    Public alkEneYneLineYOffsetPercentage As Double = 5 / 17    ' 0.294117...

    Public canvasOffset As Double() = {30, 30}

    Public alkaneStartsRising As Boolean = False

End Module
