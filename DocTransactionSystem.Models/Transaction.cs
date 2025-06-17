namespace DocTransactionSystem.Models;

public class Transaction
{
    public int Id { get; set; }
    public int TransactionCode { get; set; }
    public DateTime ReceivingDate { get; set; }
    public string UserName { get; set; }
    public DateTime EntryDate { get; set; } = DateTime.Now;
    public string DeclareType { get; set; }
    public string Content { get; set; }
    public string Department { get; set; }
    public string BeneficiaryName { get; set; }
    public string DeclareReceiver { get; set; }
    public DateTime? ProvidingDate { get; set; }
    public string DeclarationNumber { get; set; }
    public DateTime? DeclarationDate { get; set; }
    public DateTime? ConfirmDate { get; set; }
    public string Confirmer { get; set; }
}