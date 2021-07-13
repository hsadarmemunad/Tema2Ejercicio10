<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioAsk5AnsC = New System.Windows.Forms.RadioButton()
        Me.RadioAsk5AnsB = New System.Windows.Forms.RadioButton()
        Me.RadioAsk5AnsA = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioAsk4AnsC = New System.Windows.Forms.RadioButton()
        Me.RadioAsk4AnsB = New System.Windows.Forms.RadioButton()
        Me.RadioAsk4AnsA = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioAsk3AnsC = New System.Windows.Forms.RadioButton()
        Me.RadioAsk3AnsB = New System.Windows.Forms.RadioButton()
        Me.RadioAsk3AnsA = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioAsk2AnsC = New System.Windows.Forms.RadioButton()
        Me.RadioAsk2AnsB = New System.Windows.Forms.RadioButton()
        Me.RadioAsk2AnsA = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioAsk1AnsC = New System.Windows.Forms.RadioButton()
        Me.RadioAsk1AnsB = New System.Windows.Forms.RadioButton()
        Me.RadioAsk1AnsA = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.ButtonEnd = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 989)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.ButtonEnd)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 983)
        Me.Panel2.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioAsk5AnsC)
        Me.GroupBox5.Controls.Add(Me.RadioAsk5AnsB)
        Me.GroupBox5.Controls.Add(Me.RadioAsk5AnsA)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 691)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(954, 170)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pregunta 5"
        '
        'RadioAsk5AnsC
        '
        Me.RadioAsk5AnsC.AutoSize = True
        Me.RadioAsk5AnsC.Location = New System.Drawing.Point(27, 123)
        Me.RadioAsk5AnsC.Name = "RadioAsk5AnsC"
        Me.RadioAsk5AnsC.Size = New System.Drawing.Size(903, 38)
        Me.RadioAsk5AnsC.TabIndex = 5
        Me.RadioAsk5AnsC.TabStop = True
        Me.RadioAsk5AnsC.Text = "No haces caso a esos mensajes, ya que aunque instales las actualizaciones, al poc" &
    "o tiempo el ordenador vuelve mostrarte por pantalla el " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aviso. "
        Me.RadioAsk5AnsC.UseVisualStyleBackColor = True
        '
        'RadioAsk5AnsB
        '
        Me.RadioAsk5AnsB.AutoSize = True
        Me.RadioAsk5AnsB.Location = New System.Drawing.Point(27, 79)
        Me.RadioAsk5AnsB.Name = "RadioAsk5AnsB"
        Me.RadioAsk5AnsB.Size = New System.Drawing.Size(882, 38)
        Me.RadioAsk5AnsB.TabIndex = 4
        Me.RadioAsk5AnsB.TabStop = True
        Me.RadioAsk5AnsB.Text = "Cierras la ventana y decides actualizar después, en ese momento estás liado y lo " &
    "que menos te apetece es esperar a que se reinicie el" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ordenador. "
        Me.RadioAsk5AnsB.UseVisualStyleBackColor = True
        '
        'RadioAsk5AnsA
        '
        Me.RadioAsk5AnsA.AutoSize = True
        Me.RadioAsk5AnsA.Location = New System.Drawing.Point(27, 52)
        Me.RadioAsk5AnsA.Name = "RadioAsk5AnsA"
        Me.RadioAsk5AnsA.Size = New System.Drawing.Size(718, 21)
        Me.RadioAsk5AnsA.TabIndex = 3
        Me.RadioAsk5AnsA.TabStop = True
        Me.RadioAsk5AnsA.Text = "Eres una persona muy obediente y si el ordenador dice que lo tienes que actualiza" &
    "r, pues actualizas y punto."
        Me.RadioAsk5AnsA.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(813, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "¿Qué debes hacer si Windows te muestra una ventana diciéndote que hay actualizaci" &
    "ones pendientes de instalar en el equipo?"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioAsk4AnsC)
        Me.GroupBox4.Controls.Add(Me.RadioAsk4AnsB)
        Me.GroupBox4.Controls.Add(Me.RadioAsk4AnsA)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 508)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(954, 170)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pregunta 4"
        '
        'RadioAsk4AnsC
        '
        Me.RadioAsk4AnsC.AutoSize = True
        Me.RadioAsk4AnsC.Location = New System.Drawing.Point(27, 107)
        Me.RadioAsk4AnsC.Name = "RadioAsk4AnsC"
        Me.RadioAsk4AnsC.Size = New System.Drawing.Size(414, 21)
        Me.RadioAsk4AnsC.TabIndex = 5
        Me.RadioAsk4AnsC.TabStop = True
        Me.RadioAsk4AnsC.Text = "No, ninguna de las contraseñas anteriores te parece segura."
        Me.RadioAsk4AnsC.UseVisualStyleBackColor = True
        '
        'RadioAsk4AnsB
        '
        Me.RadioAsk4AnsB.AutoSize = True
        Me.RadioAsk4AnsB.Location = New System.Drawing.Point(27, 79)
        Me.RadioAsk4AnsB.Name = "RadioAsk4AnsB"
        Me.RadioAsk4AnsB.Size = New System.Drawing.Size(645, 21)
        Me.RadioAsk4AnsB.TabIndex = 4
        Me.RadioAsk4AnsB.TabStop = True
        Me.RadioAsk4AnsB.Text = "'123asdZXC', sí es segura porque tiene más de 8 caracteres, minúsculas, mayúscula" &
    "s y números."
        Me.RadioAsk4AnsB.UseVisualStyleBackColor = True
        '
        'RadioAsk4AnsA
        '
        Me.RadioAsk4AnsA.AutoSize = True
        Me.RadioAsk4AnsA.Location = New System.Drawing.Point(27, 52)
        Me.RadioAsk4AnsA.Name = "RadioAsk4AnsA"
        Me.RadioAsk4AnsA.Size = New System.Drawing.Size(804, 21)
        Me.RadioAsk4AnsA.TabIndex = 3
        Me.RadioAsk4AnsA.TabStop = True
        Me.RadioAsk4AnsA.Text = "'14081980', sí es segura, es un código numérico y además cómo es tu fecha de cump" &
    "leaños puedes recordarla fácilmente."
        Me.RadioAsk4AnsA.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(343, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "¿Crees que son seguras las siguientes contraseñas?"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioAsk3AnsC)
        Me.GroupBox3.Controls.Add(Me.RadioAsk3AnsB)
        Me.GroupBox3.Controls.Add(Me.RadioAsk3AnsA)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 332)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(954, 170)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pregunta 3"
        '
        'RadioAsk3AnsC
        '
        Me.RadioAsk3AnsC.AutoSize = True
        Me.RadioAsk3AnsC.Location = New System.Drawing.Point(27, 124)
        Me.RadioAsk3AnsC.Name = "RadioAsk3AnsC"
        Me.RadioAsk3AnsC.Size = New System.Drawing.Size(743, 21)
        Me.RadioAsk3AnsC.TabIndex = 5
        Me.RadioAsk3AnsC.TabStop = True
        Me.RadioAsk3AnsC.Text = "Sí, aunque una vez que eliminamos el virus del ordenador podemos recuperar toda l" &
    "a información sin problemas."
        Me.RadioAsk3AnsC.UseVisualStyleBackColor = True
        '
        'RadioAsk3AnsB
        '
        Me.RadioAsk3AnsB.AutoSize = True
        Me.RadioAsk3AnsB.Location = New System.Drawing.Point(27, 96)
        Me.RadioAsk3AnsB.Name = "RadioAsk3AnsB"
        Me.RadioAsk3AnsB.Size = New System.Drawing.Size(661, 21)
        Me.RadioAsk3AnsB.TabIndex = 4
        Me.RadioAsk3AnsB.TabStop = True
        Me.RadioAsk3AnsB.Text = "Sí, algunos virus pueden provocar la destrucción o borrado de los archivos y qued" &
    "ar irrecuperables."
        Me.RadioAsk3AnsB.UseVisualStyleBackColor = True
        '
        'RadioAsk3AnsA
        '
        Me.RadioAsk3AnsA.AutoSize = True
        Me.RadioAsk3AnsA.Location = New System.Drawing.Point(27, 52)
        Me.RadioAsk3AnsA.Name = "RadioAsk3AnsA"
        Me.RadioAsk3AnsA.Size = New System.Drawing.Size(904, 38)
        Me.RadioAsk3AnsA.TabIndex = 3
        Me.RadioAsk3AnsA.TabStop = True
        Me.RadioAsk3AnsA.Text = "Mentira, eso es un bulo que circula para meternos miedo a los usuarios. Los virus" &
    " lo que hacen es estropear el ordenador impidiendo que " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "funcione correctamente." &
    ""
        Me.RadioAsk3AnsA.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(516, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Un virus informático es capaz de borrar las fotos almacenadas en un ordenador."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioAsk2AnsC)
        Me.GroupBox2.Controls.Add(Me.RadioAsk2AnsB)
        Me.GroupBox2.Controls.Add(Me.RadioAsk2AnsA)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(954, 170)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pregunta 2"
        '
        'RadioAsk2AnsC
        '
        Me.RadioAsk2AnsC.AutoSize = True
        Me.RadioAsk2AnsC.Location = New System.Drawing.Point(27, 108)
        Me.RadioAsk2AnsC.Name = "RadioAsk2AnsC"
        Me.RadioAsk2AnsC.Size = New System.Drawing.Size(867, 38)
        Me.RadioAsk2AnsC.TabIndex = 5
        Me.RadioAsk2AnsC.TabStop = True
        Me.RadioAsk2AnsC.Text = "Es un conjunto de ordenadores infectados por un mismo tipo de virus y que es cont" &
    "rolado por un ciberdelincuente para llevar a cabo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "acciones maliciosas."
        Me.RadioAsk2AnsC.UseVisualStyleBackColor = True
        '
        'RadioAsk2AnsB
        '
        Me.RadioAsk2AnsB.AutoSize = True
        Me.RadioAsk2AnsB.Location = New System.Drawing.Point(27, 80)
        Me.RadioAsk2AnsB.Name = "RadioAsk2AnsB"
        Me.RadioAsk2AnsB.Size = New System.Drawing.Size(575, 21)
        Me.RadioAsk2AnsB.TabIndex = 4
        Me.RadioAsk2AnsB.TabStop = True
        Me.RadioAsk2AnsB.Text = "Es una red privada de ordenadores que está protegida frente a amenazas de Interne" &
    "t."
        Me.RadioAsk2AnsB.UseVisualStyleBackColor = True
        '
        'RadioAsk2AnsA
        '
        Me.RadioAsk2AnsA.AutoSize = True
        Me.RadioAsk2AnsA.Location = New System.Drawing.Point(27, 52)
        Me.RadioAsk2AnsA.Name = "RadioAsk2AnsA"
        Me.RadioAsk2AnsA.Size = New System.Drawing.Size(828, 21)
        Me.RadioAsk2AnsA.TabIndex = 3
        Me.RadioAsk2AnsA.TabStop = True
        Me.RadioAsk2AnsA.Text = "Un tipo de conexión a Internet cuya principal característica es que por las noche" &
    "s permite una mayor velocidad de navegación."
        Me.RadioAsk2AnsA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "¿Qué es una red zombi?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioAsk1AnsC)
        Me.GroupBox1.Controls.Add(Me.RadioAsk1AnsB)
        Me.GroupBox1.Controls.Add(Me.RadioAsk1AnsA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(954, 147)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pregunta 1"
        '
        'RadioAsk1AnsC
        '
        Me.RadioAsk1AnsC.AutoSize = True
        Me.RadioAsk1AnsC.Location = New System.Drawing.Point(27, 108)
        Me.RadioAsk1AnsC.Name = "RadioAsk1AnsC"
        Me.RadioAsk1AnsC.Size = New System.Drawing.Size(525, 21)
        Me.RadioAsk1AnsC.TabIndex = 5
        Me.RadioAsk1AnsC.TabStop = True
        Me.RadioAsk1AnsC.Text = "Si, podrías estar compartiendo material ilegal o ficheros maliciosos sin saberlo." &
    ""
        Me.RadioAsk1AnsC.UseVisualStyleBackColor = True
        '
        'RadioAsk1AnsB
        '
        Me.RadioAsk1AnsB.AutoSize = True
        Me.RadioAsk1AnsB.Location = New System.Drawing.Point(27, 80)
        Me.RadioAsk1AnsB.Name = "RadioAsk1AnsB"
        Me.RadioAsk1AnsB.Size = New System.Drawing.Size(891, 21)
        Me.RadioAsk1AnsB.TabIndex = 4
        Me.RadioAsk1AnsB.TabStop = True
        Me.RadioAsk1AnsB.Text = "No, aunque es recomendable para eliminar todo lo que no sea de tu interés y así e" &
    "vitas ocupar memoria en el ordenador sin necesidad. "
        Me.RadioAsk1AnsB.UseVisualStyleBackColor = True
        '
        'RadioAsk1AnsA
        '
        Me.RadioAsk1AnsA.AutoSize = True
        Me.RadioAsk1AnsA.Location = New System.Drawing.Point(27, 52)
        Me.RadioAsk1AnsA.Name = "RadioAsk1AnsA"
        Me.RadioAsk1AnsA.Size = New System.Drawing.Size(594, 21)
        Me.RadioAsk1AnsA.TabIndex = 3
        Me.RadioAsk1AnsA.TabStop = True
        Me.RadioAsk1AnsA.Text = "En principio no es necesario, generalmente siempre se  descarga lo que estás busc" &
    "ando."
        Me.RadioAsk1AnsA.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "¿Es necesario que compruebes los ficheros que descargas a través de redes P2P?"
        '
        'Timer1
        '
        '
        'LabelTimer
        '
        Me.LabelTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimer.ForeColor = System.Drawing.Color.Red
        Me.LabelTimer.Location = New System.Drawing.Point(11, 19)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(983, 31)
        Me.LabelTimer.TabIndex = 1
        Me.LabelTimer.Text = "03:00"
        Me.LabelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonEnd
        '
        Me.ButtonEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnd.Location = New System.Drawing.Point(403, 890)
        Me.ButtonEnd.Name = "ButtonEnd"
        Me.ButtonEnd.Size = New System.Drawing.Size(128, 37)
        Me.ButtonEnd.TabIndex = 12
        Me.ButtonEnd.Text = "Terminar"
        Me.ButtonEnd.UseVisualStyleBackColor = True
        '
        'Quiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1006, 721)
        Me.Controls.Add(Me.LabelTimer)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Quiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioAsk5AnsC As RadioButton
    Friend WithEvents RadioAsk5AnsB As RadioButton
    Friend WithEvents RadioAsk5AnsA As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioAsk4AnsC As RadioButton
    Friend WithEvents RadioAsk4AnsB As RadioButton
    Friend WithEvents RadioAsk4AnsA As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioAsk3AnsC As RadioButton
    Friend WithEvents RadioAsk3AnsB As RadioButton
    Friend WithEvents RadioAsk3AnsA As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioAsk2AnsC As RadioButton
    Friend WithEvents RadioAsk2AnsB As RadioButton
    Friend WithEvents RadioAsk2AnsA As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioAsk1AnsC As RadioButton
    Friend WithEvents RadioAsk1AnsB As RadioButton
    Friend WithEvents RadioAsk1AnsA As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTimer As Label
    Friend WithEvents ButtonEnd As Button
End Class
