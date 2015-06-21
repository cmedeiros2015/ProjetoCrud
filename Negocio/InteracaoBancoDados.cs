using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Objects.DataClasses;
using ObjetoTransferencia;
using ClasseAcessaDados;

namespace Negocio
{
    public class InteracaoBancoDados
    {
        #region Validações

        #region Validar Inserir
        private void ValidarInserir(ModeloPessoa mod)
        {
            try
            {
                ValidarAlterar(mod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        #endregion

        #region Validar Consulta
        private void ValidarConsulTa(int codigo)
        {
            try
            {
                if (codigo == null){ throw new Exception("O Campo Código deve ser preenchido"); }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        #endregion

        #region Validar Alterar
        private void ValidarAlterar(ModeloPessoa mod)
        {
            try
            {
                if (string.IsNullOrEmpty(mod.Nome)) { throw new Exception("Campo Nome deve ser preenchido!"); }
                if (string.IsNullOrEmpty(mod.Sobrenome)) { throw new Exception("Campo Sobrenome deve ser preenchido!"); }
                if (string.IsNullOrEmpty(mod.Endereco)) { throw new Exception("Campo Endereço deve ser preenchido!"); }
                if (string.IsNullOrEmpty(mod.Telefone)) { throw new Exception("Campo Telefone deve ser preenchido!"); }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        #endregion

        #region Validar Usuário
        private void ValidarUsuario(ModeloLoginPessoa mod)
        {
            using (var conect = new cadastropessoasEntities())
            {
                try
                {
                    if (mod.email.Equals(null)) { throw new Exception("Campo email do usuário deve ser preenchido!"); }
                    if (mod.senha.Equals(null)) { throw new Exception("Campo senha deve ser preenchido!"); }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }
        #endregion

        #endregion

        #region Metodos

        #region Gravar Dados
        public void Gravar(ModeloPessoa mod)
        {
            using (var conexao = new cadastropessoasEntities())
            {
                ValidarInserir(mod);
                pessoas tabPes = new pessoas();
                tabPes.Nome_pessoa = mod.Nome;
                tabPes.Sobrenome_pessoa = mod.Sobrenome;
                tabPes.Endereco_pessoa = mod.Endereco;
                tabPes.Telefone_pessoa = mod.Telefone;
                tabPes.Email_pessoa = mod.Email;
                tabPes.DataCadastro_pessoa = mod.DataCad;

                try
                {
                    conexao.pessoas.Add(tabPes);
                    conexao.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro na conexao com o banco " + ex.Message);
                }
                finally
                {
                    conexao.Database.Connection.Close();
                }
            }
        }
        #endregion

        #region Listar Dados
        public List<pessoas> Listar()
        {
            List<pessoas> lista = new List<pessoas>();
            using (var conect = new cadastropessoasEntities())
            {
                try
                {
                    var pessoSelecionada = conect.pessoas;
                    lista.AddRange(pessoSelecionada);
                    return lista;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro na conexao com o banco. Mais detalhes:" + " " + ex.Message);
                }
                finally
                {
                    conect.Database.Connection.Close();
                }
            }
        }
        #endregion

        #region Consultar Dados
        public ModeloPessoa Consultar(int codigo)
        {
            using (var conect = new cadastropessoasEntities())
            {
                try
                {
                    ValidarConsulTa(codigo);
                    pessoas pessoa = conect.pessoas.First(p => p.Id_pessoa == codigo);
                    ModeloPessoa modelo = new ModeloPessoa();
                    modelo.Nome = pessoa.Nome_pessoa;
                    modelo.Sobrenome = pessoa.Sobrenome_pessoa;
                    modelo.Endereco = pessoa.Endereco_pessoa;
                    modelo.Telefone = pessoa.Telefone_pessoa;
                    modelo.Email = pessoa.Email_pessoa;
                    modelo.DataCad = pessoa.DataCadastro_pessoa;
                    modelo.DataAltCad = Convert.ToDateTime(pessoa.DataAltCadastro_pessoa);      
                    return modelo;
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    conect.Database.Connection.Close();
                }
            }
        }
        #endregion

        #region Alterar Dados
        public void alterar(ModeloPessoa modelo)
        {
            using (var conect = new cadastropessoasEntities())
            {
                try
                {
                    ValidarAlterar(modelo);
                    var atualiza = conect.pessoas.FirstOrDefault(p => p.Id_pessoa.Equals(modelo.Id));
                    atualiza.Nome_pessoa = modelo.Nome;
                    atualiza.Sobrenome_pessoa = modelo.Sobrenome;
                    atualiza.Endereco_pessoa = modelo.Endereco;
                    atualiza.Telefone_pessoa = modelo.Telefone;
                    atualiza.Email_pessoa = modelo.Email;
                    atualiza.DataAltCadastro_pessoa = modelo.DataAltCad;
                    conect.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro na conexão com o banco de dados. Mais informaçoes:" + " " + ex.Message);
                }
                finally
                {
                    conect.Database.Connection.Close();
                }
            }
        }
        #endregion

        #region Excluir Dados
        public void Excluir(int codigo)
        {
            using (var conect = new cadastropessoasEntities())
            {
                try
                {
                    pessoas pessoa = conect.pessoas.First(p => p.Id_pessoa.Equals(codigo));
                    conect.pessoas.Remove(pessoa);
                    conect.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro na conexão com o banco de dados. Mais informações: " + ex.Message);
                }
                finally
                {
                    conect.Database.Connection.Close();
                }
            }
        }
        #endregion

        #region Gravar Usuario
        public void GravarUsuario(ModeloLoginPessoa loginMod)
        {
            using (var conLogin = new cadastropessoasEntities())
            {
                try
                {
                    tb_loginusuario tbLogin = new tb_loginusuario();
                    tbLogin.emailPri = loginMod.email;
                    tbLogin.senhaPri = loginMod.senha;
                    conLogin.tb_loginusuario.Add(tbLogin);
                    conLogin.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }
        #endregion

        #region Logar Usuário
        public Boolean LogarUsuario(ModeloLoginPessoa mod)
        {
            using(cadastropessoasEntities conUsuario = new cadastropessoasEntities())
            {
                try
                {
                    var usuario = conUsuario.tb_loginusuario.FirstOrDefault(p => p.emailPri == mod.email && p.senhaPri == mod.senha);
                    if (usuario != null)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message.ToString());
                }
            }
        }
        #endregion

        #endregion
    }
}
