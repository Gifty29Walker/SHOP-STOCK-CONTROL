<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim PRODUCT_IDLabel As System.Windows.Forms.Label
        Dim PRODUCT_NAMELabel As System.Windows.Forms.Label
        Dim CATEGORYLabel As System.Windows.Forms.Label
        Dim SIZELabel As System.Windows.Forms.Label
        Dim UNIT_PRICELabel As System.Windows.Forms.Label
        Dim STOCK_LEVELLabel As System.Windows.Forms.Label
        Dim REORDER_LEVELLabel As System.Windows.Forms.Label
        Dim MAXIMUM_LEVELLabel As System.Windows.Forms.Label
        Dim ORDER_IDLabel As System.Windows.Forms.Label
        Dim QUANTITYLabel As System.Windows.Forms.Label
        Dim CUSTOMER_IDLabel As System.Windows.Forms.Label
        Dim DATELabel As System.Windows.Forms.Label
        Dim DISPATCHEDLabel As System.Windows.Forms.Label
        Dim PAIDLabel As System.Windows.Forms.Label
        Dim TITLELabel As System.Windows.Forms.Label
        Dim FIRST_NAMELabel As System.Windows.Forms.Label
        Me.INVENTORYDataSet = New SHOP_STOCK_CONTROL.INVENTORYDataSet()
        Me.SHOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SHOPTableAdapter = New SHOP_STOCK_CONTROL.INVENTORYDataSetTableAdapters.SHOPTableAdapter()
        Me.TableAdapterManager = New SHOP_STOCK_CONTROL.INVENTORYDataSetTableAdapters.TableAdapterManager()
        Me.SHOPBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SHOPBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SHOPDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODUCT_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PRODUCT_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.CATEGORYTextBox = New System.Windows.Forms.TextBox()
        Me.SIZETextBox = New System.Windows.Forms.TextBox()
        Me.UNIT_PRICETextBox = New System.Windows.Forms.TextBox()
        Me.STOCK_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.REORDER_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.MAXIMUM_LEVELTextBox = New System.Windows.Forms.TextBox()
        Me.ORDER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QUANTITYTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DATEDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DISPATCHEDCheckBox = New System.Windows.Forms.CheckBox()
        Me.PAIDCheckBox = New System.Windows.Forms.CheckBox()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        PRODUCT_IDLabel = New System.Windows.Forms.Label()
        PRODUCT_NAMELabel = New System.Windows.Forms.Label()
        CATEGORYLabel = New System.Windows.Forms.Label()
        SIZELabel = New System.Windows.Forms.Label()
        UNIT_PRICELabel = New System.Windows.Forms.Label()
        STOCK_LEVELLabel = New System.Windows.Forms.Label()
        REORDER_LEVELLabel = New System.Windows.Forms.Label()
        MAXIMUM_LEVELLabel = New System.Windows.Forms.Label()
        ORDER_IDLabel = New System.Windows.Forms.Label()
        QUANTITYLabel = New System.Windows.Forms.Label()
        CUSTOMER_IDLabel = New System.Windows.Forms.Label()
        DATELabel = New System.Windows.Forms.Label()
        DISPATCHEDLabel = New System.Windows.Forms.Label()
        PAIDLabel = New System.Windows.Forms.Label()
        TITLELabel = New System.Windows.Forms.Label()
        FIRST_NAMELabel = New System.Windows.Forms.Label()
        CType(Me.INVENTORYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOPBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SHOPBindingNavigator.SuspendLayout()
        CType(Me.SHOPDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'INVENTORYDataSet
        '
        Me.INVENTORYDataSet.DataSetName = "INVENTORYDataSet"
        Me.INVENTORYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SHOPBindingSource
        '
        Me.SHOPBindingSource.DataMember = "SHOP"
        Me.SHOPBindingSource.DataSource = Me.INVENTORYDataSet
        '
        'SHOPTableAdapter
        '
        Me.SHOPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CUSTOMER_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_CATELOGUETableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_DETAILSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCT_ORDERSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SHOP_STOCK_CONTROL.INVENTORYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SHOPBindingNavigator
        '
        Me.SHOPBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SHOPBindingNavigator.BindingSource = Me.SHOPBindingSource
        Me.SHOPBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SHOPBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SHOPBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SHOPBindingNavigatorSaveItem})
        Me.SHOPBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SHOPBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SHOPBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SHOPBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SHOPBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SHOPBindingNavigator.Name = "SHOPBindingNavigator"
        Me.SHOPBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SHOPBindingNavigator.Size = New System.Drawing.Size(970, 25)
        Me.SHOPBindingNavigator.TabIndex = 0
        Me.SHOPBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SHOPBindingNavigatorSaveItem
        '
        Me.SHOPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SHOPBindingNavigatorSaveItem.Enabled = False
        Me.SHOPBindingNavigatorSaveItem.Image = CType(resources.GetObject("SHOPBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SHOPBindingNavigatorSaveItem.Name = "SHOPBindingNavigatorSaveItem"
        Me.SHOPBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.SHOPBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SHOPDataGridView
        '
        Me.SHOPDataGridView.AutoGenerateColumns = False
        Me.SHOPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SHOPDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.SHOPDataGridView.DataSource = Me.SHOPBindingSource
        Me.SHOPDataGridView.Location = New System.Drawing.Point(26, 311)
        Me.SHOPDataGridView.Name = "SHOPDataGridView"
        Me.SHOPDataGridView.Size = New System.Drawing.Size(944, 280)
        Me.SHOPDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PRODUCT ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PRODUCT NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PRODUCT NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CATEGORY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SIZE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SIZE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UNIT PRICE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "STOCK LEVEL"
        Me.DataGridViewTextBoxColumn6.HeaderText = "STOCK LEVEL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "REORDER LEVEL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "REORDER LEVEL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MAXIMUM LEVEL"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MAXIMUM LEVEL"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ORDER ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ORDER ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "QUANTITY"
        Me.DataGridViewTextBoxColumn10.HeaderText = "QUANTITY"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CUSTOMER ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DATE"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "DISPATCHED"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "DISPATCHED"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "PAID"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "PAID"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "TITLE"
        Me.DataGridViewTextBoxColumn13.HeaderText = "TITLE"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FIRST NAME"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FIRST NAME"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PRODUCT_IDLabel
        '
        PRODUCT_IDLabel.AutoSize = True
        PRODUCT_IDLabel.Location = New System.Drawing.Point(50, 86)
        PRODUCT_IDLabel.Name = "PRODUCT_IDLabel"
        PRODUCT_IDLabel.Size = New System.Drawing.Size(77, 13)
        PRODUCT_IDLabel.TabIndex = 2
        PRODUCT_IDLabel.Text = "PRODUCT ID:"
        '
        'PRODUCT_IDTextBox
        '
        Me.PRODUCT_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "PRODUCT ID", True))
        Me.PRODUCT_IDTextBox.Location = New System.Drawing.Point(156, 83)
        Me.PRODUCT_IDTextBox.Name = "PRODUCT_IDTextBox"
        Me.PRODUCT_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRODUCT_IDTextBox.TabIndex = 3
        '
        'PRODUCT_NAMELabel
        '
        PRODUCT_NAMELabel.AutoSize = True
        PRODUCT_NAMELabel.Location = New System.Drawing.Point(50, 112)
        PRODUCT_NAMELabel.Name = "PRODUCT_NAMELabel"
        PRODUCT_NAMELabel.Size = New System.Drawing.Size(97, 13)
        PRODUCT_NAMELabel.TabIndex = 4
        PRODUCT_NAMELabel.Text = "PRODUCT NAME:"
        '
        'PRODUCT_NAMETextBox
        '
        Me.PRODUCT_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "PRODUCT NAME", True))
        Me.PRODUCT_NAMETextBox.Location = New System.Drawing.Point(156, 109)
        Me.PRODUCT_NAMETextBox.Name = "PRODUCT_NAMETextBox"
        Me.PRODUCT_NAMETextBox.Size = New System.Drawing.Size(200, 20)
        Me.PRODUCT_NAMETextBox.TabIndex = 5
        '
        'CATEGORYLabel
        '
        CATEGORYLabel.AutoSize = True
        CATEGORYLabel.Location = New System.Drawing.Point(50, 138)
        CATEGORYLabel.Name = "CATEGORYLabel"
        CATEGORYLabel.Size = New System.Drawing.Size(69, 13)
        CATEGORYLabel.TabIndex = 6
        CATEGORYLabel.Text = "CATEGORY:"
        '
        'CATEGORYTextBox
        '
        Me.CATEGORYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "CATEGORY", True))
        Me.CATEGORYTextBox.Location = New System.Drawing.Point(156, 135)
        Me.CATEGORYTextBox.Name = "CATEGORYTextBox"
        Me.CATEGORYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CATEGORYTextBox.TabIndex = 7
        '
        'SIZELabel
        '
        SIZELabel.AutoSize = True
        SIZELabel.Location = New System.Drawing.Point(50, 164)
        SIZELabel.Name = "SIZELabel"
        SIZELabel.Size = New System.Drawing.Size(34, 13)
        SIZELabel.TabIndex = 8
        SIZELabel.Text = "SIZE:"
        '
        'SIZETextBox
        '
        Me.SIZETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "SIZE", True))
        Me.SIZETextBox.Location = New System.Drawing.Point(156, 161)
        Me.SIZETextBox.Name = "SIZETextBox"
        Me.SIZETextBox.Size = New System.Drawing.Size(200, 20)
        Me.SIZETextBox.TabIndex = 9
        '
        'UNIT_PRICELabel
        '
        UNIT_PRICELabel.AutoSize = True
        UNIT_PRICELabel.Location = New System.Drawing.Point(50, 190)
        UNIT_PRICELabel.Name = "UNIT_PRICELabel"
        UNIT_PRICELabel.Size = New System.Drawing.Size(71, 13)
        UNIT_PRICELabel.TabIndex = 10
        UNIT_PRICELabel.Text = "UNIT PRICE:"
        '
        'UNIT_PRICETextBox
        '
        Me.UNIT_PRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "UNIT PRICE", True))
        Me.UNIT_PRICETextBox.Location = New System.Drawing.Point(156, 187)
        Me.UNIT_PRICETextBox.Name = "UNIT_PRICETextBox"
        Me.UNIT_PRICETextBox.Size = New System.Drawing.Size(200, 20)
        Me.UNIT_PRICETextBox.TabIndex = 11
        '
        'STOCK_LEVELLabel
        '
        STOCK_LEVELLabel.AutoSize = True
        STOCK_LEVELLabel.Location = New System.Drawing.Point(50, 216)
        STOCK_LEVELLabel.Name = "STOCK_LEVELLabel"
        STOCK_LEVELLabel.Size = New System.Drawing.Size(82, 13)
        STOCK_LEVELLabel.TabIndex = 12
        STOCK_LEVELLabel.Text = "STOCK LEVEL:"
        '
        'STOCK_LEVELTextBox
        '
        Me.STOCK_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "STOCK LEVEL", True))
        Me.STOCK_LEVELTextBox.Location = New System.Drawing.Point(156, 213)
        Me.STOCK_LEVELTextBox.Name = "STOCK_LEVELTextBox"
        Me.STOCK_LEVELTextBox.Size = New System.Drawing.Size(200, 20)
        Me.STOCK_LEVELTextBox.TabIndex = 13
        '
        'REORDER_LEVELLabel
        '
        REORDER_LEVELLabel.AutoSize = True
        REORDER_LEVELLabel.Location = New System.Drawing.Point(50, 242)
        REORDER_LEVELLabel.Name = "REORDER_LEVELLabel"
        REORDER_LEVELLabel.Size = New System.Drawing.Size(100, 13)
        REORDER_LEVELLabel.TabIndex = 14
        REORDER_LEVELLabel.Text = "REORDER LEVEL:"
        '
        'REORDER_LEVELTextBox
        '
        Me.REORDER_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "REORDER LEVEL", True))
        Me.REORDER_LEVELTextBox.Location = New System.Drawing.Point(156, 239)
        Me.REORDER_LEVELTextBox.Name = "REORDER_LEVELTextBox"
        Me.REORDER_LEVELTextBox.Size = New System.Drawing.Size(200, 20)
        Me.REORDER_LEVELTextBox.TabIndex = 15
        '
        'MAXIMUM_LEVELLabel
        '
        MAXIMUM_LEVELLabel.AutoSize = True
        MAXIMUM_LEVELLabel.Location = New System.Drawing.Point(50, 268)
        MAXIMUM_LEVELLabel.Name = "MAXIMUM_LEVELLabel"
        MAXIMUM_LEVELLabel.Size = New System.Drawing.Size(98, 13)
        MAXIMUM_LEVELLabel.TabIndex = 16
        MAXIMUM_LEVELLabel.Text = "MAXIMUM LEVEL:"
        '
        'MAXIMUM_LEVELTextBox
        '
        Me.MAXIMUM_LEVELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "MAXIMUM LEVEL", True))
        Me.MAXIMUM_LEVELTextBox.Location = New System.Drawing.Point(156, 265)
        Me.MAXIMUM_LEVELTextBox.Name = "MAXIMUM_LEVELTextBox"
        Me.MAXIMUM_LEVELTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MAXIMUM_LEVELTextBox.TabIndex = 17
        '
        'ORDER_IDLabel
        '
        ORDER_IDLabel.AutoSize = True
        ORDER_IDLabel.Location = New System.Drawing.Point(454, 89)
        ORDER_IDLabel.Name = "ORDER_IDLabel"
        ORDER_IDLabel.Size = New System.Drawing.Size(63, 13)
        ORDER_IDLabel.TabIndex = 18
        ORDER_IDLabel.Text = "ORDER ID:"
        '
        'ORDER_IDTextBox
        '
        Me.ORDER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "ORDER ID", True))
        Me.ORDER_IDTextBox.Location = New System.Drawing.Point(560, 86)
        Me.ORDER_IDTextBox.Name = "ORDER_IDTextBox"
        Me.ORDER_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ORDER_IDTextBox.TabIndex = 19
        '
        'QUANTITYLabel
        '
        QUANTITYLabel.AutoSize = True
        QUANTITYLabel.Location = New System.Drawing.Point(454, 115)
        QUANTITYLabel.Name = "QUANTITYLabel"
        QUANTITYLabel.Size = New System.Drawing.Size(65, 13)
        QUANTITYLabel.TabIndex = 20
        QUANTITYLabel.Text = "QUANTITY:"
        '
        'QUANTITYTextBox
        '
        Me.QUANTITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "QUANTITY", True))
        Me.QUANTITYTextBox.Location = New System.Drawing.Point(560, 112)
        Me.QUANTITYTextBox.Name = "QUANTITYTextBox"
        Me.QUANTITYTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QUANTITYTextBox.TabIndex = 21
        '
        'CUSTOMER_IDLabel
        '
        CUSTOMER_IDLabel.AutoSize = True
        CUSTOMER_IDLabel.Location = New System.Drawing.Point(454, 141)
        CUSTOMER_IDLabel.Name = "CUSTOMER_IDLabel"
        CUSTOMER_IDLabel.Size = New System.Drawing.Size(85, 13)
        CUSTOMER_IDLabel.TabIndex = 22
        CUSTOMER_IDLabel.Text = "CUSTOMER ID:"
        '
        'CUSTOMER_IDTextBox
        '
        Me.CUSTOMER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "CUSTOMER ID", True))
        Me.CUSTOMER_IDTextBox.Location = New System.Drawing.Point(560, 138)
        Me.CUSTOMER_IDTextBox.Name = "CUSTOMER_IDTextBox"
        Me.CUSTOMER_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CUSTOMER_IDTextBox.TabIndex = 23
        '
        'DATELabel
        '
        DATELabel.AutoSize = True
        DATELabel.Location = New System.Drawing.Point(454, 168)
        DATELabel.Name = "DATELabel"
        DATELabel.Size = New System.Drawing.Size(39, 13)
        DATELabel.TabIndex = 24
        DATELabel.Text = "DATE:"
        '
        'DATEDateTimePicker
        '
        Me.DATEDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SHOPBindingSource, "DATE", True))
        Me.DATEDateTimePicker.Location = New System.Drawing.Point(560, 164)
        Me.DATEDateTimePicker.Name = "DATEDateTimePicker"
        Me.DATEDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DATEDateTimePicker.TabIndex = 25
        '
        'DISPATCHEDLabel
        '
        DISPATCHEDLabel.AutoSize = True
        DISPATCHEDLabel.Location = New System.Drawing.Point(454, 195)
        DISPATCHEDLabel.Name = "DISPATCHEDLabel"
        DISPATCHEDLabel.Size = New System.Drawing.Size(79, 13)
        DISPATCHEDLabel.TabIndex = 26
        DISPATCHEDLabel.Text = "DISPATCHED:"
        '
        'DISPATCHEDCheckBox
        '
        Me.DISPATCHEDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SHOPBindingSource, "DISPATCHED", True))
        Me.DISPATCHEDCheckBox.Location = New System.Drawing.Point(560, 190)
        Me.DISPATCHEDCheckBox.Name = "DISPATCHEDCheckBox"
        Me.DISPATCHEDCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.DISPATCHEDCheckBox.TabIndex = 27
        Me.DISPATCHEDCheckBox.Text = "CheckBox1"
        Me.DISPATCHEDCheckBox.UseVisualStyleBackColor = True
        '
        'PAIDLabel
        '
        PAIDLabel.AutoSize = True
        PAIDLabel.Location = New System.Drawing.Point(454, 225)
        PAIDLabel.Name = "PAIDLabel"
        PAIDLabel.Size = New System.Drawing.Size(35, 13)
        PAIDLabel.TabIndex = 28
        PAIDLabel.Text = "PAID:"
        '
        'PAIDCheckBox
        '
        Me.PAIDCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SHOPBindingSource, "PAID", True))
        Me.PAIDCheckBox.Location = New System.Drawing.Point(560, 220)
        Me.PAIDCheckBox.Name = "PAIDCheckBox"
        Me.PAIDCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.PAIDCheckBox.TabIndex = 29
        Me.PAIDCheckBox.Text = "CheckBox1"
        Me.PAIDCheckBox.UseVisualStyleBackColor = True
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Location = New System.Drawing.Point(454, 253)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(40, 13)
        TITLELabel.TabIndex = 30
        TITLELabel.Text = "TITLE:"
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "TITLE", True))
        Me.TITLETextBox.Location = New System.Drawing.Point(560, 250)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(200, 20)
        Me.TITLETextBox.TabIndex = 31
        '
        'FIRST_NAMELabel
        '
        FIRST_NAMELabel.AutoSize = True
        FIRST_NAMELabel.Location = New System.Drawing.Point(454, 279)
        FIRST_NAMELabel.Name = "FIRST_NAMELabel"
        FIRST_NAMELabel.Size = New System.Drawing.Size(75, 13)
        FIRST_NAMELabel.TabIndex = 32
        FIRST_NAMELabel.Text = "FIRST NAME:"
        '
        'FIRST_NAMETextBox
        '
        Me.FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SHOPBindingSource, "FIRST NAME", True))
        Me.FIRST_NAMETextBox.Location = New System.Drawing.Point(560, 276)
        Me.FIRST_NAMETextBox.Name = "FIRST_NAMETextBox"
        Me.FIRST_NAMETextBox.Size = New System.Drawing.Size(200, 20)
        Me.FIRST_NAMETextBox.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 661)
        Me.Controls.Add(PRODUCT_IDLabel)
        Me.Controls.Add(Me.PRODUCT_IDTextBox)
        Me.Controls.Add(PRODUCT_NAMELabel)
        Me.Controls.Add(Me.PRODUCT_NAMETextBox)
        Me.Controls.Add(CATEGORYLabel)
        Me.Controls.Add(Me.CATEGORYTextBox)
        Me.Controls.Add(SIZELabel)
        Me.Controls.Add(Me.SIZETextBox)
        Me.Controls.Add(UNIT_PRICELabel)
        Me.Controls.Add(Me.UNIT_PRICETextBox)
        Me.Controls.Add(STOCK_LEVELLabel)
        Me.Controls.Add(Me.STOCK_LEVELTextBox)
        Me.Controls.Add(REORDER_LEVELLabel)
        Me.Controls.Add(Me.REORDER_LEVELTextBox)
        Me.Controls.Add(MAXIMUM_LEVELLabel)
        Me.Controls.Add(Me.MAXIMUM_LEVELTextBox)
        Me.Controls.Add(ORDER_IDLabel)
        Me.Controls.Add(Me.ORDER_IDTextBox)
        Me.Controls.Add(QUANTITYLabel)
        Me.Controls.Add(Me.QUANTITYTextBox)
        Me.Controls.Add(CUSTOMER_IDLabel)
        Me.Controls.Add(Me.CUSTOMER_IDTextBox)
        Me.Controls.Add(DATELabel)
        Me.Controls.Add(Me.DATEDateTimePicker)
        Me.Controls.Add(DISPATCHEDLabel)
        Me.Controls.Add(Me.DISPATCHEDCheckBox)
        Me.Controls.Add(PAIDLabel)
        Me.Controls.Add(Me.PAIDCheckBox)
        Me.Controls.Add(TITLELabel)
        Me.Controls.Add(Me.TITLETextBox)
        Me.Controls.Add(FIRST_NAMELabel)
        Me.Controls.Add(Me.FIRST_NAMETextBox)
        Me.Controls.Add(Me.SHOPDataGridView)
        Me.Controls.Add(Me.SHOPBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.INVENTORYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOPBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SHOPBindingNavigator.ResumeLayout(False)
        Me.SHOPBindingNavigator.PerformLayout()
        CType(Me.SHOPDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents INVENTORYDataSet As INVENTORYDataSet
    Friend WithEvents SHOPBindingSource As BindingSource
    Friend WithEvents SHOPTableAdapter As INVENTORYDataSetTableAdapters.SHOPTableAdapter
    Friend WithEvents TableAdapterManager As INVENTORYDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SHOPBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SHOPBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SHOPDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents PRODUCT_IDTextBox As TextBox
    Friend WithEvents PRODUCT_NAMETextBox As TextBox
    Friend WithEvents CATEGORYTextBox As TextBox
    Friend WithEvents SIZETextBox As TextBox
    Friend WithEvents UNIT_PRICETextBox As TextBox
    Friend WithEvents STOCK_LEVELTextBox As TextBox
    Friend WithEvents REORDER_LEVELTextBox As TextBox
    Friend WithEvents MAXIMUM_LEVELTextBox As TextBox
    Friend WithEvents ORDER_IDTextBox As TextBox
    Friend WithEvents QUANTITYTextBox As TextBox
    Friend WithEvents CUSTOMER_IDTextBox As TextBox
    Friend WithEvents DATEDateTimePicker As DateTimePicker
    Friend WithEvents DISPATCHEDCheckBox As CheckBox
    Friend WithEvents PAIDCheckBox As CheckBox
    Friend WithEvents TITLETextBox As TextBox
    Friend WithEvents FIRST_NAMETextBox As TextBox
End Class
