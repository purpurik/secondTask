using System;

class CPU
{
    public string Model { get; }
    public double FrequencyGHz { get; }

    public CPU(string model, double frequencyGHz)
    {
        Model = model;
        FrequencyGHz = frequencyGHz;
    }

    public void Start()
    {
        Console.WriteLine($"Процессор {Model} запущен с частотой {FrequencyGHz} GHz.");
    }

    public void Shutdown()
    {
        Console.WriteLine($"Процессор {Model} выключен.");
    }
}

class RAM
{
    public int SizeGB { get; }
    public int SpeedMHz { get; }

    public RAM(int sizeGB, int speedMHz)
    {
        SizeGB = sizeGB;
        SpeedMHz = speedMHz;
    }

    public void Load()
    {
        Console.WriteLine($"Оперативная память {SizeGB}GB загружена (Скорость: {SpeedMHz} MHz).");
    }

    public void Clear()
    {
        Console.WriteLine("Оперативная память очищена.");
    }
}

class GPU
{
    public string Model { get; }
    public int MemoryGB { get; }

    public GPU(string model, int memoryGB)
    {
        Model = model;
        MemoryGB = memoryGB;
    }

    public void Start()
    {
        Console.WriteLine($"Видеокарта {Model} запущена с {MemoryGB}GB памяти.");
    }

    public void Shutdown()
    {
        Console.WriteLine($"Видеокарта {Model} выключена.");
    }
}

class Computer
{
    private CPU cpu;
    private RAM ram;
    private GPU gpu;

    public Computer(CPU cpu, RAM ram, GPU gpu)
    {
        this.cpu = cpu;
        this.ram = ram;
        this.gpu = gpu;
    }

    public void PowerOn()
    {
        Console.WriteLine("Включение компьютера...");
        cpu.Start();
        ram.Load();
        gpu.Start();
        Console.WriteLine("Компьютер успешно включен!");
    }

    public void PowerOff()
    {
        Console.WriteLine("Выключение компьютера...");
        gpu.Shutdown();
        ram.Clear();
        cpu.Shutdown();
        Console.WriteLine("Компьютер выключен.");
    }
}

class Program
{
    static void Main()
    {
        CPU cpu = new CPU("Intel Core i7", 3.8);
        RAM ram = new RAM(16, 3200);
        GPU gpu = new GPU("NVIDIA RTX 3080", 10);

        Computer myComputer = new Computer(cpu, ram, gpu);

        myComputer.PowerOn();
        Console.WriteLine();
        myComputer.PowerOff();
    }
}