<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        flowPanel = New FlowLayoutPanel()
        txtInput = New TextBox()
        btnDisplay = New Button()
        Label1 = New Label()
        chkAlwaysOnTop = New CheckBox()
        Label2 = New Label()
        txtSize = New TextBox()
        SuspendLayout()
        ' 
        ' flowPanel
        ' 
        flowPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flowPanel.AutoScroll = True
        flowPanel.Location = New Point(3, 38)
        flowPanel.Name = "flowPanel"
        flowPanel.Size = New Size(699, 422)
        flowPanel.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtInput.Location = New Point(79, 9)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(362, 23)
        txtInput.TabIndex = 1
        txtInput.Text = "Pack my box with five dozen liquor jugs."
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDisplay.Location = New Point(634, 3)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(68, 33)
        btnDisplay.TabIndex = 2
        btnDisplay.Text = "show me"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(5, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 3
        Label1.Text = "Sample text"
        ' 
        ' chkAlwaysOnTop
        ' 
        chkAlwaysOnTop.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        chkAlwaysOnTop.AutoSize = True
        chkAlwaysOnTop.Location = New Point(525, 11)
        chkAlwaysOnTop.Name = "chkAlwaysOnTop"
        chkAlwaysOnTop.Size = New Size(103, 19)
        chkAlwaysOnTop.TabIndex = 4
        chkAlwaysOnTop.Text = "Always on Top"
        chkAlwaysOnTop.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(447, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 15)
        Label2.TabIndex = 5
        Label2.Text = "Size"
        ' 
        ' txtSize
        ' 
        txtSize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtSize.Location = New Point(480, 9)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(39, 23)
        txtSize.TabIndex = 6
        txtSize.Text = "18"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(705, 462)
        Controls.Add(txtSize)
        Controls.Add(Label2)
        Controls.Add(chkAlwaysOnTop)
        Controls.Add(Label1)
        Controls.Add(btnDisplay)
        Controls.Add(txtInput)
        Controls.Add(flowPanel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(721, 501)
        Name = "Form1"
        Text = "Font Samples for instaled fonts v1.2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flowPanel As FlowLayoutPanel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chkAlwaysOnTop As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSize As TextBox

End Class
