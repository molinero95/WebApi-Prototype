using System;
using System.Collections.Concurrent;
using System.Data.SqlClient;
using System.Threading;

namespace Application.Data.Transactions
{
    public class TransactionManager: IDisposable
    {
        private SqlConnection _connection;
        private ConcurrentDictionary<Thread, SqlTransaction> _aliveTransactions;

        public TransactionManager(string connectionString)
        {
            _aliveTransactions = new ConcurrentDictionary<Thread, SqlTransaction>();
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
            foreach(var tr in _aliveTransactions.Values)
            {
                tr.Rollback();
            }
            _aliveTransactions.Clear();
        }

        public void NewTransaction()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
                _connection.Open();
            _aliveTransactions.GetOrAdd(Thread.CurrentThread, _connection.BeginTransaction());
        }

        public SqlTransaction GetTransaction()
        {
            if (_aliveTransactions == null)
                throw new Exception("");
            _aliveTransactions.TryGetValue(Thread.CurrentThread, out SqlTransaction transaction);
            return transaction;
        }

        public bool DeleteTransaction()
        {
            bool res = _aliveTransactions.TryRemove(Thread.CurrentThread, out SqlTransaction transaction);
            transaction.Rollback(); //Por si el usuario no cierra
            return res;
        }


    }
}
