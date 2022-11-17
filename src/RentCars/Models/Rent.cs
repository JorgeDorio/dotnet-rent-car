using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
	public Vehicle Vehicle { get; set; }
	public Person Person { get; set; }
	public int DaysRented { get; set; }
	public double Price { get; set; }
	public RentStatus Status { get; set; }

	public Rent(Vehicle vehicle, Person person, int daysRented)
	{
		Vehicle = vehicle;
		Person = person;
		DaysRented = daysRented;
		if (person.GetType() == typeof(PhysicalPerson)){
			Price = vehicle.PricePerDay * daysRented;
		} else {
			Price = vehicle.PricePerDay * daysRented * 0.9; 
		}

		Status = RentStatus.Confirmed;


		Vehicle.IsRented = true;

		Person.Debit = Price;
	}

	public void Cancel()
	{        
		throw new NotImplementedException();
	}

	public void Finish()
	{        
		throw new NotImplementedException();
	}
}
