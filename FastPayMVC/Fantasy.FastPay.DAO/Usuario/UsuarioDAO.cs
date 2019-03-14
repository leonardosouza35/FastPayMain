using Fantasy.FastPay.Domain.Entities;
using System;
using System.Collections;
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
            

            // Estruturas de dados
            // int[], ArrayList


            //var arrayListUsuario = new ArrayList();

            //// Boxing & Unboxing
            //arrayListUsuario.Add(new Usuario());
            //arrayListUsuario.Add(new Usuario());
            //arrayListUsuario.Add(new Usuario());
            //arrayListUsuario.Add(new OrdemPagamento());

            //Usuario user;
            //foreach(var item in arrayListUsuario){
            //    user = (Usuario)item; Casting

            //    user.Nome = "asdasda";
            //}

            var sequence = 1;
            if (Db.Usuarios.Any())
            {
                var maxId = Db.Usuarios.Max(u => u.Id); // u => u.Id Expressão Lambda - Ler sobre Expressão Lambda e Função Anônima
                maxId++;
                sequence = maxId;
            }

            usuario.Id = sequence;
            Db.Usuarios.Add(usuario);            
        }

        public Usuario ObterUsuario(int usuarioId)
        {
            return Db.Usuarios.FirstOrDefault(u => u.Id == usuarioId);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            var _usuario = Db.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);

            if (usuario != null)
            {
                _usuario.Nome = usuario.Nome;
                _usuario.SobreNome = usuario.SobreNome;
            }

        }

        public void DeletarUsuario(int usuarioId)
        {
            Db.Usuarios.RemoveAll(u => u.Id == usuarioId);            
        }
    }
}
