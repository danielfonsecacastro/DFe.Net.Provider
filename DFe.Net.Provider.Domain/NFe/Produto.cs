using DFe.Net.Provider.Domain.NFe.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.Net.Provider.Domain.NFe
{
    public class Produto
    {
        /// <summary>
        ///     I02 - Código do produto ou serviço
        /// </summary>
        public string CodigoProduto { get; set; }

        /// <summary>
        ///     I03 - GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
        /// </summary>
        public string CodigoEAN { get; set; }

        /// <summary>
        ///     I04 - Descrição do produto ou serviço
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        ///     I05 - Código NCM (8 posições). Em caso de item de serviço ou item que não tenham produto (Ex. transferência de
        ///     crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0)
        /// </summary>
        public string NCM { get; set; }

        /// <summary>
        ///     105a - Nomenclatura de Valor aduaneio e Estatístico
        ///     <para>Ocorrência: 0-8</para>
        /// </summary>
        public List<string> NVE { get; set; }

        /// <summary>
        /// I05c - Código CEST
        /// </summary>
        public string CEST { get; set; }

        /// <summary>
        /// Versão 4.00
        /// Indicador de Produção em escala relevante, conforme Cláusula 23 do Convenio ICMS 52/2017 ||||
        /// Nota: preenchimento obrigatório para produtos com NCM
        /// relacionado no Anexo XXVII do Convenio 52/2017
        /// </summary>
        public IndicadorEscala? IndicadorEscala { get; set; }

        /// <summary>
        /// Versão 4.00
        /// CNPJ do Fabricante da Mercadoria, obrigatório para produto em escala NÃO relevante.
        /// </summary>
        public string CNPJFabicante { get; set; }

        /// <summary>
        /// Versão 4.00
        /// Código de Benefício fiscal utilizado pela UF, aplicado ao item. Obs: Deve ser utilizado o mesmo código adotado na EFD e outras
        /// declarações, nas UF que o exigem.
        /// </summary>
        public string CodigoBeneficio { get; set; }

        /// <summary>
        ///     I06 - Código EX TIPI (3 posições)
        /// </summary>
        public string EXTIPI { get; set; }

        /// <summary>
        ///     I08 - Código Fiscal de Operações e Prestações
        /// </summary>
        public int CFOP { get; set; }

        /// <summary>
        ///     I09 - Unidade comercial
        /// </summary>
        public string UnidadeComecial { get; set; }

        /// <summary>
        ///     I10 - Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.
        /// </summary>
        public decimal QuantidadeComercial { get; set; }

        /// <summary>
        ///     I10a - Valor Unitário de Comercialização
        /// </summary>
        public decimal ValorUnitarioComercial { get; set; }

        /// <summary>
        ///     I11 - Valor Total Bruto dos Produtos ou Serviços
        /// </summary>
        public decimal ValorProduto { get; set; }

        /// <summary>
        ///     I12 - GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
        /// </summary>
        public string CodigoEANTrib { get; set; }

        /// <summary>
        ///     I13 - Unidade Tributável
        /// </summary>
        public string UnidadeTributável { get; set; }

        /// <summary>
        ///     I14 - Quantidade Tributável
        /// </summary>
        public decimal QuantidadeTributavel { get; set; }

        /// <summary>
        ///     I14a - Valor Unitário de tributação
        /// </summary>
        public decimal ValorUnitarioTributacao { get; set; }

        /// <summary>
        ///     I15 - Valor Total do Frete
        /// </summary>
        public decimal? ValorFrete { get; set; }

        /// <summary>
        ///     I16 - Valor Total do Seguro
        /// </summary>
        public decimal? ValorSeguro { get; set; }

        /// <summary>
        ///     I17 - Valor do Desconto
        /// </summary>
        public decimal? ValorDesconto { get; set; }

        /// <summary>
        ///     I17a - Outras despesas acessórias
        /// </summary>
        public decimal? ValorOutros { get; set; }

        /// <summary>
        ///     I17b - Indica se valor do Item (vProd) entra no valor total da NF-e (vProd)
        /// </summary>
        public IndicadorTotal IndicadorTotal { get; set; }

        /// <summary>
        ///     I18 - Declaração de Importação
        /// </summary>
        public List<DeclaracaoImportacao> DI { get; set; }

        /// <summary>
        ///     I50 - Grupo de informações de exportação para o item
        /// </summary>
        public List<DetalheExportacao> DetalheExportacao { get; set; }

        /// <summary>
        ///     I60 - Número do Pedido de Compra
        /// </summary>
        public string NumeroPedidoCompra { get; set; }

        /// <summary>
        ///     I61 - Item do Pedido de Compra
        /// </summary>
        public int? ItemPedidoCompra { get; set; }

        /// <summary>
        ///     I70 - Número de controle da FCI - Ficha de Conteúdo de Importação
        /// </summary>
        public string NumeroControleFCI { get; set; }

        /// <summary>
        /// I80 - Detalhamento de produto sujeito a rastreabilidade
        /// Versão 4.00
        /// </summary>
        public List<Rastro> Rastro { get; set; }

        /// <summary>
        ///     <para>129 (veicProd) - Detalhamento de Veículos novos</para>
        ///     <para>K01 (med) - Detalhamento de Medicamentos e de matérias-primas farmacêuticas</para>
        ///     <para>L01 (arma) - Detalhamento de Armamento</para>
        ///     <para>LA01 (comb) - Informações específicas para combustíveis líquidos e lubrificantes</para>
        /// </summary>
        public ProdutoEspecifico ProdutoEspecifico { get; set; }

        /// <summary>
        ///     LB01 - Número do RECOPI
        /// </summary>
        public string NumeroRECOPI { get; set; }
    }
}
