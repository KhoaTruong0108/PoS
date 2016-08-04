using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lhk.POS.Core.Util;
using lhk.POS.Core.Domain;

namespace lhk.POS.Presentation.Views
{
    public partial class ProductGridView : UserControl
    {
        public enum UsingType
        {
            Normal,
            ImportProduct
        }

        private List<ProductGridEntity> m_listItem;

        public bool isReadOnly
        {
            get { return this.m_gridView.ReadOnly; }
            set { this.m_gridView.ReadOnly = value; }
        }

        public ProductGridView()
        {
            InitializeComponent();

            m_listItem = new List<ProductGridEntity>();

            m_gridView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dataGridView_EditingControlShowing);
        }


        protected void dataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tx = e.Control as TextBox;
            tx.KeyPress += new KeyPressEventHandler(tx_KeyPress_int);
        }

        protected void tx_KeyPress_int(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '.'))
            {
                //is NOT number or is '.' key
                e.Handled = true;
            }

            if (m_gridView.CurrentCell.ColumnIndex == 2)
            {
                e.Handled = false;
            }

        }

        public List<ProductGridEntity> HandleGetListItem()
        {
            return m_listItem;
        }

        public void HandleAddProductItem(ProductGridEntity item)
        {
            try
            {
                if (item != null)
                {
                    bool isExist = false;
                    foreach (ProductGridEntity product in m_listItem)
                    {
                        if (product.Id == item.Id)
                        {
                            product.Quantity++;
                            product.Total = product.Quantity * product.Price;
                            isExist = true;
                        }
                    }
                    if (!isExist) m_listItem.Add(item);

                    updateGridData();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.GetType().Name, exc);
            }
        }

        public void HandleAddListProduct(List<ProductGridEntity> productList)
        {
            foreach (ProductGridEntity product in productList)
            {
                HandleAddProductItem(product);
            }
        }

        protected void HandleDeleteItem(int index)
        {
            try
            {
                if (index < m_listItem.Count - 1)
                {
                    m_listItem.RemoveAt(index);
                    updateGridData();
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.GetType().Name, exc);
            }
        }

        protected bool HandleChangeQuantity(int index, int quantity)
        {
            try
            {
                if (index >= m_listItem.Count)
                {
                    return false;
                }
                ProductGridEntity item = m_listItem[index];
                if (quantity < 0)
                {
                    MessageBox.Show("Số lượng không được nhỏ hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    item.Quantity = quantity;
                    item.Total = quantity * (item.Price - item.Discount);

                    //updateGridData();  //avoid error "...result is a reentrant...."
                    //update total
                    m_gridView.Rows[index].Cells["m_colTotal"].Value = item.Total;
                    return true;
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.GetType().Name, exc);
                return false;
            }
        }

        private bool HandleDiscount(int index, double discount)
        {
            try
            {
                ProductGridEntity item = m_listItem[index];
                if (index >= m_listItem.Count)
                {
                    return false;
                }
                if (discount < 0)
                {
                    MessageBox.Show("Giá giảm không được nhỏ hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (discount > item.Price)
                {
                    MessageBox.Show("Giá giảm không được nhiều hơn giá bán", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    item.Discount = discount;
                    item.Total = item.Quantity * (item.Price - discount);

                    //updateGridData();
                    // update total
                    m_gridView.Rows[index].Cells["m_colTotal"].Value = item.Total;

                    return true;
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.GetType().Name, exc);
                return false;
            }
        }

        protected ProductGridEntity SearchProductByName(string name)
        {
            try
            {
                AppLogger.logInfo(this.GetType().Name, " ENTER SearchProductByName");

                ProductFinderView searchComp = isBarcode ? new ProductFinderView(barcode: _model.Barcode, isSearchBarcode: true) : new ProductFinderView(name: _model.Name, isSearchBarcode: false);

                Product searchResult = null;

                if (searchComp.getUniqueItem() != null)
                {
                    searchResult = searchComp.getUniqueItem();
                }
                else
                {
                    searchComp.ShowDialog();
                    searchResult = searchComp.SelectedProduct;
                }

                if (searchResult != null)
                {
                    ProductGridEntity product = new ProductGridEntity();
                    product.Id = searchResult.Id;
                    product.Barcode = searchResult.Barcode;
                    product.Name = searchResult.Name;
                    product.Price = searchResult.Price;
                    product.Quantity = 1;
                    product.Discount = 0;
                    product.Total = product.Quantity * product.Price;
                    return product;
                }

                return null;
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.GetType().Name, exc);
                return null;
            }
        }

        protected ProductGridEntity SearchProductByBarcode(string barcode)
        {
            try
            {
                AppLogger.logInfo(this.GetType().Name, " ENTER SearchProductByBarcode");

                BindingProductEntity searchResult;

                SearchProductView searchComp = new SearchProductView(barcode, "", true);

                if (searchComp.getUniqueItem() != null)
                {
                    searchResult = searchComp.getUniqueItem();
                }
                else
                {
                    searchComp.ShowDialog();
                    searchResult = searchComp.SelectedProduct;
                }

                if (searchResult != null)
                {
                    ProductGridEntity product = new ProductGridEntity();
                    product.Id = searchResult.Id;
                    product.Barcode = searchResult.Barcode;
                    product.Name = searchResult.Name;
                    product.Price = searchResult.Price;
                    product.Quantity = 1;
                    product.Discount = 0;
                    product.Total = product.Quantity * product.Price;
                    return product;
                }

                return null;
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.GetType().Name, exc);
                return null;
            }
        }

        public void ClearAll()
        {
            m_listItem.Clear();
            updateGridData();
        }

        public void updateGridData()
        {
            m_gridView.Rows.Clear();
            int totalQuantity = 0;
            double totalDiscount = 0.0;
            double totalCash = 0.0;
            foreach (ProductGridEntity item in m_listItem)
            {
                m_gridView.Rows.Add(item.Id, item.Barcode, item.Name, item.Price, item.Quantity, item.Discount, item.Total);
                totalQuantity += item.Quantity;
                totalCash += item.Total;
                totalDiscount += item.Discount;
            }

            GridViewDataChangedEventArgs ProductChangedEventData = new GridViewDataChangedEventArgs(totalQuantity, totalDiscount, totalCash);
            OnProductDataChanged(ProductChangedEventData);
        }

        private void m_gridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;

            HandleDeleteItem(e.Row.Index);
        }

        

        private string m_cacheBarcodeKey = "";
        private void m_gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProductGridEntity item = SearchProductByBarcode(m_cacheBarcodeKey);
                if (item != null)
                    HandleAddProductItem(item);

                m_cacheBarcodeKey = "";
            }
        }
        private void m_gridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r')
            {
                if (char.IsDigit(e.KeyChar))
                {
                    m_cacheBarcodeKey += e.KeyChar;
                }
            }
        }

        public void setUsingType(UsingType type)
        {
            if (type == UsingType.Normal)
            {
                m_colDiscount.Visible = true;
                m_colBarCode.Visible = true;
                m_colID.Visible = true;
                m_colName.Visible = true;
                m_colPrice.Visible = true;
                m_colQuantity.Visible = true;
                m_colTotal.Visible = true;
            }
            else if (type == UsingType.ImportProduct)
            {
                m_colDiscount.Visible = false;
                m_colBarCode.Visible = true;
                m_colID.Visible = true;
                m_colName.Visible = true;
                m_colPrice.Visible = true;
                m_colQuantity.Visible = true;
                m_colTotal.Visible = true;
            }

        }

        #region Custom event

        public event GridViewDataChangedEventHandler ProductDataChanged;

        protected void OnProductDataChanged(GridViewDataChangedEventArgs e)
        {
            if (ProductDataChanged != null) { ProductDataChanged(this, e); }
        }

        public delegate void GridViewDataChangedEventHandler(object sender, GridViewDataChangedEventArgs e);

        public class GridViewDataChangedEventArgs : EventArgs
        {
            public GridViewDataChangedEventArgs(int totalQuantity, double discount, double totalCash)
            {
                m_totalCash = totalCash;
                m_totalQuantity = totalQuantity;
                m_discount = discount;
            }

            private int m_totalQuantity;

            public int TotalQuantity
            {
                get { return m_totalQuantity; }
            }
            private double m_totalCash;

            public double TotalCash
            {
                get { return m_totalCash; }
            }

            private double m_discount;

            public double Discount
            {
                get { return m_discount; }
                set { m_discount = value; }
            }
        }
        #endregion
        private void m_gridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCell cell = m_gridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell == null)
                {
                    return;
                }

                bool result = false;

                //change quantity
                if (e.ColumnIndex == 4)
                {
                    result = HandleChangeQuantity(e.RowIndex, int.Parse(StringUtil.ToEmpty(cell.Value)));
                }
                //apply discount
                else if (e.ColumnIndex == 5)
                {
                    result = HandleDiscount(e.RowIndex, int.Parse(StringUtil.ToEmpty(cell.Value)));
                }
                else
                {
                    ProductGridEntity item = null;
                    //search product by barcode
                    if (e.ColumnIndex == 1)
                    {
                        item = SearchProductByBarcode(StringUtil.ToEmpty(cell.Value));
                    }
                    //search product by Name
                    else if (e.ColumnIndex == 2)
                    {
                        item = SearchProductByName(StringUtil.ToEmpty(cell.Value));
                    }

                    if (item != null)
                    {
                        HandleAddProductItem(item);
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }

                if (result == false && m_gridView.Rows.Count > 1 && e.RowIndex < m_gridView.Rows.Count - 1)
                {
                    m_gridView.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (Exception exc)
            {
                AppLogger.logError(this.GetType().Name, exc);
            }
        }
        private void m_gridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void m_gridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
    }
}
