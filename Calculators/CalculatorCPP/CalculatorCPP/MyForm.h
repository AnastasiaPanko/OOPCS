#pragma once
#include <string>
using namespace std;

namespace CalculatorCPP {
	#include <string>
	using namespace std;

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::Button^ button4;
	private: System::Windows::Forms::Button^ button5;
	private: System::Windows::Forms::Button^ button6;
	private: System::Windows::Forms::Button^ button7;
	private: System::Windows::Forms::Button^ button8;
	private: System::Windows::Forms::Button^ button9;
	private: System::Windows::Forms::Button^ button10;
	private: System::Windows::Forms::Button^ dotBth;

	private: System::Windows::Forms::Button^ addBtn;
	private: System::Windows::Forms::Button^ subBtn;
	private: System::Windows::Forms::Button^ mulBtn;
	private: System::Windows::Forms::Button^ divBtn;
	private: System::Windows::Forms::Button^ resultBtn;





	private: System::Windows::Forms::Button^ button17;
	private: System::Windows::Forms::Button^ button18;
	private: System::Windows::Forms::TextBox^ textBox;
	private: System::Windows::Forms::Label^ labelResult;


	protected:

	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->button6 = (gcnew System::Windows::Forms::Button());
			this->button7 = (gcnew System::Windows::Forms::Button());
			this->button8 = (gcnew System::Windows::Forms::Button());
			this->button9 = (gcnew System::Windows::Forms::Button());
			this->button10 = (gcnew System::Windows::Forms::Button());
			this->dotBth = (gcnew System::Windows::Forms::Button());
			this->addBtn = (gcnew System::Windows::Forms::Button());
			this->subBtn = (gcnew System::Windows::Forms::Button());
			this->mulBtn = (gcnew System::Windows::Forms::Button());
			this->divBtn = (gcnew System::Windows::Forms::Button());
			this->resultBtn = (gcnew System::Windows::Forms::Button());
			this->button17 = (gcnew System::Windows::Forms::Button());
			this->button18 = (gcnew System::Windows::Forms::Button());
			this->textBox = (gcnew System::Windows::Forms::TextBox());
			this->labelResult = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(62, 171);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(70, 70);
			this->button1->TabIndex = 0;
			this->button1->Text = L"1";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(138, 171);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(70, 70);
			this->button2->TabIndex = 1;
			this->button2->Text = L"2";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(214, 171);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(70, 70);
			this->button3->TabIndex = 2;
			this->button3->Text = L"3";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(62, 247);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(70, 70);
			this->button4->TabIndex = 3;
			this->button4->Text = L"4";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(138, 247);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(70, 70);
			this->button5->TabIndex = 4;
			this->button5->Text = L"5";
			this->button5->UseVisualStyleBackColor = true;
			this->button5->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button6
			// 
			this->button6->Location = System::Drawing::Point(214, 247);
			this->button6->Name = L"button6";
			this->button6->Size = System::Drawing::Size(70, 70);
			this->button6->TabIndex = 5;
			this->button6->Text = L"6";
			this->button6->UseVisualStyleBackColor = true;
			this->button6->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button7
			// 
			this->button7->Location = System::Drawing::Point(62, 323);
			this->button7->Name = L"button7";
			this->button7->Size = System::Drawing::Size(70, 70);
			this->button7->TabIndex = 6;
			this->button7->Text = L"7";
			this->button7->UseVisualStyleBackColor = true;
			this->button7->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button8
			// 
			this->button8->Location = System::Drawing::Point(138, 323);
			this->button8->Name = L"button8";
			this->button8->Size = System::Drawing::Size(70, 70);
			this->button8->TabIndex = 7;
			this->button8->Text = L"8";
			this->button8->UseVisualStyleBackColor = true;
			this->button8->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button9
			// 
			this->button9->Location = System::Drawing::Point(214, 323);
			this->button9->Name = L"button9";
			this->button9->Size = System::Drawing::Size(70, 70);
			this->button9->TabIndex = 8;
			this->button9->Text = L"9";
			this->button9->UseVisualStyleBackColor = true;
			this->button9->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// button10
			// 
			this->button10->Location = System::Drawing::Point(62, 399);
			this->button10->Name = L"button10";
			this->button10->Size = System::Drawing::Size(146, 70);
			this->button10->TabIndex = 9;
			this->button10->Text = L"0";
			this->button10->UseVisualStyleBackColor = true;
			this->button10->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			// 
			// dotBth
			// 
			this->dotBth->Location = System::Drawing::Point(214, 399);
			this->dotBth->Name = L"dotBth";
			this->dotBth->Size = System::Drawing::Size(70, 70);
			this->dotBth->TabIndex = 10;
			this->dotBth->Text = L".";
			this->dotBth->UseVisualStyleBackColor = true;
			// 
			// addBtn
			// 
			this->addBtn->Location = System::Drawing::Point(290, 399);
			this->addBtn->Name = L"addBtn";
			this->addBtn->Size = System::Drawing::Size(70, 70);
			this->addBtn->TabIndex = 11;
			this->addBtn->Text = L"+";
			this->addBtn->UseVisualStyleBackColor = true;
			this->addBtn->Click += gcnew System::EventHandler(this, &MyForm::operandEvent);
			// 
			// subBtn
			// 
			this->subBtn->Location = System::Drawing::Point(290, 323);
			this->subBtn->Name = L"subBtn";
			this->subBtn->Size = System::Drawing::Size(70, 70);
			this->subBtn->TabIndex = 12;
			this->subBtn->Text = L"-";
			this->subBtn->UseVisualStyleBackColor = true;
			this->subBtn->Click += gcnew System::EventHandler(this, &MyForm::operandEvent);
			// 
			// mulBtn
			// 
			this->mulBtn->Location = System::Drawing::Point(290, 247);
			this->mulBtn->Name = L"mulBtn";
			this->mulBtn->Size = System::Drawing::Size(70, 70);
			this->mulBtn->TabIndex = 13;
			this->mulBtn->Text = L"*";
			this->mulBtn->UseVisualStyleBackColor = true;
			this->mulBtn->Click += gcnew System::EventHandler(this, &MyForm::operandEvent);
			// 
			// divBtn
			// 
			this->divBtn->Location = System::Drawing::Point(290, 171);
			this->divBtn->Name = L"divBtn";
			this->divBtn->Size = System::Drawing::Size(70, 70);
			this->divBtn->TabIndex = 14;
			this->divBtn->Text = L"/";
			this->divBtn->UseVisualStyleBackColor = true;
			this->divBtn->Click += gcnew System::EventHandler(this, &MyForm::operandEvent);
			// 
			// resultBtn
			// 
			this->resultBtn->Location = System::Drawing::Point(366, 323);
			this->resultBtn->Name = L"resultBtn";
			this->resultBtn->Size = System::Drawing::Size(70, 146);
			this->resultBtn->TabIndex = 15;
			this->resultBtn->Text = L"=";
			this->resultBtn->UseVisualStyleBackColor = true;
			// 
			// button17
			// 
			this->button17->Location = System::Drawing::Point(366, 247);
			this->button17->Name = L"button17";
			this->button17->Size = System::Drawing::Size(70, 70);
			this->button17->TabIndex = 16;
			this->button17->Text = L"C";
			this->button17->UseVisualStyleBackColor = true;
			// 
			// button18
			// 
			this->button18->Location = System::Drawing::Point(366, 171);
			this->button18->Name = L"button18";
			this->button18->Size = System::Drawing::Size(70, 70);
			this->button18->TabIndex = 17;
			this->button18->Text = L"CE";
			this->button18->UseVisualStyleBackColor = true;
			// 
			// textBox
			// 
			this->textBox->Location = System::Drawing::Point(62, 133);
			this->textBox->Name = L"textBox";
			this->textBox->Size = System::Drawing::Size(374, 22);
			this->textBox->TabIndex = 18;
			// 
			// labelResult
			// 
			this->labelResult->AutoSize = true;
			this->labelResult->Location = System::Drawing::Point(59, 100);
			this->labelResult->Name = L"labelResult";
			this->labelResult->Size = System::Drawing::Size(0, 16);
			this->labelResult->TabIndex = 19;
			this->labelResult->Click += gcnew System::EventHandler(this, &MyForm::operandEvent);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(597, 523);
			this->Controls->Add(this->labelResult);
			this->Controls->Add(this->textBox);
			this->Controls->Add(this->button18);
			this->Controls->Add(this->button17);
			this->Controls->Add(this->resultBtn);
			this->Controls->Add(this->divBtn);
			this->Controls->Add(this->mulBtn);
			this->Controls->Add(this->subBtn);
			this->Controls->Add(this->addBtn);
			this->Controls->Add(this->dotBth);
			this->Controls->Add(this->button10);
			this->Controls->Add(this->button9);
			this->Controls->Add(this->button8);
			this->Controls->Add(this->button7);
			this->Controls->Add(this->button6);
			this->Controls->Add(this->button5);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->Click += gcnew System::EventHandler(this, &MyForm::NumEvent);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		bool operandPerformed = false;
		String^ operand = "";
		double result;


private: System::Void NumEvent(System::Object^ sender, System::EventArgs^ e) {
	if (textBox->Text == "0")
	{
		textBox->Clear();
	}
	Button^ btn = (Button^)sender;
	textBox->Text += btn->Text;
	
}
private: System::Void operandEvent(System::Object^ sender, System::EventArgs^ e) {
	operandPerformed = true;
	Button^ btn = (Button^)sender;
	String^ newOperand = btn->Text;
	labelResult->Text = labelResult->Text + " " + labelResult->Text + " " + newOperand;

	double number = double::Parse(textBox->Text);

	if (operand == "+")
	{
		textBox->Text = (result + number)->ToString();
	}
	if (operand == "-")
	{
		textBox->Text = (result + (textBox->Text))->ToString();
	}
	if (operand == "*")
	{
		textBox->Text = (result + (textBox->Text))->ToString();
	}
	if (operand == "/")
	{
		textBox->Text = (result + (textBox->Text))->ToString();
	}
	result = double::Parse(textBox->Text);
	operand = newOperand;
}
};
}
