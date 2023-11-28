using System.ComponentModel.DataAnnotations.Schema;
using AuctionService.Entities;

namespace AuctionService;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
    public string ImageUrl { get; set; }

    // nav properties
    public Auction Auction { get; set; }
    public Guid AuctionId { get; set; }
}
