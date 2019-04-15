using ClinicApp.Controller;
using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicApp.UserControls
{
    /// <summary>
    /// User Control for getting and adding patient Appointment objects
    /// </summary>
    public partial class AddAppointmentUserControl : UserControl, IUserControlSearch
    {
        private readonly PatientController patientController;
        private readonly AppointmentController appointmentController;
        public Patient patient;
        private List<Appointment> appointmentList;

        /// <summary>
        /// Constructor; initializes the User Control and the Controller objects
        /// </summary>
        public AddAppointmentUserControl()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.patientController = new PatientController();
            personSearchUserControl.SetPersonType(new Patient());
            personSearchUserControl.GetPersonButtonClicked += personSearchUserControl_GetPersonButtonClicked;
            personSearchUserControl.ClearButtonClicked += personSearchUserControl_ClearButtonClicked;
        }

        private void AddAppointmentUserControl_Load(object sender, EventArgs e)
        {
            this.RefreshPage();
            this.ActiveControl = personSearchUserControl;
        }

        /// <summary>
        /// The method to run when the GetPerson Button in PersonSearchUserControl is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personSearchUserControl_GetPersonButtonClicked(object sender, EventArgs e)
        {
            //personSearchUserControl.RefreshPerson();
            patient = personSearchUserControl.patient;
            patientBindingSource.Clear();
            patientBindingSource.Add(patient);
            RefreshPage();
        }

        /// <summary>
        /// The method to run when the Clear button in PersonSearchUserControl is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personSearchUserControl_ClearButtonClicked(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// Refreshes the page with the current Patient object and gets Appointment list
        /// </summary>
        public void RefreshPage()
        {
            btnAddAppointment.Enabled = false;
            if (this.patient != null)
            {
                patientBindingSource.Add(patient);
                this.GetAppointmentList(this.patient.PatientID);
                btnAddAppointment.Enabled = true;
            }
            else
            {
                if (this.appointmentList != null)
                {
                    appointmentList.Clear();
                }
            }
        }

        private void GetAppointmentList(int patientID)
        {
            try
            {
                appointmentList = appointmentController.GetAppointmentsByPatientID(patientID);
                appointmentDataGridView.DataSource = appointmentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void Clear()
        {
            patientBindingSource.Clear();
            appointmentDataGridView.DataSource = null;
            appointmentDataGridView.Refresh();
            btnAddAppointment.Enabled = false;
            this.ActiveControl = personSearchUserControl;
        }


        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int i = e.RowIndex;
                DataGridViewRow row = appointmentDataGridView.Rows[i];
                Appointment appointment = (Appointment)row.DataBoundItem;

                AddUpdateAppointmentDialog addApptForm = new AddUpdateAppointmentDialog();
                addApptForm.patient = this.patient;
                addApptForm.appointment = appointment;
                addApptForm.addAppointment = false;
                addApptForm.ShowDialog();
                this.RefreshPage();
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddUpdateAppointmentDialog addApptForm = new AddUpdateAppointmentDialog();
            addApptForm.patient = this.patient;
            addApptForm.addAppointment = true;
            addApptForm.ShowDialog();
            this.RefreshPage();
        }
    }
}
