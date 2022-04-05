using CRUD_DB_Empleados.Controllers;
using CRUD_DB_Empleados.Models;
using System.Data;

namespace CRUD_DB_Empleados
{
    public partial class CrudForm : Form
    {
        public CrudForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillTable();
        }

    

        //Este metodo limpiara los campos en la tabla
        private void cleanTable()
        {
            tNumeroDocumento.Text = "";
            tNombres.Text = "";
            tDireccion.Text = "";
            tApellidos.Text = "";
            tEdad.Text = "";
        }

        //este metodo rellenara el GRID de los datos de la Base de datos
        private void fillTable()
        {
            DataTable data = Rules.EmpleadosConsult();
            if(data == null)
            {
                MessageBox.Show("data could not be accessed");
            }
            else
            {
                dataTableGrid.DataSource = data.DefaultView;
            }
        }

        bool consultaHecha = false;

        //este metodo controla la accion del click "Save"
        private void Save_Click(object sender, EventArgs e)
        {

            //valido todos los campos posibles
            if(tNumeroDocumento.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a document number");
            }
            else if(tNombres.Text.Trim().Length < 5)
            {
                MessageBox.Show("Please enter a longer name");
            }
            else if(tApellidos.Text.Trim().Length < 5)
            {
                MessageBox.Show("Please enter a longer surname");
            }
            else if(tDireccion.Text.Trim().ToLower().Length < 3)
            {
                MessageBox.Show("Please enter a direction correctly");
            }
            else
            {
                //si no se cumple ninguna condicion anterior, ejecuta este codigo
                try
                {
                    Empleados empleados = new Empleados();

                    empleados.Document = tNumeroDocumento.Text.Trim();
                    empleados.Names = tNombres.Text.Trim();
                    empleados.Surname = tApellidos.Text.Trim();
                    empleados.Direction = tDireccion.Text.Trim();
                    empleados.Age = Convert.ToInt32(tEdad.Text.Trim());
                    empleados.Dateofbirth = dateTime.Value.Year + "-" + dateTime.Value.Month + "-" + dateTime.Value.Day;

                    if(Rules.SaveEmpleado(empleados))
                    {
                        fillTable();
                        cleanTable();
                        MessageBox.Show("has been saved successfully");
                        consultaHecha = false;
                    }
                    else
                    {
                        MessageBox.Show("There is already another employee with the same document");
                    }
                }
                catch(Exception ex)
                {

                    MessageBox.Show("An error occurred while saving the information" + ex.Message);
                }
            }
        }

        //este metodo le dara funcionalidad al boton de consulta
        private void Consult_Click(object sender, EventArgs e)
        {
            //valido todos los campos posibles
            if(tNumeroDocumento.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a document number");
            }
            else
            {
                Empleados empleados = Rules.ConsultarEmpleado(tNumeroDocumento.Text.Trim());
                if(empleados == null)
                {
                    MessageBox.Show("The employee with this document does not exist: " + tNumeroDocumento.Text);

                    cleanTable();

                    consultaHecha = false;
                }
                else
                {
                    tNumeroDocumento.Text = empleados.Document;
                    tNombres.Text = empleados.Names;
                    tDireccion.Text = empleados.Direction;
                    tApellidos.Text = empleados.Surname;
                    tEdad.Text = empleados.Age.ToString();
                    dateTime.Text = empleados.Dateofbirth;

                    consultaHecha = true;
                }
            }
        }

        //este metodo le dara funcionalidad al boton de actualizar
        private void Update_Click(object sender, EventArgs e)
        {
            if(!consultaHecha)
            {
                MessageBox.Show("you should consult the employee first");
            }
            //valido todos los campos posibles
            else if(tNumeroDocumento.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a document number");
            }
            else if(tNombres.Text.Trim().Length < 5)
            {
                MessageBox.Show("Please enter a longer name");
            }
            else if(tApellidos.Text.Trim().Length < 5)
            {
                MessageBox.Show("Please enter a longer surname");
            }
            else if(tDireccion.Text.Trim().ToLower().Length < 3)
            {
                MessageBox.Show("Please enter a direction correctly");
            }
            else
            {
                //si no se cumple ninguna condicion anterior, ejecuta este codigo
                try
                {
                    Empleados empleados = new Empleados();

                    empleados.Document = tNumeroDocumento.Text.Trim();
                    empleados.Names = tNombres.Text.Trim();
                    empleados.Surname = tApellidos.Text.Trim();
                    empleados.Direction = tDireccion.Text.Trim();
                    empleados.Age = Convert.ToInt32(tEdad.Text.Trim());
                    empleados.Dateofbirth = dateTime.Value.Year + "-" + dateTime.Value.Month + "-" + dateTime.Value.Day;

                    if(Rules.UpdateEmpleado(empleados))
                    {
                        fillTable();
                        cleanTable();
                        MessageBox.Show("has been saved successfully");
                    }
                    else
                    {
                        MessageBox.Show("Could not update");
                    }
                }
                catch(Exception ex)
                {

                    MessageBox.Show("An error occurred while saving the information" + ex.Message);
                }
            }
        }

        //este emtodo le daremos funcionalidad al boton de delete
        private void Delete_Click(object sender, EventArgs e)
        {

            if(!consultaHecha)
            {
                MessageBox.Show("you should consult the employee first");
            }
            //valido todos los campos posibles
            else if(tNumeroDocumento.Text.Trim() == "")
            {
                MessageBox.Show("You must enter a document number");
            }
            else if(DialogResult.Yes == MessageBox.Show(null, "do you really want to delete?", "ok", MessageBoxButtons.YesNo))
            {

                //si no se cumple ninguna condicion anterior, ejecuta este codigo
                try
                {

                    if(Rules.DeleteEmpleado(tNumeroDocumento.Text.Trim()))
                    {
                        fillTable();
                        cleanTable();
                        MessageBox.Show("Eliminated Employee");
                    }
                    else
                    {
                        MessageBox.Show("could not be removed");
                    }
                }
                catch(Exception ex)
                {

                    MessageBox.Show("An error occurred while saving the information" + ex.Message);
                }
            }
        }
    }
}