using System;

namespace TrabajoPractico4
{
    public class User
    {
        public int userId { get; set; }
        public Int64 dni { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public Int64 CUITCUIL { get; set; }
        public String password { get; set; }
        public String userType { get; set; }
        public Cart cart { get; set; }

        public User(Int64 dni, String name, String lastName, String email, Int64 CUITCUIL, String password, String userType, Cart cart)
        {
            
            this.dni = dni;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.CUITCUIL = CUITCUIL;
            this.password = password;
            this.userType = userType;
            this.cart = cart;
        }

        public User( String name,  String email, Int64 CUITCUIL, String password, String userType, Cart cart)
        {
            
            this.name = name;
            this.email = email;
            this.CUITCUIL = CUITCUIL;
            this.password = password;
            this.userType = userType;
            this.cart = cart;
        }

        public User( String name, String email, Int64 CUITCUIL, String password, String userType)
        {
            
            this.name = name;
            this.email = email;
            this.CUITCUIL = CUITCUIL;
            this.password = password;
            this.userType = userType;
        }
        
    }

}