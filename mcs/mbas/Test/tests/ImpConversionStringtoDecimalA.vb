'Author:
'   V. Sudharsan (vsudharsan@novell.com)
'
' (C) 2003 Ximian, Inc.

Module ImpConversionStringtoDecimalA
	Sub Main()
			Dim a as Decimal
			Dim b as String= "123052"
			a = b
			if a <> 123052
				Throw new System.Exception("Conversion of String to Decimal not working. Expected 123052 but got " &a) 
			End if		
	End Sub
End Module
