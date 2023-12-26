public abstract class OrderProcessor {
    // Template method
    public void ProcessOrder() {
        CheckStock();
        CalculateCost();
        ApplyDiscount();
        FinalizeOrder();
    }

    // Common steps
    protected void CheckStock() {
        Console.WriteLine("Checking stock...");
    }

    protected void FinalizeOrder() {
        Console.WriteLine("Finalizing order...");
    }

    // Steps to be implemented by subclasses
    protected abstract void CalculateCost();
    protected abstract void ApplyDiscount();
}

public class RegularOrderProcessor : OrderProcessor {
    protected override void CalculateCost() {
        Console.WriteLine("Calculating cost for a regular order...");
    }

    protected override void ApplyDiscount() {
        Console.WriteLine("Applying discount for a regular order...");
    }
}

public class BulkOrderProcessor : OrderProcessor {
    protected override void CalculateCost() {
        Console.WriteLine("Calculating cost for a bulk order...");
    }

    protected override void ApplyDiscount() {
        Console.WriteLine("Applying bulk order discount...");
    }
}

public class ExpressOrderProcessor : OrderProcessor {
    protected override void CalculateCost() {
        Console.WriteLine("Calculating cost for an express order...");
    }

    protected override void ApplyDiscount() {
        Console.WriteLine("Applying express order discount...");
    }
}

class Program {
    static void Main(string[] args) {
        OrderProcessor regularOrder = new RegularOrderProcessor();
        regularOrder.ProcessOrder();

        OrderProcessor bulkOrder = new BulkOrderProcessor();
        bulkOrder.ProcessOrder();

        OrderProcessor expressOrder = new ExpressOrderProcessor();
        expressOrder.ProcessOrder();
    }
}
