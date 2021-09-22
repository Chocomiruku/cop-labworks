﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestWindowsFormsApp
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            outputUserControl.SetHierarchy(new List<string> { "Genre", "Author", "Title" });
            inputUserControl.maxLength = 50;
            inputUserControl.minLength = 10;
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            string item1 = "Книга 1";
            string item2 = "Книга 2";
            string item3 = "Книга 3";

            optionsUserControl.AddItem(item1);
            optionsUserControl.AddItem(item2);
            optionsUserControl.AddItem(item3);
        }

        private void ButtonGetCheckedItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join(", ", optionsUserControl.CheckedItems));
        }

        private void ButtonSetCheckedItems_Click(object sender, EventArgs e)
        {
            optionsUserControl.CheckedItems = new[] { "Книга 1", "Книга 2" };
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            optionsUserControl.ClearItems();
        }

        class Book
        {
            private string Genre;
            private string Author;
            private string Title { get; set; }

            public Book(string genre, string author, string title)
            {
                Genre = genre;
                Author = author;
                Title = title;
            }
        }

        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            outputUserControl.AddItem(new Book("Проза", "Иванов И.И.", "Книга 1"));
            outputUserControl.AddItem(new Book("Проза", "Иванов И.И.", "Книга 2"));
            outputUserControl.AddItem(new Book("Детектив", "Петров П.П.", "Книга 3"));
        }

        private void ButtonGetText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inputUserControl.InputText);
        }

        private void ButtonSetText_Clic(object sender, EventArgs e)
        {
            inputUserControl.InputText = "Новый текст";
        }

        private void ButtonSelectNode_Click(object sender, EventArgs e)
        {
            outputUserControl.SelectedBranchIndex = 1;
        }
    }
}