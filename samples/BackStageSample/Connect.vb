Imports Microsoft.Office.Tools
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Word
Imports System.Reflection
Imports System.Globalization
Imports Microsoft.Office.Tools.Ribbon
Imports Microsoft.Office.Core


'---- Expose the class to COM, although this is not technically necessary when using
'     VSTO
<ComClass(Connect.ClassId, Connect.InterfaceId, Connect.EventsId)> _
<ComVisible(True)> _
Public Class Connect
    Public Const ClassId As String = "BA389CD6-F9CB-4528-AF11-A0E5359E89F6"
    Public Const InterfaceId As String = "7B18EB85-1AF4-477b-8396-04194BF75F50"
    Public Const EventsId As String = "34D2269E-0952-4378-AD26-D300EED8E5CF"

    Private WithEvents _WordEvents As Microsoft.Office.Interop.Word.Application
    Private WithEvents _btnTestButton As Ribbon.RibbonButton


#Region " VSTO Addin events"
    Private Sub Connect_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
        '---- get notification of the events of the Word App
        _WordEvents = Me.Application

        '---- get notification of this button's events
        If Globals.Ribbons.BackStageSampleRibbon IsNot Nothing Then
            With Globals.Ribbons.BackStageSampleRibbon
                _btnTestButton = .btnTestButton
            End With
        End If
    End Sub


    Private Sub Connect_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
        '---- nothing happens during this for now
    End Sub


    ''' <summary>
    ''' Override this method to expose our CORE object externally to Word via the Word.Application.Addins property
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function RequestComAddInAutomationService() As Object
        '---- Return an instance of your COM exposed class here to make it available
        '     to Word VBA code or out of process apps.
        'Return new MyAddInClass
        Return Nothing
    End Function


    Private _RibbonExt As Microsoft.Office.Core.IRibbonExtensibility
    Private _RibbonManager As Microsoft.Office.Tools.Ribbon.RibbonManager
    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        _RibbonManager = DirectCast(MyBase.CreateRibbonExtensibilityObject(), Microsoft.Office.Tools.Ribbon.RibbonManager)
        Return _RibbonManager
    End Function


    ''' <summary>
    ''' Override this to avoid the Reflection across the entire addin that VSTO 
    ''' normally does in order to instantiate the ribbons
    ''' In this case, we know EXACTLY what ribbons to create, so just do it
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Overrides Function CreateRibbonObjects() As OfficeRibbon()
        Return New OfficeRibbon() {New BackStageSampleRibbon}
    End Function


    Protected Overrides Function RequestService(ByVal serviceGuid As System.Guid) As Object
        If (serviceGuid = GetType(Office.IRibbonExtensibility).GUID) Then
            'Return MyBase.RequestService(serviceGuid)
            _RibbonExt = New RibbonManagerInterceptor(Me, _RibbonManager)
            Return _RibbonExt
        Else
            Return MyBase.RequestService(serviceGuid)
        End If
    End Function
#End Region


    '---- Testing function
    Friend Sub bsSampleClicked()
        MsgBox("BackStage Sample Button was Clicked")
    End Sub


    ''' <summary>
    ''' Expose at least one public COM property to avoid warnings about there being
    ''' no COM Exposed objects or properties in the project.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Version() As String
        Get
            Return My.Application.Info.Version.ToString
        End Get
    End Property
End Class


''' <summary>
''' Our interception object that sits in front of the Microsoft VSTO RibbonManager
''' class. This class forwards most calls on to the RibbonManager but also allows 
''' our addin to intercept and modify the Ribbon XML and intercept callbacks.
''' </summary>
''' <remarks></remarks>
<Runtime.InteropServices.ComVisible(True)> _
Public Class RibbonManagerInterceptor
    Implements IRibbonExtensibility, IReflect

    Private _RibbonManager As IRibbonExtensibility
    Private _Connect As Connect
    Public Sub New(ByVal Connect As Connect, ByVal InternalRibbonExt As IRibbonExtensibility)
        _Connect = Connect
        _RibbonManager = InternalRibbonExt
    End Sub


    Public Function GetCustomUI(ByVal RibbonID As String) As String Implements IRibbonExtensibility.GetCustomUI
        Dim xml = _RibbonManager.GetCustomUI(RibbonID)

        If _Connect.Application.Version = "14.0" Then
            '---- only add in backstage support for version 14 (Office 2010)
            Dim bs = <backstage>
                         <tab id="bsSample" label="BackStageSample" insertAfterMso="TabInfo">
                             <firstColumn>
                                 <group id="bsSampleGroup" label="BackStage Sample Group">
                                     <topItems>
                                         <button id="BackStageSample"
                                             label="BackStage Sample Button"
                                             onAction="bsSampleClicked"/>
                                     </topItems>
                                 </group>
                             </firstColumn>
                         </tab>
                     </backstage>
            xml = xml.Replace("</customUI>", bs.ToString & "</customUI>")
            xml = xml.Replace("http://schemas.microsoft.com/office/2006/01/customui", "http://schemas.microsoft.com/office/2009/07/customui")
        End If
        Return xml
    End Function


    Private Function IReflect_GetField(ByVal name As String, ByVal bindingAttr As BindingFlags) As FieldInfo Implements IReflect.GetField
        Throw New NotImplementedException
    End Function

    Private Function IReflect_GetFields(ByVal bindingAttr As BindingFlags) As FieldInfo() Implements IReflect.GetFields
        Return New FieldInfo(0 - 1) {}
    End Function

    Private Function IReflect_GetMember(ByVal name As String, ByVal bindingAttr As BindingFlags) As MemberInfo() Implements IReflect.GetMember
        Throw New NotImplementedException
    End Function

    Private Function IReflect_GetMembers(ByVal bindingAttr As BindingFlags) As MemberInfo() Implements IReflect.GetMembers
        Throw New NotImplementedException
    End Function

    Private Function IReflect_GetMethod(ByVal name As String, ByVal bindingAttr As BindingFlags) As MethodInfo Implements IReflect.GetMethod
        Throw New NotImplementedException
    End Function

    Private Function IReflect_GetMethod(ByVal name As String, ByVal bindingAttr As BindingFlags, ByVal binder As Binder, ByVal types As Type(), ByVal modifiers As ParameterModifier()) As MethodInfo Implements IReflect.GetMethod
        Throw New NotImplementedException
    End Function

    Private Function IReflect_GetMethods(ByVal bindingAttr As BindingFlags) As MethodInfo() Implements IReflect.GetMethods
        Dim ir = DirectCast(_RibbonManager, IReflect)
        Dim r = ir.GetMethods(bindingAttr)
        ReDim Preserve r(UBound(r) + 1)
        Dim mi = BackstageMethodInfo.CheckBoxActionMethod(DirectCast(_RibbonManager, RibbonManager), "bsSampleClicked", Nothing)
        r(UBound(r)) = mi
        Return r
    End Function

    Private Function IReflect_GetProperties(ByVal bindingAttr As BindingFlags) As PropertyInfo() Implements IReflect.GetProperties
        Return New PropertyInfo(0 - 1) {}
    End Function

    Private Function IReflect_GetProperty(ByVal name As String, ByVal bindingAttr As BindingFlags) As PropertyInfo Implements IReflect.GetProperty
        Throw New NotImplementedException
    End Function

    Private Function IReflect_GetProperty(ByVal name As String, ByVal bindingAttr As BindingFlags, ByVal binder As Binder, ByVal returnType As Type, ByVal types As Type(), ByVal modifiers As ParameterModifier()) As PropertyInfo Implements IReflect.GetProperty
        Throw New NotImplementedException
    End Function

    Private Function IReflect_InvokeMember(ByVal name As String, ByVal invokeAttr As BindingFlags, ByVal binder As Binder, ByVal target As Object, ByVal args As Object(), ByVal modifiers As ParameterModifier(), ByVal culture As CultureInfo, ByVal namedParameters As String()) As Object Implements IReflect.InvokeMember
        Dim r As Object
        If name.StartsWith("bs") Then
            '---- it's a Backstage control, just intercept and pass through
            '     to the connect object
            Select Case name.ToLower
                Case "bssampleclicked"
                    _Connect.bsSampleClicked()
                Case Else
            End Select
            Return Nothing
        Else
            Try
                Dim ir = DirectCast(_RibbonManager, IReflect)
                r = ir.InvokeMember(name, invokeAttr, binder, _RibbonManager, args, modifiers, culture, namedParameters)
            Catch ex As Exception
                Throw New TargetInvocationException(ex)
            End Try
            Return r
        End If
    End Function


    Private ReadOnly Property IReflect_UnderlyingSystemType() As Type Implements IReflect.UnderlyingSystemType
        Get
            Throw New NotImplementedException
        End Get
    End Property
End Class


''' <summary>
''' This class mirrors the RibbonMethodInfo class from Microsoft.Office.Ribbon
''' Essentially, it is used to generate virtual method signatures for providing the hooks
''' for the Backstage Callbacks.
''' Since we're in VSTO 3, the Backstage isn't technically supported but this will
''' allow us to hook those callbacks anyway
''' </summary>
''' <remarks></remarks>
Friend NotInheritable Class BackstageMethodInfo
    Inherits MethodInfo

    Friend Delegate Function RibbonComponentCallback(ByVal component As RibbonComponent, ByVal args As Object()) As Object

    ' Methods
    Private Sub New(ByVal manager As RibbonManager, ByVal method As MethodInfo, ByVal newName As String, ByVal callback As RibbonComponentCallback)
        Me.manager = manager
        Me.innerMethodInfo = method
        Me.newMethodName = newName
    End Sub

    Friend Shared Function CheckBoxActionMethod(ByVal manager As RibbonManager, ByVal methodName As String, ByVal callback As RibbonComponentCallback) As BackstageMethodInfo
        Return BackstageMethodInfo.CreateMethod(manager, methodName, callback, CallbackMethodSignatures.ToggleButtonActionMethod)
    End Function

    Private Shared Function CreateMethod(ByVal manager As RibbonManager, ByVal methodName As String, ByVal callback As RibbonComponentCallback, ByVal signature As MethodInfo) As BackstageMethodInfo
        Return New BackstageMethodInfo(manager, signature, methodName, callback)
    End Function

    Public Overrides Function GetBaseDefinition() As MethodInfo
        Return Me.innerMethodInfo.GetBaseDefinition
    End Function

    Public Overrides Function GetCustomAttributes(ByVal inherit As Boolean) As Object()
        Return Me.innerMethodInfo.GetCustomAttributes(inherit)
    End Function

    Public Overrides Function GetCustomAttributes(ByVal attributeType As Type, ByVal inherit As Boolean) As Object()
        Return Me.innerMethodInfo.GetCustomAttributes(attributeType, inherit)
    End Function

    Friend Shared Function GetItemValueMethod(ByVal manager As RibbonManager, ByVal methodName As String, ByVal callback As RibbonComponentCallback) As BackstageMethodInfo
        Return BackstageMethodInfo.CreateMethod(manager, methodName, callback, CallbackMethodSignatures.GetItemValueMethod)
    End Function

    Public Overrides Function GetMethodImplementationFlags() As MethodImplAttributes
        Return Me.innerMethodInfo.GetMethodImplementationFlags
    End Function

    Friend Shared Function GetParameter(Of TResult)(ByVal args As Object(), ByVal index As Integer) As TResult
        If (args Is Nothing) Then
            Throw New ArgumentNullException("args")
        End If
        Return DirectCast(args(index), TResult)
    End Function

    Public Overrides Function GetParameters() As ParameterInfo()
        Return Me.innerMethodInfo.GetParameters
    End Function

    Friend Shared Function GetValueMethod(ByVal manager As RibbonManager, ByVal methodName As String, ByVal callback As RibbonComponentCallback) As BackstageMethodInfo
        Return BackstageMethodInfo.CreateMethod(manager, methodName, callback, CallbackMethodSignatures.GetValueMethod)
    End Function

    Public Overrides Function Invoke(ByVal obj As Object, ByVal invokeAttr As BindingFlags, ByVal binder As Binder, ByVal parameters As Object(), ByVal culture As CultureInfo) As Object
        MsgBox("here")
        Return Nothing
        'Return Me.manager.Invoke(Me.callback, parameters)
    End Function

    Public Overrides Function IsDefined(ByVal attributeType As Type, ByVal inherit As Boolean) As Boolean
        Return Me.innerMethodInfo.IsDefined(attributeType, inherit)
    End Function

    Friend Shared Function ItemSelectedMethod(ByVal manager As RibbonManager, ByVal methodName As String, ByVal callback As RibbonComponentCallback) As BackstageMethodInfo
        Return BackstageMethodInfo.CreateMethod(manager, methodName, callback, CallbackMethodSignatures.ItemSelectedMethod)
    End Function

    Friend Shared Function RibbonLoadImageMethod(ByVal manager As RibbonManager, ByVal methodName As String, ByVal callback As RibbonComponentCallback) As BackstageMethodInfo
        Return BackstageMethodInfo.CreateMethod(manager, methodName, callback, CallbackMethodSignatures.RibbonLoadImageMethod)
    End Function

    Friend Shared Function RibbonLoadMethod(ByVal manager As RibbonManager, ByVal methodName As String, ByVal callback As RibbonComponentCallback) As BackstageMethodInfo
        Return BackstageMethodInfo.CreateMethod(manager, methodName, callback, CallbackMethodSignatures.RibbonLoadMethod)
    End Function

    Friend Shared Function TextChangedMethod(ByVal manager As RibbonManager, ByVal methodName As String, ByVal callback As RibbonComponentCallback) As BackstageMethodInfo
        Return BackstageMethodInfo.CreateMethod(manager, methodName, callback, CallbackMethodSignatures.TextChangedMethod)
    End Function


    ' Properties
    Public Overrides ReadOnly Property Attributes() As MethodAttributes
        Get
            Return Me.innerMethodInfo.Attributes
        End Get
    End Property

    Public Overrides ReadOnly Property DeclaringType() As Type
        Get
            Return Me.innerMethodInfo.DeclaringType
        End Get
    End Property

    Public Overrides ReadOnly Property MethodHandle() As RuntimeMethodHandle
        Get
            Return Me.innerMethodInfo.MethodHandle
        End Get
    End Property

    Public Overrides ReadOnly Property Name() As String
        Get
            Return Me.newMethodName
        End Get
    End Property

    Public Overrides ReadOnly Property ReflectedType() As Type
        Get
            Return Me.innerMethodInfo.ReflectedType
        End Get
    End Property

    Public Overrides ReadOnly Property ReturnTypeCustomAttributes() As ICustomAttributeProvider
        Get
            Return Me.innerMethodInfo.ReturnTypeCustomAttributes
        End Get
    End Property


    ' Fields
    'Private callback As RibbonComponentCallback
    Private innerMethodInfo As MethodInfo
    Private manager As RibbonManager
    Private newMethodName As String

    ' Nested Types
    Private Class CallbackMethodSignatures
        ' Methods
        Private Sub GetItemValue(ByVal control As IRibbonControl, ByVal index As Integer)
        End Sub

        Private Function GetValue(ByVal control As IRibbonControl) As Object
            Return Nothing
        End Function

        Private Sub ItemSelected(ByVal control As IRibbonControl, ByVal selectedId As String, ByVal selectedIndex As Integer)
        End Sub

        Private Sub RibbonLoad(ByVal ui As IRibbonUI)
        End Sub

        Private Function RibbonLoadImage(ByVal image As String) As Object
            Return Nothing
        End Function

        Private Sub TextChanged(ByVal control As IRibbonControl, ByVal [text] As String)
        End Sub

        Private Sub ToggleButtonAction(ByVal control As IRibbonControl, ByVal pressed As Boolean)
        End Sub


        ' Fields
        Friend Shared ReadOnly GetItemValueMethod As MethodInfo = GetType(CallbackMethodSignatures).GetMethod("GetItemValue", (BindingFlags.NonPublic Or BindingFlags.Instance))
        Friend Shared ReadOnly GetValueMethod As MethodInfo = GetType(CallbackMethodSignatures).GetMethod("GetValue", (BindingFlags.NonPublic Or BindingFlags.Instance))
        Friend Shared ReadOnly ItemSelectedMethod As MethodInfo = GetType(CallbackMethodSignatures).GetMethod("ItemSelected", (BindingFlags.NonPublic Or BindingFlags.Instance))
        Friend Shared ReadOnly RibbonLoadImageMethod As MethodInfo = GetType(CallbackMethodSignatures).GetMethod("RibbonLoadImage", (BindingFlags.NonPublic Or BindingFlags.Instance))
        Friend Shared ReadOnly RibbonLoadMethod As MethodInfo = GetType(CallbackMethodSignatures).GetMethod("RibbonLoad", (BindingFlags.NonPublic Or BindingFlags.Instance))
        Friend Shared ReadOnly TextChangedMethod As MethodInfo = GetType(CallbackMethodSignatures).GetMethod("TextChanged", (BindingFlags.NonPublic Or BindingFlags.Instance))
        Friend Shared ReadOnly ToggleButtonActionMethod As MethodInfo = GetType(CallbackMethodSignatures).GetMethod("ToggleButtonAction", (BindingFlags.NonPublic Or BindingFlags.Instance))
    End Class
End Class



