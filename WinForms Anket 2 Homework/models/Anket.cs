using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinForms_Anket_2_Homework.models {
    public class Anket {

        // Private Fields

        private string? _name;
        private string? _surname;
        private string? _email;
        private string? _phone;
        private string? _datetime;
        private Gender _gender;

        // Properties

        public string? Name { get { return _name; } 
            set {
                if (!Regex.Match(value!, "^[A-Z][a-zA-Z]*$").Success) {
                    throw new Exception("Your name is not valid. Name only can be start with big char!");
                }
                _name = value;
            } 
        }
        public string? Surname { get { return _surname; } 
            set {
                if (!Regex.Match(value!, "^[A-Z][a-zA-Z]*$").Success) {
                    throw new Exception("Your surname is not valid. Surname only can be start with big char!");
                }
                _surname = value;
            } 
        }
        public string? Email { get { return _email; }
            set { 
                if (!Regex.Match(value!, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$").Success) {
                    throw new Exception("Wrong email format email must be in 'example@example.com' format !");
                }
                _email = value;
            }
        }
        public string? Phone { get { return _phone; } 
            set {
                if (!Regex.Match(value!, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{2}[-\\s\\.]?[0-9]{2}$").Success) {
                    throw new Exception("Phone number is in invalid format. Phone number can be 050-111-22-33 or +994501112233 !");
                }
                _phone = value;
            } 
        }
        public string? Datetime { get { return _datetime; } set { _datetime = value; } }
        public Gender Gender { get { return _gender; } set { _gender = value; } }

        // Constructors

        public Anket() { }
        public Anket(string? name, string? surname, string? email, string? phone, string? datetime, Gender gender) {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Datetime = datetime;
            Gender = gender;
        }

        // Functions


    }
}
