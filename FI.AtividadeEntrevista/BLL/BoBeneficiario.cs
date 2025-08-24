using FI.AtividadeEntrevista.DML;
using System.Collections.Generic;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiario
    {
        public long Incluir(DML.Beneficiario beneficiario)
        {
            DAL.Benificiario.DaoBeneficiario cli = new DAL.Benificiario.DaoBeneficiario();
            return cli.Incluir(beneficiario);
        }

        public void Alterar(DML.Beneficiario beneficiario)
        {
            DAL.Benificiario.DaoBeneficiario bo = new DAL.Benificiario.DaoBeneficiario();
            bo.Alterar(beneficiario);
        }

        public List<DML.Beneficiario> Consultar(long idCliente)
        {
            DAL.Benificiario.DaoBeneficiario bo = new DAL.Benificiario.DaoBeneficiario();
            return bo.Consultar(idCliente);
        }

        public void Excluir(string cpf)
        {
            DAL.Benificiario.DaoBeneficiario bo = new DAL.Benificiario.DaoBeneficiario();
            bo.Excluir(cpf);
        }
    }
}