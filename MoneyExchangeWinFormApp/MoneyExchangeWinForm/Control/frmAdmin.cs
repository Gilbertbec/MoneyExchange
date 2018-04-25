namespace MoneyExchangeWinForm
{
    using HelpLibrary;
    using MoneyExchange.BLL;
    using MoneyExchange.Data.Entities;
    using MoneyExchangeWinForm.Model.Concrete;
    using System;
    using System.Windows.Forms;

    public partial class frmAdmin<T> : Form where T : R, new()
    {
        IObjectsManageStateMachine<T> Sm;

        public frmAdmin()
        {
            InitializeComponent();
        }

        public void LoadSm()
        {
            string className = string.Empty;
            Type type = null;
            switch (GlobalConfig.ImplementationPlan)
            {
                case ImplementationPlan.ImplementationPlanByArray:
                    type = typeof(ObjectsManageStateMachineByArray<>);
                    break;
                case ImplementationPlan.ImplementationPlanByList:
                    type = typeof(ObjectsManageStateMachineByList<>);
                    break;
            }
            type = type.MakeGenericType(new Type[] { typeof(T) });
            Sm = (IObjectsManageStateMachine<T>)Activator.CreateInstance(type);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadSm();
            TReadService<T> exchangeRateReadService = new TReadService<T>();
            Sm.Collection = exchangeRateReadService.GetExchangeRateFromFile();

            UpdateState(State.Loaded);
            lblPosition.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reset();
            Sm.CurrentIndex = Sm.CollectionCount;
            lblPosition.Text = string.Format($"The {Sm.CurrentIndex + 1} th currency");
            UpdateState(State.Adding);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            T t = GetExchangeRateFromUI();
            if (t == null)
            { return; }

            Sm.Save(t);
            DisplayToUIAndUpdateState(Sm.CurrentInstance, State.Saved);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Sm.Collection.IsNullOrEmpty())
            { return; }

            Sm.Delete(Sm.CurrentIndex);

            Reset();
            UpdateState(State.Deleted);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Sm.Collection.IsNullOrEmpty())
            { return; }

            DisplayToUIAndUpdateState(Sm.CurrentInstance, State.Editing);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (Sm.Collection.IsNullOrEmpty())
            { return; }

            DisplayToUIAndUpdateState(Sm.GetFirst(), Sm.CurrentState);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (Sm.Collection.IsNullOrEmpty())
            { return; }

            DisplayToUIAndUpdateState(Sm.GetLast(), State.Browsing);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (Sm.Collection.IsNullOrEmpty())
            { return; }

            DisplayToUIAndUpdateState(Sm.GetPrevious(), State.Browsing);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Sm.Collection.IsNullOrEmpty() || Sm.CurrentIndex == Sm.CollectionCount)//when user just clicked Add button
            { return; }

            DisplayToUIAndUpdateState(Sm.GetNext(), State.Browsing);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            TWriteService<T> exchangeRateWriteService = new TWriteService<T>();
            exchangeRateWriteService.WriteExchangeRateToFile(Sm.Collection);
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationHelper.VilidationForDecimal(sender, e);
        }

        T GetExchangeRateFromUI()
        {
            if (!(txtName.IsNotEmpty() && txtValue.IsNotEmpty() && txtCountryName.IsNotEmpty()))
            { return null; }

            string currencyName = txtName.Text.Trim();
            decimal value = Convert.ToDecimal(txtValue.Text.Trim());
            string countryName = txtCountryName.Text.Trim();
            T exchangeRate = new T()
            {
                CountryName = countryName,
                CurrencyName = currencyName,
                Value = value
            };
            return exchangeRate;
        }

        void DisplayToUI(T t)
        {
            if (Sm.Collection.IsNullOrEmpty())
            { return; }

            txtName.Text = t.CurrencyName;
            txtCountryName.Text = t.CountryName;
            txtValue.Text = t.Value.ToString();
            lblPosition.Text = string.Format($"The {Sm.CurrentIndex + 1} th currency");
        }

        void DisplayToUIAndUpdateState(T t, State state)
        {
            DisplayToUI(t);
            UpdateState(state);
        }

        void Reset()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
            lblPosition.Text = string.Empty;
            UpdateState(State.Loaded);
        }

        void UpdateState(State state)
        {
            Sm.CurrentState = state;
            switch (Sm.CurrentState)
            {
                case State.Adding:
                case State.Editing:
                    btnSave.Enabled = txtCountryName.Enabled = txtName.Enabled = txtValue.Enabled = true;
                    break;
                case State.Loaded:
                case State.Saved:
                case State.Deleted:
                case State.Browsing:
                    btnSave.Enabled = txtCountryName.Enabled = txtName.Enabled = txtValue.Enabled = false;
                    break;
            }
        }
    }
}
