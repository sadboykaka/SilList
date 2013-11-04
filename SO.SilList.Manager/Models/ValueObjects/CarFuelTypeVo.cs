
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SO.SilList.Manager.Models.ValueObjects
{
     
    [Table("CarFuelType", Schema = "app" )]
    [Serializable]
    public partial class CarFuelTypeVo
    {
    		
    	[DisplayName("Fuel")]
    	[Key]
        public int carFuelTypeId { get; set; }
    		
    	[DisplayName("Name")]
    	[Required]
    	[StringLength(50)]
        public string name { get; set; }
    		
    	[DisplayName("Created")]
    	[Required]
        public System.DateTime created { get; set; }
    		
    	[DisplayName("Modified")]
    	[Required]
        public System.DateTime modified { get; set; }
    		
    	[DisplayName("Created By")]
        public Nullable<int> createdBy { get; set; }
    		
    	[DisplayName("Modified By")]
        public Nullable<int> modifiedBy { get; set; }
    		
    	[DisplayName("Is Active")]
    	[Required]
        public bool isActive { get; set; }

        //[Association("CarFuelType_Car", "carFuelTypeId", "carFuelTypeId", IsForeignKey = true)]
        //public List<CarVo> car { get; set; }

    	public CarFuelTypeVo(){
    			this.isActive = true;

    	}
    }
}
