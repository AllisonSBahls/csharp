using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            //Simplesmente o Hash code do cliente será o hash code que for passado pelo usuário
            return Email.GetHashCode();
        }
    }

}
