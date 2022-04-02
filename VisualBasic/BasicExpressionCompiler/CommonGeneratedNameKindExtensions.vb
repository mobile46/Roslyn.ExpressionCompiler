﻿Imports System.Runtime.CompilerServices
Imports Microsoft.CodeAnalysis.ExpressionEvaluator
Imports Microsoft.CodeAnalysis.VisualBasic.Symbols

Namespace Microsoft.CodeAnalysis.VisualBasic.ExpressionEvaluator
    Friend Module CommonGeneratedNameKindExtensions
        <Extension()>
        Public Function ToGeneratedNameKind(kind As CommonGeneratedNameKind) As GeneratedNameKind
            Const hiddenKind As GeneratedNameKind = -1
            Select Case kind
                Case CommonGeneratedNameKind.None
                    Return GeneratedNameKind.None
                Case CommonGeneratedNameKind.HoistedSynthesizedLocalField
                    Return GeneratedNameKind.HoistedSynthesizedLocalField
                Case CommonGeneratedNameKind.HoistedUserVariableField
                    Return GeneratedNameKind.HoistedUserVariableField
                Case CommonGeneratedNameKind.IteratorCurrentField
                    Return GeneratedNameKind.IteratorCurrentField
                Case CommonGeneratedNameKind.IteratorInitialThreadIdField
                    Return GeneratedNameKind.IteratorInitialThreadIdField
                Case CommonGeneratedNameKind.StateMachineAwaiterField
                    Return GeneratedNameKind.StateMachineAwaiterField
                Case CommonGeneratedNameKind.StateMachineStateField
                    Return GeneratedNameKind.StateMachineStateField
                Case CommonGeneratedNameKind.StateMachineHoistedUserVariableField
                    Return GeneratedNameKind.StateMachineHoistedUserVariableField
                Case CommonGeneratedNameKind.StaticLocalField
                    Return GeneratedNameKind.StaticLocalField
                Case CommonGeneratedNameKind.TransparentIdentifier
                    Return GeneratedNameKind.TransparentIdentifier
                Case CommonGeneratedNameKind.AnonymousTransparentIdentifier
                    Return GeneratedNameKind.AnonymousTransparentIdentifier
                Case CommonGeneratedNameKind.AnonymousType
                    Return GeneratedNameKind.AnonymousType
                Case CommonGeneratedNameKind.LambdaCacheField
                    Return GeneratedNameKind.LambdaCacheField
                Case CommonGeneratedNameKind.LambdaDisplayClass
                    Return GeneratedNameKind.LambdaDisplayClass
                Case CommonGeneratedNameKind.HoistedSpecialVariableField
                    Return hiddenKind
                Case CommonGeneratedNameKind.IteratorCurrentBackingField
                    Return GeneratedNameKind.IteratorCurrentField
                Case CommonGeneratedNameKind.StateMachineParameterProxyField
                    Return GeneratedNameKind.IteratorParameterProxyField
                Case CommonGeneratedNameKind.ThisProxyField
                    Return GeneratedNameKind.HoistedMeField
                Case CommonGeneratedNameKind.HoistedLocalField
                    Return GeneratedNameKind.HoistedUserVariableField
                Case CommonGeneratedNameKind.Deprecated_OuterscopeLocals
                    Return hiddenKind
                Case CommonGeneratedNameKind.ReusableHoistedLocalField
                    Return GeneratedNameKind.HoistedUserVariableField
                Case CommonGeneratedNameKind.DisplayClassLocalOrField
                    Return hiddenKind
                Case CommonGeneratedNameKind.Deprecated_IteratorInstance
                    Return hiddenKind
                Case CommonGeneratedNameKind.LambdaMethod
                    Return hiddenKind
                Case CommonGeneratedNameKind.StateMachineType
                    Return hiddenKind
                Case CommonGeneratedNameKind.FixedBufferField
                    Return hiddenKind
                Case CommonGeneratedNameKind.LocalFunction
                    Return hiddenKind
                Case CommonGeneratedNameKind.Deprecated_InitializerLocal
                    Return hiddenKind
                Case CommonGeneratedNameKind.AnonymousTypeField
                    Return hiddenKind
                Case CommonGeneratedNameKind.AnonymousTypeTypeParameter
                    Return hiddenKind
                Case CommonGeneratedNameKind.AutoPropertyBackingField
                    Return hiddenKind
                Case CommonGeneratedNameKind.IteratorCurrentThreadIdField
                    Return GeneratedNameKind.IteratorInitialThreadIdField
                Case CommonGeneratedNameKind.IteratorFinallyMethod
                    Return hiddenKind
                Case CommonGeneratedNameKind.BaseMethodWrapper
                    Return hiddenKind
                Case CommonGeneratedNameKind.DynamicCallSiteContainerType
                    Return hiddenKind
                Case CommonGeneratedNameKind.DynamicCallSiteField
                    Return hiddenKind
                Case CommonGeneratedNameKind.Deprecated_DynamicDelegate
                    Return hiddenKind
                Case CommonGeneratedNameKind.Deprecated_ComrefCallLocal
                    Return hiddenKind
                Case CommonGeneratedNameKind.AsyncBuilderField
                    Return hiddenKind
                Case CommonGeneratedNameKind.StateMachineDisposingField
                    Return hiddenKind
                Case CommonGeneratedNameKind.AsyncIteratorPromiseOfValueOrEndBackingField
                    Return hiddenKind
                Case CommonGeneratedNameKind.DisposeModeField
                    Return hiddenKind
                Case CommonGeneratedNameKind.CombinedTokensField
                    Return hiddenKind
                Case Else
                    Debug.Fail($"Unknown kind: {kind}")
                    Return hiddenKind
            End Select
        End Function
    End Module
End Namespace
