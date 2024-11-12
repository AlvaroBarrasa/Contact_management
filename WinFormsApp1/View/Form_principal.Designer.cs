namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se están utilizando.
        /// </summary>
        /// <param name="disposing">Indica si los recursos administrados deben ser eliminados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el diseñador de Windows Forms

        /// <summary>
        /// Método necesario para el diseñador de Windows Forms.
        /// No se debe modificar el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            labelAddress = new Label();
            labelTown = new Label();
            labelPostalCode = new Label();
            labelCountry = new Label();
            labelBirthday = new Label();
            labelProfilePicture = new Label();
            labelPhone = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtTown = new TextBox();
            txtPostalCode = new TextBox();
            txtCountry = new TextBox();
            dateTimePickerBirthday = new DateTimePicker();
            pictureBoxProfilePicture = new PictureBox();
            btnCargarImagen = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dataGridViewContactos = new DataGridView();
            txtTelefono = new TextBox();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Location = new Point(15, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(100, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(15, 40);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(100, 20);
            labelAddress.TabIndex = 0;
            labelAddress.Text = "Address:";
            // 
            // labelTown
            // 
            labelTown.Location = new Point(15, 70);
            labelTown.Name = "labelTown";
            labelTown.Size = new Size(100, 20);
            labelTown.TabIndex = 0;
            labelTown.Text = "Town:";
            // 
            // labelPostalCode
            // 
            labelPostalCode.Location = new Point(15, 100);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(100, 20);
            labelPostalCode.TabIndex = 0;
            labelPostalCode.Text = "Postal Code:";
            // 
            // labelCountry
            // 
            labelCountry.Location = new Point(15, 130);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(100, 20);
            labelCountry.TabIndex = 0;
            labelCountry.Text = "Country:";
            // 
            // labelBirthday
            // 
            labelBirthday.Location = new Point(15, 160);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(100, 20);
            labelBirthday.TabIndex = 0;
            labelBirthday.Text = "Birthday:";
            // 
            // labelProfilePicture
            // 
            labelProfilePicture.Location = new Point(15, 190);
            labelProfilePicture.Name = "labelProfilePicture";
            labelProfilePicture.Size = new Size(100, 20);
            labelProfilePicture.TabIndex = 0;
            labelProfilePicture.Text = "Profile Picture:";
            // 
            // labelPhone
            // 
            labelPhone.Location = new Point(15, 150);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 20);
            labelPhone.TabIndex = 0;
            labelPhone.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 10);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 40);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 13;
            // 
            // txtTown
            // 
            txtTown.Location = new Point(120, 70);
            txtTown.Name = "txtTown";
            txtTown.Size = new Size(200, 23);
            txtTown.TabIndex = 12;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(120, 100);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(200, 23);
            txtPostalCode.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(120, 130);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(200, 23);
            txtCountry.TabIndex = 10;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(120, 189);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(250, 23);
            dateTimePickerBirthday.TabIndex = 5;
            // 
            // pictureBoxProfilePicture
            // 
            pictureBoxProfilePicture.BackColor = Color.Transparent;
            pictureBoxProfilePicture.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProfilePicture.Location = new Point(450, 30);
            pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            pictureBoxProfilePicture.Size = new Size(100, 100);
            pictureBoxProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfilePicture.TabIndex = 6;
            pictureBoxProfilePicture.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Location = new Point(450, 140);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(100, 23);
            btnCargarImagen.TabIndex = 7;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(150, 227);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(300, 227);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += LimpiarCampos;
            // 
            // dataGridViewContactos
            // 
            dataGridViewContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContactos.Location = new Point(12, 356);
            dataGridViewContactos.Name = "dataGridViewContactos";
            dataGridViewContactos.Size = new Size(600, 200);
            dataGridViewContactos.TabIndex = 0;
            dataGridViewContactos.TabStop = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(120, 159);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 23);
            txtTelefono.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(250, 257);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(784, 661);
            Controls.Add(txtTelefono);
            Controls.Add(dataGridViewContactos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargarImagen);
            Controls.Add(pictureBoxProfilePicture);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(txtCountry);
            Controls.Add(txtPostalCode);
            Controls.Add(txtTown);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Gestión de Contactos";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelProfilePicture;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridViewContactos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dataGridViewTelefonos;
        private System.Windows.Forms.Button btnEliminarTelefono;
    }
}
