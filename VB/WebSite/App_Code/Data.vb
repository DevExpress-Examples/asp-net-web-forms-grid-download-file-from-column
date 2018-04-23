Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Public Class Product
	Private privateProductID As Integer
	Public Property ProductID() As Integer
		Get
			Return privateProductID
		End Get
		Set(ByVal value As Integer)
			privateProductID = value
		End Set
	End Property
	Private privateProductName As String
	Public Property ProductName() As String
		Get
			Return privateProductName
		End Get
		Set(ByVal value As String)
			privateProductName = value
		End Set
	End Property
	Private privateUnitPrice As Nullable(Of Decimal)
	Public Property UnitPrice() As Nullable(Of Decimal)
		Get
			Return privateUnitPrice
		End Get
		Set(ByVal value As Nullable(Of Decimal))
			privateUnitPrice = value
		End Set
	End Property
	Private privateUnitsOnOrder As Nullable(Of Short)
	Public Property UnitsOnOrder() As Nullable(Of Short)
		Get
			Return privateUnitsOnOrder
		End Get
		Set(ByVal value As Nullable(Of Short))
			privateUnitsOnOrder = value
		End Set
	End Property
	Private privateImagePath As String
	Public Property ImagePath() As String
		Get
			Return privateImagePath
		End Get
		Set(ByVal value As String)
			privateImagePath = value
		End Set
	End Property

	Public Shared Function GetData() As List(Of Product)
		Dim products As New List(Of Product)()

		products.Add(New Product() With {.ProductID = 1, .ProductName = "Chai", .UnitPrice = 19, .UnitsOnOrder = 0, .ImagePath = "~/Images/IMG_1321.jpg"})
		products.Add(New Product() With {.ProductID = 2, .ProductName = "Chang", .UnitPrice = 19, .UnitsOnOrder = 40})
		products.Add(New Product() With {.ProductID = 3, .ProductName = "Aniseed Syrup", .UnitPrice = 10, .UnitsOnOrder = 70, .ImagePath = "~/Images/IMG_1397.jpg"})

		products.Add(New Product() With {.ProductID = 4, .ProductName = "Chef Anton's Cajun Seasoning", .UnitPrice = 22, .UnitsOnOrder = 0})
		products.Add(New Product() With {.ProductID = 5, .ProductName = "Chef Anton's Gumbo Mix", .UnitPrice = 21.35D, .UnitsOnOrder = 0, .ImagePath = "~/Images/IMG_1407.jpg"})
		products.Add(New Product() With {.ProductID = 6, .ProductName = "Grandma's Boysenberry Spread", .UnitPrice = 25, .UnitsOnOrder = 0, .ImagePath = "~/Images/IMG_1409.jpg"})

		products.Add(New Product() With {.ProductID = 7, .ProductName = "Uncle Bob's Organic Dried Pears", .UnitPrice = 30, .UnitsOnOrder = 0, .ImagePath = "~/Images/IMG_1445.jpg"})
		products.Add(New Product() With {.ProductID = 8, .ProductName = "Northwoods Cranberry Sauce", .UnitPrice = 40, .UnitsOnOrder = 0})
		products.Add(New Product() With {.ProductID = 9, .ProductName = "Mishi Kobe Niku", .UnitPrice = 97, .UnitsOnOrder = 0, .ImagePath = "~/Images/IMG_1391.jpg"})

		products.Add(New Product() With {.ProductID = 10, .ProductName = "Ikura", .UnitPrice = 31, .UnitsOnOrder = 0})
		products.Add(New Product() With {.ProductID = 11, .ProductName = "Queso Cabrales", .UnitPrice = 21, .UnitsOnOrder = 30, .ImagePath = "~/Images/IMG_1403.jpg"})
		products.Add(New Product() With {.ProductID = 12, .ProductName = "Queso Manchego La Pastora", .UnitPrice = 38, .UnitsOnOrder = 0})

		Return products
	End Function
End Class