using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ARK.SQL;
using System.Windows.Forms;

namespace ARK.MyInterface
{
    public class MyButtonClick
    {
        public bool AddButton(object sender, EventArgs e, bool _click)
        {
            bool _check = true;

            if (_click)
            {
                MessageBox.Show("Добавлена новая запись!", "Склад", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("Запись не добавлена!", "Склад", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _check = false;
            }
            return _check; ;
        }

        public bool EditButton(object sender, EventArgs e, bool _click)
        {
            bool _check = true;
            if (_click)
            {
                MessageBox.Show("Запись отредактированно!", "Склад", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не отредактированно!", "Склад", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _check = false;
            }
            return _check; ;
        }

        public bool DeleteButton(object sender, EventArgs e, bool _click)
        {
            bool _check = true;
            if (_click)
            {
                MessageBox.Show("Запись удалена!", "Склад", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не удалена!", "Склад", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _check = false;
            }
            return _check; ;
        }

        public void Error(Exception ex)
        {
            MessageBox.Show("Ошибка!\n" + ex.ToString(), "Склад", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
