
      
       
        List<Rock> rockList = new List<Rock>();
        Console.Write("Hur många stenar vill du skapa? ");
        int numRocks = int.Parse(Console.ReadLine());

        for (int i = 0; i < numRocks; i++)
        {
            Console.Write($"Ange vikten för sten {i + 1}: ");
            double weight = double.Parse(Console.ReadLine());
            rockList.Add(new Rock(weight));
        }

        Console.WriteLine("Vikterna på stenarna:");
        foreach (var rock in rockList)
        {
            Console.WriteLine(rock.GetWeight());
        }

       
        Worker worker = new Worker("John", 30);
        worker.SetWage(2000);
        Console.WriteLine($"{worker.GetName()}, {worker.GetAge()} år, lön: {worker.GetWage()}");

        BlueCollar blueCollar = new BlueCollar("Bob", 40);
        blueCollar.SetWage(2500);
        blueCollar.Build();
        Console.WriteLine($"{blueCollar.GetName()}, {blueCollar.GetAge()} år, lön: {blueCollar.GetWage()}");

        WhiteCollar whiteCollar = new WhiteCollar("Alice", 35);
        whiteCollar.SetWage(3000);
        whiteCollar.DrinkCoffee();
        Console.WriteLine($"{whiteCollar.GetName()}, {whiteCollar.GetAge()} år, lön: {whiteCollar.GetWage()}");

 
        List<Hardware> hardwareList = new List<Hardware>();

        while (true)
        {
            Console.WriteLine("Vilken typ av hårdvara vill du skapa? (HardDrive, Processor, GraphicsCard, eller avsluta med 'exit')");
            string choice = Console.ReadLine().ToLower();

            if (choice == "exit") break;

            Console.Write("Ange namn: ");
            string name = Console.ReadLine();
            Console.Write("Ange pris: ");
            double price = double.Parse(Console.ReadLine());

            if (choice == "harddrive")
            {
                Console.Write("Ange kapacitet (GB): ");
                int capacity = int.Parse(Console.ReadLine());
                hardwareList.Add(new HardDrive(name, price, capacity));
            }
            else if (choice == "processor")
            {
                Console.Write("Ange antal kärnor: ");
                int cores = int.Parse(Console.ReadLine());
                Console.Write("Ange klockhastighet (GHz): ");
                double clockSpeed = double.Parse(Console.ReadLine());
                hardwareList.Add(new Processor(name, price, cores, clockSpeed));
            }
            else if (choice == "graphicscard")
            {
                Console.Write("Ange minne (GB): ");
                int memory = int.Parse(Console.ReadLine());
                hardwareList.Add(new GraphicsCard(name, price, memory));
            }
        }

        Console.WriteLine("Information om alla hårdvaror:");
        foreach (var hardware in hardwareList)
        {
            Console.WriteLine($"Namn: {hardware.GetName()}, Pris: {hardware.GetPrice()}");
        }
    
