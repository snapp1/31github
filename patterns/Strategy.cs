// The strategy interface for document operations
public interface IDocumentStrategy {
    void Save();
    void Print();
    void Preview();
}

// Concrete strategy for reports
public class ReportStrategy : IDocumentStrategy {
    public void Save() {
        Console.WriteLine("Saving Report...");
    }

    public void Print() {
        Console.WriteLine("Printing Report...");
    }

    public void Preview() {
        Console.WriteLine("Previewing Report...");
    }
}

// Concrete strategy for invoices
public class InvoiceStrategy : IDocumentStrategy {
    public void Save() {
        Console.WriteLine("Saving Invoice...");
    }

    public void Print() {
        Console.WriteLine("Printing Invoice...");
    }

    public void Preview() {
        Console.WriteLine("Previewing Invoice...");
    }
}

// Add more strategies for other document types
