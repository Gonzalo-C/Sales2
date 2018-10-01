namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class CLIEN_DB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NREGUIST { get; set; }

        [Required]
        [StringLength(50)]
        public string RAZSOC { get; set; }

        [Required]
        [StringLength(13)]
        public string RUT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IMPUTABLE { get; set; }

        public int TIPO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TRANSPORTE { get; set; }

        [StringLength(100)]
        public string RAZSOC2 { get; set; }

        [Required]
        [StringLength(50)]
        public string DIR { get; set; }

        [Required]
        [StringLength(40)]
        public string COMUNA { get; set; }

        [Required]
        [StringLength(40)]
        public string CIUDAD { get; set; }

        [Required]
        [StringLength(30)]
        public string FONO { get; set; }

        [Required]
        [StringLength(30)]
        public string FAX { get; set; }

        [Required]
        [StringLength(40)]
        public string CLASE1 { get; set; }

        [Required]
        [StringLength(40)]
        public string CLASE2 { get; set; }

        [Required]
        [StringLength(40)]
        public string CLASE3 { get; set; }

        [Required]
        [StringLength(40)]
        public string CLASE4 { get; set; }

        public int XX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YY { get; set; }

        public int NIVEL1 { get; set; }

        public int NIVEL2 { get; set; }

        public int NIVEL3 { get; set; }

        public int NIVEL4 { get; set; }

        public int NIVEL5 { get; set; }

        public int NIVEL6 { get; set; }

        public int NIVEL7 { get; set; }

        public int NIVEL8 { get; set; }

        public int NIVEL9 { get; set; }

        [Required]
        [StringLength(40)]
        public string FORMAP { get; set; }

        public int DIASPAGO { get; set; }

        public int DESCONT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DESCTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? BLOQUEA { get; set; }

        public int CODVENDE { get; set; }

        public int COBRADOR { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string COMENT { get; set; }

        [StringLength(90)]
        public string GIRO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ELIMINADO { get; set; }

        [Required]
        [StringLength(4)]
        public string CATEDESC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CRED_APR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CRED_UTI { get; set; }

        public int MOROSID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CONTRTOT { get; set; }

        [Required]
        [StringLength(4)]
        public string CONTRMNY { get; set; }

        public int CONTRDESDE { get; set; }

        [Required]
        [StringLength(250)]
        public string CONTRTX { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FIJO { get; set; }

        public int XXBAK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YYBAK { get; set; }

        public DateTime? FECHACRE { get; set; }

        public DateTime? FECH1VTA { get; set; }

        public DateTime? FECULVTA { get; set; }

        public DateTime? FECHULTCON { get; set; }

        public DateTime? FECHAMODIF { get; set; }

        public DateTime? CONTRFIN { get; set; }

        [Required]
        [StringLength(4)]
        public string USERMODI { get; set; }

        public DateTime? FECHGARR { get; set; }

        public DateTime? FECHCRED { get; set; }

        [Required]
        [StringLength(20)]
        public string RELACIONAD { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(20)]
        public string BASEDATOS { get; set; }

        public DateTime? FECH1CON { get; set; }

        public DateTime? DIRE_OK { get; set; }

        public DateTime? DIRE_ERROR { get; set; }

        public int TERMOM { get; set; }

        public int ART_FACP { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NUNCA_BLOQ { get; set; }

        [Required]
        [StringLength(10)]
        public string CLAVE { get; set; }

        [Required]
        [StringLength(10)]
        public string PARENT { get; set; }

        public int JDD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RUTADUANA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CLILP { get; set; }

        [StringLength(80)]
        public string CASELEC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dimaxpag { get; set; }

        public DateTime? F_Ultima_Visita { get; set; }

        public int? CL_CTA { get; set; }

        public int? CLTESUCUR { get; set; }

        public int? CLTEELECTR { get; set; }

        [StringLength(50)]
        public string CTACTECLIEPROV { get; set; }

        [StringLength(40)]
        public string CLASE5 { get; set; }

        public int TIPODCTO { get; set; }

        [Required]
        [StringLength(150)]
        public string DIR2 { get; set; }

        public int CORRCLTE { get; set; }

        [StringLength(50)]
        public string PROD_MANT { get; set; }

        public int ESTADO_CASELECT { get; set; }

        [StringLength(500)]
        public string dir_foto { get; set; }

        [StringLength(100)]
        public string FAMILIA1 { get; set; }

        [StringLength(100)]
        public string FAMILIA2 { get; set; }

        public int? padre { get; set; }

        public decimal? orden { get; set; }

        public int? contenedor { get; set; }

        public int? ver_grilla { get; set; }

        [Required]
        [StringLength(10)]
        public string ref_minera { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] VERSION { get; set; }

        [Column(TypeName = "numeric")]
        public decimal COD_DESPACHO { get; set; }

        public int CLI_IMP_RETENC { get; set; }

        [StringLength(15)]
        public string CODGLN { get; set; }

        [StringLength(15)]
        public string CIUDAD_POSTAL { get; set; }

        public int NreguistHist { get; set; }

        public int TipoCta { get; set; }

        public List<CLIEN_DB> Listar()
        {
            var cliente = new List<CLIEN_DB>();
            try
            {
                using (var context = new Model1())
                {
                    cliente = context.CLIEN_DB.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return cliente;
        }
    }
}
