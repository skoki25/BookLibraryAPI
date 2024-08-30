using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Forms.UserControlComponents.CustomObject
{
    public class CustomDataRow<T>: DataGridViewRow
    {
        private T _data;

        public CustomDataRow(DataGridView dataGridView, T data)
        {
            this.CreateCells(dataGridView);
            _data = data;
        }
        public void Add(params string[] values)
        {
            for (int i=0; i < values.Count(); i++)
            {
                this.Cells[i].Value = values[i];
            }
        }
        public T GetData()
        {
            return _data;
        }
    }
}
