using System.ComponentModel.DataAnnotations;

namespace DevExpress.Server.Data.Entities;

public class DimCustomer
{
    [Key]
    public int CustomerKey { get; set; }
    public int? GeographyKey { get; set; }
    public required string CustomerAlternateKey { get; set; }
    public string? Title { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public bool? NameStyle { get; set; }
    public DateTime? BirthDate { get; set; }
    public char? MaritalStatus { get; set; }
    public string? Suffix { get; set; }
    public string? Gender { get; set; }
    public string? EmailAddress { get; set; }
    public decimal? YearlyIncome { get; set; }
    public byte? TotalChildren { get; set; }
    public byte? NumberChildrenAtHome { get; set; }
    public string? EnglishEducation { get; set; }
    public string? SpanishEducation { get; set; }
    public string? FrenchEducation { get; set; }
    public string? EnglishOccupation { get; set; }
    public string? SpanishOccupation { get; set; }
    public string? FrenchOccupation { get; set; }
    public char? HouseOwnerFlag { get; set; }
    public byte? NumberCarsOwned { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? Phone { get; set; }
    public DateTime? DateFirstPurchase { get; set; }
    public string? CommuteDistance { get; set; }
}