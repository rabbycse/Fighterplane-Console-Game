using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfFighterplane
{
    class Game
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select your plane:");
            Console.WriteLine("1: F22");
            Console.WriteLine("2: Mig29");
            Console.WriteLine("3: Mirage5");
            Console.WriteLine("4: Su35");

            int planeOption = int.Parse(Console.ReadLine());

            IPlane plane = GetPlane(planeOption);
            Console.WriteLine($"You have selected: {plane.Name}");

            Console.WriteLine("Please select primary weapon:");
            PrintWeaponOptions();

            int primaryWeaponOption = int.Parse(Console.ReadLine());
            plane.PrimaryWeapon = GetWeapon(primaryWeaponOption);

            Console.WriteLine("Please select secondary weapon:");
            PrintWeaponOptions();

            int secondaryWeaponOption = int.Parse(Console.ReadLine());
            plane.SecondaryWeapon = GetWeapon(secondaryWeaponOption);

            while (true)
            {
                Console.WriteLine("Please select weapon command:");
                PrintWeaponCommand();
                int weaponCommandOption = int.Parse(Console.ReadLine());

                if (weaponCommandOption == 1)
                    plane.PrimaryWeapon.Fire();
                else if (weaponCommandOption == 2)
                    plane.SecondaryWeapon.Fire();
                else
                    break;
            }

            Console.WriteLine("Game Over");
        }

        public static void PrintWeaponOptions()
        {
            Console.WriteLine("1: Bomb");
            Console.WriteLine("2: Machine Gun");
            Console.WriteLine("3: Missile");
            Console.WriteLine("4: Laser");
        }

        public static void PrintWeaponCommand()
        {
            Console.WriteLine("1: Primary");
            Console.WriteLine("2: Secondary");
            Console.WriteLine("3: Exit");
        }

        public static IPlane GetPlane(int option)
        {
            switch (option)
            {
                case 1:
                    return new F22();
                case 2:
                    return new Mig29();
                case 3:
                    return new Mirage5();
                case 4:
                    return new Su35();
                default:
                    return null;
            }
        }

        public static IWeapon GetWeapon(int option)
        {
            switch (option)
            {
                case 1:
                    return new Bomb();
                case 2:
                    return new MachineGun();
                case 3:
                    return new Missile();
                case 4:
                    return new Laser();
                default:
                    return null;
            }
        }

    }


    public interface IPlane
    {
        IWeapon PrimaryWeapon { get; set; }
        IWeapon SecondaryWeapon { get; set; }
        string Name { get; }
    }

    public interface IWeapon
    {
        void Fire();
    }

    public class F22 : IPlane
    {
        public IWeapon PrimaryWeapon { get; set; }
        public IWeapon SecondaryWeapon { get; set; }

        public string Name => "F22";
    }

    public class Mig29 : IPlane
    {
        public IWeapon PrimaryWeapon { get; set; }
        public IWeapon SecondaryWeapon { get; set; }

        public string Name => "Mig 29";
    }

    public class Mirage5 : IPlane
    {
        public IWeapon PrimaryWeapon { get; set; }
        public IWeapon SecondaryWeapon { get; set; }

        public string Name => "Mirage 5";
    }

    public class Su35 : IPlane
    {
        public IWeapon PrimaryWeapon { get; set; }
        public IWeapon SecondaryWeapon { get; set; }

        public string Name => "Su 35";
    }

    public class Bomb : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Dropping Bomb");
        }
    }

    public class Missile : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Firing Missile");
        }
    }

    public class MachineGun : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Firing Machine Gun");
        }
    }

    public class Laser : IWeapon
    {
        public void Fire()
        {
            Console.WriteLine("Firing Laser");
        }
    }
}
    
