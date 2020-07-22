using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class FieldForSale:Field
    {
        private int _price;
        private int _rent;


        public FieldForSale(string _field, int priceField, int rentField) : base(_field)
        {
            this._price = priceField;
            this._rent = rentField;
        }

        public int Price
        {
            get
            {
                return this._price;
            }
            set
            {
                this._price = value;
            }
        }
        public int Rent
        {
            get
            {
                return this._rent;
            }
            set
            {
                this._rent = value;
            }
        }

        public bool IsThisFieldIsBought(List<Field> board)
        {
           bool _isNotSell = true;
            bool yes = true;
            
                if(board[PlayerOne.Position].FieldName == _isNotSell)
                {
                Console.WriteLine("The Field is not bought! Do you want to buy it? [y/n]");
                Console.ReadKey();
                if(yes ==){

                }
                }
           
            return;
            

        }


    }
}
