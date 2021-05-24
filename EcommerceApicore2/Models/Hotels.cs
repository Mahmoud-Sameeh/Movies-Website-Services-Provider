using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EcommerceApicore2.Models
{
    public class ApplicationUser: IdentityUser
    { 
    }
    public class Movie
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Imgdir { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual Studio Studio { get; set; }
         public virtual Director Director { get; set; }
         public virtual ICollection<MovieCharacter> MovieCharacters { get; set; }
 
        public virtual ICollection<Category> Categories { get; set; }


    }
    public class Studio
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Founded { get; set; }
        public string Owner { get; set; }
        [JsonIgnore]

        public virtual ICollection<Movie> Movies { get; set; }

    }
    public class Director
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
    public class MovieCharacter
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Actor Actor { get; set; }


    }
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<MovieCharacter> MovieCharacters { get; set; }

    }


    public class Type
    {
        public int Id { get; set; }
        public string type { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

    }
    public enum ReviewState
    {
        Poor,
        NotBAd,
        Good,
        VeryGood,
        Amazing,
        Excellent

    }
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public ReviewState ReviewState { get; set; }
        public Movie Movie { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    public List<Movie> Movies { set; get; }
    }
    //public class HotelEntities
    //{
    //    [Key]
    //    public int Id { get; set; }
    //}
    //public class Guest: HotelEntities
    //{
    //    [Required]
    //    public string SSN { get; set; }
    //    [Required]
    //    public string Name { get; set; }
    //    [Required]
    //    [EmailAddress]
    //    public string Email { get; set; }
    //    [Required]
    //    [Phone]


    //    public string Phone { get; set; }
    //    public int AdultsNumber { get; set; }
    //    public int ChildrenNumber { get; set; }
    //    public List<Room> Rooms { get; set; }
    //}
    //public class Room : HotelEntities
    //{
    //    public DateTime From { get; set; }
    //    public DateTime To { get; set; }
    //    public bool IsEmpty { get; set; }
    //    public int GuestID { set; get; }
    //    public int RoomTypeID { set; get; }
    //    public int MealPlanID { set; get; }
    //    public Guest Guest { get; set; }
    //    public RoomType RoomType { set; get; }
    //    public MealPlan MealPlan { get; set; }
    //}
    //public class MealPlan : HotelEntities
    //{
    //    public string MealType { get; set; }
    //    public int LowSeasonPrice { get; set; }
    //    public int HighSeasonPrice { get; set; }
    //    public List<Room> Rooms { get; set; }
    //}
    //public class RoomType : HotelEntities
    //{
    //    [Required]
    //    public string TypeName { get; set; }
    //    [Required]
    //    public string Descrption { get; set; }
    //    [Required]
    //    public int Price { get; set; }
    //    public List<Room> Rooms { get; set; }
    //}
    //public class Reservation : HotelEntities
    //{
    //    public string Transaction_ID { get; set; }
    //    public string GuestName { get; set; }
    //    public int GuestNumber { get; set; }
    //    public int RoomNumber { get; set; }
    //    public string RoomType { get; set; }
    //    public int RoomRate { get; set; }
    //    public DateTime CheckIn { get; set; }
    //    public DateTime CheckOut { get; set; }
    //    public int N_Of_Days { get; set; }
    //    public int N_Of_Adults { get; set; }
    //    public int N_Of_Children { get; set; }
    //    public string DiscountType { get; set; }
    //    public string ToTalPayment { get; set; }
    //    public string AdvancePayment { get; set; }
    //}
}
