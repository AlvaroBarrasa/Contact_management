using Contact_management.Controller;
using Contact_management.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ContactController _contactController;
        private Contact _contactoActual;

        public Form1()
        {
            InitializeComponent();
            _contactController = new ContactController();
            CargarContactos();
        }

        private void CargarContactos()
        {
            dataGridViewContactos.DataSource = _contactController.GetContacts();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_contactoActual == null)
            {
                var nuevoContacto = new Contact
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Town = txtTown.Text,
                    PostalCode = txtPostalCode.Text,
                    Country = txtCountry.Text,
                    Birthday = dateTimePickerBirthday.Value,
                    ProfilePicture = ConvertirImagenABytes(pictureBoxProfilePicture.Image)
                };

                _contactController.AddContact(nuevoContacto);
                MessageBox.Show("Contacto agregado exitosamente.");
            }
            else
            {
                _contactoActual.Name = txtName.Text;
                _contactoActual.Address = txtAddress.Text;
                _contactoActual.Town = txtTown.Text;
                _contactoActual.PostalCode = txtPostalCode.Text;
                _contactoActual.Country = txtCountry.Text;
                _contactoActual.Birthday = dateTimePickerBirthday.Value;
                _contactoActual.ProfilePicture = ConvertirImagenABytes(pictureBoxProfilePicture.Image);

                _contactController.ModifyContacts(_contactoActual.Id, _contactoActual);
                MessageBox.Show("Contacto modificado exitosamente.");
            }

            LimpiarCampos();
            CargarContactos();
        }

        private byte[] ConvertirImagenABytes(System.Drawing.Image imagen)
        {
            if (imagen != null)
            {
                using (var memoryStream = new System.IO.MemoryStream())
                {
                    imagen.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return memoryStream.ToArray();
                }
            }
            return null;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfilePicture.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }
        
        private void LimpiarCampos()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtTown.Clear();
            txtPostalCode.Clear();
            txtCountry.Clear();
            txtTelefono.Clear();
            pictureBoxProfilePicture.Image = null;
            _contactoActual = null; 
        }

        
        private void dataGridViewContactos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewContactos.SelectedRows.Count > 0)
            {
                int idContacto = (int)dataGridViewContactos.SelectedRows[0].Cells["Id"].Value;
                _contactoActual = _contactController.GetContacts().FirstOrDefault(c => c.Id == idContacto);

                if (_contactoActual != null)
                {
                    txtName.Text = _contactoActual.Name;
                    txtAddress.Text = _contactoActual.Address;
                    txtTown.Text = _contactoActual.Town;
                    txtPostalCode.Text = _contactoActual.PostalCode;
                    txtCountry.Text = _contactoActual.Country;
                    dateTimePickerBirthday.Value = _contactoActual.Birthday ?? DateTime.Now;
                    pictureBoxProfilePicture.Image = ConvertirBytesAImagen(_contactoActual.ProfilePicture);
                }
            }
        }

        private System.Drawing.Image ConvertirBytesAImagen(byte[] bytes)
        {
            if (bytes != null)
            {
                using (var memoryStream = new System.IO.MemoryStream(bytes))
                {
                    return System.Drawing.Image.FromStream(memoryStream);
                }
            }
            return null;
        }
    }
}

