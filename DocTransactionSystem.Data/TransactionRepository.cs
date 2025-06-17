using Microsoft.EntityFrameworkCore;
using DocTransactionSystem.Models;
using DocTransactionSystem.Data.Repositories;

namespace DocTransactionSystem.Data.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly AppDbContext _context;

    public TransactionRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Transaction> GetAll() => _context.Transactions.ToList();

    public Transaction GetById(int id) => _context.Transactions.Find(id);

    public void Add(Transaction transaction)
    {
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
    }

    public void Update(Transaction transaction)
    {
        _context.Transactions.Update(transaction);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var transaction = _context.Transactions.Find(id);
        if (transaction != null)
        {
            _context.Transactions.Remove(transaction);
            _context.SaveChanges();
        }
    }

    List<Transaction> ITransactionRepository.GetAll()
    {
        throw new NotImplementedException();
    }

    Transaction ITransactionRepository.GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    public void Update(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    List<Transaction> ITransactionRepository.GetAll()
    {
        throw new NotImplementedException();
    }

    Transaction ITransactionRepository.GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    public void Update(Transaction transaction)
    {
        throw new NotImplementedException();
    }
}