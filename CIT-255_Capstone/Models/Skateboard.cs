using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT_255_Capstone.Models
{
    public class Skateboard : ObservableObject
    {
        #region FIELDS

        private int _id;
        private string _companyName;
        private int _age;
        private string _woodType;
        private string _imageFilePath;
        private int _rating;
        private string _pros;
        private int _size;

        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string WoodType
        {
            get { return _woodType; }
            set { _woodType = value; }
        }

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public string Pros
        {
            get { return _pros; }
            set { _pros = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public string ImageFilePath
        {
            get { return _imageFilePath; }
            set
            {
                _imageFilePath = value;

            }
        }

        #endregion

        #region CONSTRUCTORS

        public Skateboard()
        {

        }

        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion


    }
}
