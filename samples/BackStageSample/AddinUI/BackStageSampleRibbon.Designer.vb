Partial Class BackStageSampleRibbon
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabBSSampleAddin = New Microsoft.Office.Tools.Ribbon.RibbonTab
        Me.BackStageSampleGroup = New Microsoft.Office.Tools.Ribbon.RibbonGroup
        Me.btnTestButton = New Microsoft.Office.Tools.Ribbon.RibbonButton
        Me.TabBSSampleAddin.SuspendLayout()
        Me.BackStageSampleGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabBSSampleAddin
        '
        Me.TabBSSampleAddin.Groups.Add(Me.BackStageSampleGroup)
        Me.TabBSSampleAddin.Label = "BackStage Sample Addin"
        Me.TabBSSampleAddin.Name = "TabBSSampleAddin"
        '
        'BackStageSampleGroup
        '
        Me.BackStageSampleGroup.Items.Add(Me.btnTestButton)
        Me.BackStageSampleGroup.Label = "Sample Button group"
        Me.BackStageSampleGroup.Name = "BackStageSampleGroup"
        '
        'btnTestButton
        '
        Me.btnTestButton.Label = "Test button"
        Me.btnTestButton.Name = "btnTestButton"
        '
        'BackStageSampleRibbon
        '
        Me.Name = "BackStageSampleRibbon"
        Me.RibbonType = "Microsoft.Word.Document"
        Me.Tabs.Add(Me.TabBSSampleAddin)
        Me.TabBSSampleAddin.ResumeLayout(False)
        Me.TabBSSampleAddin.PerformLayout()
        Me.BackStageSampleGroup.ResumeLayout(False)
        Me.BackStageSampleGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabBSSampleAddin As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents BackStageSampleGroup As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents ShowDocNavTaskPane As Microsoft.Office.Tools.Ribbon.RibbonToggleButton
    Friend WithEvents btnPostProcess As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnDocNav As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents btnTestButton As Microsoft.Office.Tools.Ribbon.RibbonButton
End Class

Partial Class ThisRibbonCollection
    Inherits Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property BackStageSampleRibbon() As BackStageSampleRibbon
        Get
            Return Me.GetRibbon(Of BackStageSampleRibbon)()
        End Get
    End Property
End Class
