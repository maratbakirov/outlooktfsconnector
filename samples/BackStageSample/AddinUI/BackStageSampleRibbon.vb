Imports Microsoft.Office.Tools.Ribbon
Imports System.Xml

''' <summary>
''' Represents the BackStageSample Addin Toolbar ribbon.
''' Not much on it at the moment.
''' </summary>
''' <remarks></remarks>
Friend Class BackStageSampleRibbon

    Private Sub btnTestButton_Click(ByVal sender As System.Object, ByVal e As Microsoft.Office.Tools.Ribbon.RibbonControlEventArgs) Handles btnTestButton.Click
        MsgBox("Ribbon Button Clicked")
    End Sub
End Class
