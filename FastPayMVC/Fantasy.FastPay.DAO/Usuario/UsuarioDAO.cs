using Fantasy.FastPay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fantasy.FastPay.DAO
{
    
    public class UsuarioDAO : BaseDAO
    {

        public List<Usuario> ObterTodos()
        {
            return Db.Usuarios;
        }

        //public List<Usuario> ObterTodos()
        //{
        //    var usuarios = new List<Usuario>();
        //    try
        //    {
        //        OpenConnection();

        //        CreateCommand("select Email, Senha, Nome, SobreNome, CpfOrCnpj from usuarios");
                
        //        var reader = ExecuteDataReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                var usuario = new Usuario();
        //                usuario.Email = reader["Email"].ToString();
        //                usuario.Senha = reader["Senha"].ToString();
        //                usuario.Nome = reader["Nome"].ToString();
        //                usuario.SobreNome = reader["SobreNome"].ToString();
        //                usuario.CpfOrCnpj = reader["CpfOrCnpj"].ToString();
        //                usuarios.Add(usuario);
        //            }
        //        }

        //        return usuarios;
                
        //    }
        //    catch (Exception ex)
        //    {
        //        //ex.ToString();
        //        // Log Erro ex.ToString();
        //        // Disparar Email ex.ToString();
        //        throw new Exception("Erro no sistema.. enviar email para suporte");
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}

        public void AdicionarUsuario(Usuario usuario)
        {
            Db.Usuarios.Add(usuario);
        }
    }
}
