using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoAdo;
using AppBancoDominio;
using MySql.Data.MySqlClient;

namespace AppBancoDll
{
    public class UsuarioDAO
    {
        private Banco db;

        public void Insert(Usuario user)
        {
            var strQuery = "";
            strQuery += "Insert Into tbl_Usuario(Nome_Usu, Cargo,Nasc)";
            strQuery += string.Format("Values('{0}', '{1}', Str_To_Date('{2}', '%d/%m/%Y %T'));", user.Nome_Usu, user.Cargo, user.Nasc);

            using (db = new Banco())
            {
                db.ExecuteCommand(strQuery);
            }
        }

        public void Update(Usuario user)
        {
            var strQuery = "";
            strQuery += "Update tbl_Usuario Set ";
            strQuery += string.Format("Nome_Usu = '{0}', ", user.Nome_Usu);
            strQuery += string.Format("Cargo = '{0}', ", user.Cargo);
            strQuery += string.Format("Nasc = Str_To_Date('{0}', '%d/%m/%Y %T')", user.Nasc);
            strQuery += string.Format("Where Id_Usu = '{0}' ", user.Id_Usu);

            using (db = new Banco())
            {
                db.ExecuteCommand(strQuery);
            }
        }
        public void Save(Usuario user)
        {
            if (user.Id_Usu > 0)
            {
                Update(user);
            }
            else
            {
                Insert(user);
            }
        }


        public void Delete(Usuario user)
        {
            using (db = new Banco())
            {
                var strQuery = string.Format("Delete From tbl_Usuario Where Id_Usu = {0}", user.Id_Usu);
                db.ExecuteCommand(strQuery);
            }
        }

        public List<Usuario> Select()
        {
            using (db = new Banco())
            {
                var strQuery = " Select * From tbl_Usuario;";
                var Return = db.ReturnCommand(strQuery);
                return SelectUser(Return);
            }

        }
        
        public List<Usuario> SelectUser(MySqlDataReader Return)
        {
            var users = new List<Usuario>();
            while (Return.Read())
            {
                var TempUser = new Usuario()
                {
                    Id_Usu = int.Parse(Return["Id_Usu"].ToString()),
                    Nome_Usu = Return["Nome_Usu"].ToString(),
                    Cargo = Return["Cargo"].ToString(),
                    Nasc = DateTime.Parse(Return["Nasc"].ToString())
                };
                users.Add(TempUser);
            }
            Return.Close();
            return users;
        }
    }
}
