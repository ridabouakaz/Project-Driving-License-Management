using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class CtrDetailsPerson_Edit_Add_
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrDetailsPerson_Edit_Add_));
            this.LblName = new System.Windows.Forms.Label();
            this.LblNationalNo = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblSecondName = new System.Windows.Forms.Label();
            this.LblThridName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.PBName = new System.Windows.Forms.PictureBox();
            this.PBNationalNo = new System.Windows.Forms.PictureBox();
            this.PBEmail = new System.Windows.Forms.PictureBox();
            this.PBAddress = new System.Windows.Forms.PictureBox();
            this.PBMan = new System.Windows.Forms.PictureBox();
            this.plGender = new System.Windows.Forms.Panel();
            this.PBFemale = new System.Windows.Forms.PictureBox();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBSecondName = new System.Windows.Forms.TextBox();
            this.TBThridName = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.TBNationalNo = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.LblDateOfBirth = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.LblCountry = new System.Windows.Forms.Label();
            this.PBDateOfBrith = new System.Windows.Forms.PictureBox();
            this.PBPhone = new System.Windows.Forms.PictureBox();
            this.PBCountry = new System.Windows.Forms.PictureBox();
            this.DTPcontroluser = new System.Windows.Forms.DateTimePicker();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.PBImagePerson = new System.Windows.Forms.PictureBox();
            this.LLSetImage = new System.Windows.Forms.LinkLabel();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.BtnAddSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNationalNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMan)).BeginInit();
            this.plGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDateOfBrith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblName.Location = new System.Drawing.Point(28, 65);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(73, 28);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // LblNationalNo
            // 
            this.LblNationalNo.AutoSize = true;
            this.LblNationalNo.BackColor = System.Drawing.Color.Transparent;
            this.LblNationalNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblNationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblNationalNo.Location = new System.Drawing.Point(28, 109);
            this.LblNationalNo.Name = "LblNationalNo";
            this.LblNationalNo.Size = new System.Drawing.Size(133, 28);
            this.LblNationalNo.TabIndex = 1;
            this.LblNationalNo.Text = "National No:";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.BackColor = System.Drawing.Color.Transparent;
            this.LblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblGender.Location = new System.Drawing.Point(28, 153);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(86, 28);
            this.LblGender.TabIndex = 2;
            this.LblGender.Text = "Gender:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblEmail.Location = new System.Drawing.Point(28, 197);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(69, 28);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblAddress.Location = new System.Drawing.Point(28, 241);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(92, 28);
            this.LblAddress.TabIndex = 4;
            this.LblAddress.Text = "Address:";
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.LblFirstName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblFirstName.Location = new System.Drawing.Point(286, 29);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(47, 25);
            this.LblFirstName.TabIndex = 5;
            this.LblFirstName.Text = "First";
            // 
            // LblSecondName
            // 
            this.LblSecondName.AutoSize = true;
            this.LblSecondName.BackColor = System.Drawing.Color.Transparent;
            this.LblSecondName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblSecondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblSecondName.Location = new System.Drawing.Point(505, 29);
            this.LblSecondName.Name = "LblSecondName";
            this.LblSecondName.Size = new System.Drawing.Size(74, 25);
            this.LblSecondName.TabIndex = 6;
            this.LblSecondName.Text = "Second";
            // 
            // LblThridName
            // 
            this.LblThridName.AutoSize = true;
            this.LblThridName.BackColor = System.Drawing.Color.Transparent;
            this.LblThridName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblThridName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblThridName.Location = new System.Drawing.Point(741, 29);
            this.LblThridName.Name = "LblThridName";
            this.LblThridName.Size = new System.Drawing.Size(56, 25);
            this.LblThridName.TabIndex = 7;
            this.LblThridName.Text = "Thrid";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.BackColor = System.Drawing.Color.Transparent;
            this.LblLastName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblLastName.Location = new System.Drawing.Point(927, 29);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(45, 25);
            this.LblLastName.TabIndex = 8;
            this.LblLastName.Text = "Last";
            // 
            // PBName
            // 
            this.PBName.Image = ((System.Drawing.Image)(resources.GetObject("PBName.Image")));
            this.PBName.Location = new System.Drawing.Point(191, 69);
            this.PBName.Name = "PBName";
            this.PBName.Size = new System.Drawing.Size(24, 24);
            this.PBName.TabIndex = 9;
            this.PBName.TabStop = false;
            // 
            // PBNationalNo
            // 
            this.PBNationalNo.Image = ((System.Drawing.Image)(resources.GetObject("PBNationalNo.Image")));
            this.PBNationalNo.Location = new System.Drawing.Point(157, 110);
            this.PBNationalNo.Name = "PBNationalNo";
            this.PBNationalNo.Size = new System.Drawing.Size(24, 24);
            this.PBNationalNo.TabIndex = 10;
            this.PBNationalNo.TabStop = false;
            // 
            // PBEmail
            // 
            this.PBEmail.Image = ((System.Drawing.Image)(resources.GetObject("PBEmail.Image")));
            this.PBEmail.Location = new System.Drawing.Point(157, 198);
            this.PBEmail.Name = "PBEmail";
            this.PBEmail.Size = new System.Drawing.Size(24, 24);
            this.PBEmail.TabIndex = 11;
            this.PBEmail.TabStop = false;
            // 
            // PBAddress
            // 
            this.PBAddress.Image = ((System.Drawing.Image)(resources.GetObject("PBAddress.Image")));
            this.PBAddress.Location = new System.Drawing.Point(157, 242);
            this.PBAddress.Name = "PBAddress";
            this.PBAddress.Size = new System.Drawing.Size(24, 24);
            this.PBAddress.TabIndex = 12;
            this.PBAddress.TabStop = false;
            // 
            // PBMan
            // 
            this.PBMan.Image = ((System.Drawing.Image)(resources.GetObject("PBMan.Image")));
            this.PBMan.Location = new System.Drawing.Point(0, 0);
            this.PBMan.Name = "PBMan";
            this.PBMan.Size = new System.Drawing.Size(24, 24);
            this.PBMan.TabIndex = 13;
            this.PBMan.TabStop = false;
            // 
            // plGender
            // 
            this.plGender.Controls.Add(this.PBFemale);
            this.plGender.Controls.Add(this.RBFemale);
            this.plGender.Controls.Add(this.RBMale);
            this.plGender.Controls.Add(this.PBMan);
            this.plGender.Location = new System.Drawing.Point(157, 154);
            this.plGender.Name = "plGender";
            this.plGender.Size = new System.Drawing.Size(206, 24);
            this.plGender.TabIndex = 14;
            // 
            // PBFemale
            // 
            this.PBFemale.Image = ((System.Drawing.Image)(resources.GetObject("PBFemale.Image")));
            this.PBFemale.Location = new System.Drawing.Point(94, 0);
            this.PBFemale.Name = "PBFemale";
            this.PBFemale.Size = new System.Drawing.Size(24, 24);
            this.PBFemale.TabIndex = 28;
            this.PBFemale.TabStop = false;
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.Location = new System.Drawing.Point(124, 3);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(74, 20);
            this.RBFemale.TabIndex = 30;
            this.RBFemale.TabStop = true;
            this.RBFemale.Text = "Female";
            this.RBFemale.UseVisualStyleBackColor = true;
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.Location = new System.Drawing.Point(34, 3);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(58, 20);
            this.RBMale.TabIndex = 29;
            this.RBMale.TabStop = true;
            this.RBMale.Text = "Male";
            this.RBMale.UseVisualStyleBackColor = true;
            // 
            // TBFirstName
            // 
            this.TBFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBFirstName.ForeColor = System.Drawing.Color.Black;
            this.TBFirstName.Location = new System.Drawing.Point(221, 65);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(184, 30);
            this.TBFirstName.TabIndex = 15;
            // 
            // TBSecondName
            // 
            this.TBSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBSecondName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBSecondName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBSecondName.ForeColor = System.Drawing.Color.Black;
            this.TBSecondName.Location = new System.Drawing.Point(455, 63);
            this.TBSecondName.Name = "TBSecondName";
            this.TBSecondName.Size = new System.Drawing.Size(184, 30);
            this.TBSecondName.TabIndex = 16;
            // 
            // TBThridName
            // 
            this.TBThridName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBThridName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBThridName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBThridName.ForeColor = System.Drawing.Color.Black;
            this.TBThridName.Location = new System.Drawing.Point(674, 63);
            this.TBThridName.Name = "TBThridName";
            this.TBThridName.Size = new System.Drawing.Size(184, 30);
            this.TBThridName.TabIndex = 17;
            // 
            // TBLastName
            // 
            this.TBLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBLastName.ForeColor = System.Drawing.Color.Black;
            this.TBLastName.Location = new System.Drawing.Point(876, 68);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(184, 30);
            this.TBLastName.TabIndex = 18;
            // 
            // TBNationalNo
            // 
            this.TBNationalNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBNationalNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNationalNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBNationalNo.ForeColor = System.Drawing.Color.Black;
            this.TBNationalNo.Location = new System.Drawing.Point(191, 109);
            this.TBNationalNo.Name = "TBNationalNo";
            this.TBNationalNo.Size = new System.Drawing.Size(154, 30);
            this.TBNationalNo.TabIndex = 19;
            // 
            // TBEmail
            // 
            this.TBEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBEmail.ForeColor = System.Drawing.Color.Black;
            this.TBEmail.Location = new System.Drawing.Point(191, 197);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(154, 30);
            this.TBEmail.TabIndex = 20;
            // 
            // TBAddress
            // 
            this.TBAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBAddress.ForeColor = System.Drawing.Color.Black;
            this.TBAddress.Location = new System.Drawing.Point(191, 241);
            this.TBAddress.Multiline = true;
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(502, 111);
            this.TBAddress.TabIndex = 21;
            // 
            // LblDateOfBirth
            // 
            this.LblDateOfBirth.AutoSize = true;
            this.LblDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.LblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblDateOfBirth.Location = new System.Drawing.Point(464, 109);
            this.LblDateOfBirth.Name = "LblDateOfBirth";
            this.LblDateOfBirth.Size = new System.Drawing.Size(145, 28);
            this.LblDateOfBirth.TabIndex = 22;
            this.LblDateOfBirth.Text = "Date Of Birth:";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.BackColor = System.Drawing.Color.Transparent;
            this.LblPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblPhone.Location = new System.Drawing.Point(430, 153);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(76, 28);
            this.LblPhone.TabIndex = 23;
            this.LblPhone.Text = "Phone:";
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.BackColor = System.Drawing.Color.Transparent;
            this.LblCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblCountry.Location = new System.Drawing.Point(413, 197);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(93, 28);
            this.LblCountry.TabIndex = 24;
            this.LblCountry.Text = "Country:";
            // 
            // PBDateOfBrith
            // 
            this.PBDateOfBrith.Image = ((System.Drawing.Image)(resources.GetObject("PBDateOfBrith.Image")));
            this.PBDateOfBrith.Location = new System.Drawing.Point(615, 110);
            this.PBDateOfBrith.Name = "PBDateOfBrith";
            this.PBDateOfBrith.Size = new System.Drawing.Size(24, 24);
            this.PBDateOfBrith.TabIndex = 25;
            this.PBDateOfBrith.TabStop = false;
            // 
            // PBPhone
            // 
            this.PBPhone.Image = ((System.Drawing.Image)(resources.GetObject("PBPhone.Image")));
            this.PBPhone.Location = new System.Drawing.Point(510, 154);
            this.PBPhone.Name = "PBPhone";
            this.PBPhone.Size = new System.Drawing.Size(24, 24);
            this.PBPhone.TabIndex = 26;
            this.PBPhone.TabStop = false;
            // 
            // PBCountry
            // 
            this.PBCountry.Image = ((System.Drawing.Image)(resources.GetObject("PBCountry.Image")));
            this.PBCountry.Location = new System.Drawing.Point(510, 200);
            this.PBCountry.Name = "PBCountry";
            this.PBCountry.Size = new System.Drawing.Size(24, 24);
            this.PBCountry.TabIndex = 27;
            this.PBCountry.TabStop = false;
            // 
            // DTPcontroluser
            // 
            this.DTPcontroluser.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPcontroluser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTPcontroluser.Location = new System.Drawing.Point(685, 109);
            this.DTPcontroluser.MinDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.DTPcontroluser.Name = "DTPcontroluser";
            this.DTPcontroluser.Size = new System.Drawing.Size(153, 22);
            this.DTPcontroluser.TabIndex = 28;
            this.DTPcontroluser.Value = new System.DateTime(2007, 7, 20, 0, 0, 0, 0);
            // 
            // TBPhone
            // 
            this.TBPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBPhone.ForeColor = System.Drawing.Color.Black;
            this.TBPhone.Location = new System.Drawing.Point(539, 153);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(154, 30);
            this.TBPhone.TabIndex = 29;
            // 
            // CBCountry
            // 
            this.CBCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.CBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCountry.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBCountry.ForeColor = System.Drawing.Color.Black;
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(539, 198);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(154, 31);
            this.CBCountry.TabIndex = 30;
            // 
            // PBImagePerson
            // 
            this.PBImagePerson.Location = new System.Drawing.Point(890, 111);
            this.PBImagePerson.Name = "PBImagePerson";
            this.PBImagePerson.Size = new System.Drawing.Size(128, 128);
            this.PBImagePerson.TabIndex = 31;
            this.PBImagePerson.TabStop = false;
            // 
            // LLSetImage
            // 
            this.LLSetImage.AutoSize = true;
            this.LLSetImage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LLSetImage.Location = new System.Drawing.Point(908, 259);
            this.LLSetImage.Name = "LLSetImage";
            this.LLSetImage.Size = new System.Drawing.Size(95, 25);
            this.LLSetImage.TabIndex = 33;
            this.LLSetImage.TabStop = true;
            this.LLSetImage.Text = "Set Image";
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClose.Image")));
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(410, 368);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(142, 48);
            this.BtnAddClose.TabIndex = 34;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            // 
            // BtnAddSave
            // 
            this.BtnAddSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddSave.Image")));
            this.BtnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddSave.Location = new System.Drawing.Point(566, 368);
            this.BtnAddSave.Name = "BtnAddSave";
            this.BtnAddSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddSave.Size = new System.Drawing.Size(130, 48);
            this.BtnAddSave.TabIndex = 35;
            this.BtnAddSave.Text = "Save";
            this.BtnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddSave.UseVisualStyleBackColor = false;
            // 
            // CtrDetailsPerson_Edit_Add_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BtnAddSave);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.LLSetImage);
            this.Controls.Add(this.PBImagePerson);
            this.Controls.Add(this.CBCountry);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.DTPcontroluser);
            this.Controls.Add(this.PBCountry);
            this.Controls.Add(this.PBPhone);
            this.Controls.Add(this.PBDateOfBrith);
            this.Controls.Add(this.LblCountry);
            this.Controls.Add(this.LblPhone);
            this.Controls.Add(this.LblDateOfBirth);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBNationalNo);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBThridName);
            this.Controls.Add(this.TBSecondName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.plGender);
            this.Controls.Add(this.PBAddress);
            this.Controls.Add(this.PBEmail);
            this.Controls.Add(this.PBNationalNo);
            this.Controls.Add(this.PBName);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblNationalNo);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblThridName);
            this.Controls.Add(this.LblSecondName);
            this.Controls.Add(this.LblFirstName);
            this.Name = "CtrDetailsPerson_Edit_Add_";
            this.Size = new System.Drawing.Size(1058, 451);
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNationalNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMan)).EndInit();
            this.plGender.ResumeLayout(false);
            this.plGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDateOfBrith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagePerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNationalNo;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblSecondName;
        private System.Windows.Forms.Label LblThridName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.PictureBox PBName;
        private PictureBox PBNationalNo;
        private PictureBox PBEmail;
        private PictureBox PBAddress;
        private PictureBox PBMan;
        private Panel plGender;
        private TextBox TBFirstName;
        private TextBox TBSecondName;
        private TextBox TBThridName;
        private TextBox TBLastName;
        private TextBox TBNationalNo;
        private TextBox TBEmail;
        private TextBox TBAddress;
        private Label LblDateOfBirth;
        private Label LblPhone;
        private Label LblCountry;
        private PictureBox PBDateOfBrith;
        private PictureBox PBPhone;
        private PictureBox PBCountry;
        private RadioButton RBMale;
        private RadioButton RBFemale;
        private PictureBox PBFemale;
        private DateTimePicker DTPcontroluser;
        private TextBox TBPhone;
        private ComboBox CBCountry;
        private PictureBox PBImagePerson;
        private LinkLabel LLSetImage;
        private Button BtnAddClose;
        private Button BtnAddSave;
    }
}
