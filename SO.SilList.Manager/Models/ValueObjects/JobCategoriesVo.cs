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
    [Table("JobCategories", Schema = "data" )]
    [Serializable]
    public partial class JobCategoriesVo
    {
    		
    	[DisplayName("job Category")]
    	[Key]
        public Guid jobCategoriesId { get; set; }

        [DisplayName("job Category Type")]  // this was missing
        public int? jobCategoryTypeId { get; set; }

    	[DisplayName("job")]
        public Nullable<System.Guid> jobId { get; set; }
    		
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
    		
    	[DisplayName("Active")]
        public bool isActive { get; set; }


        [ForeignKey("jobId")]
        public virtual JobVo job { get; set; }

        [ForeignKey("jobCategoryTypeId")]
        public virtual JobCategoryTypeVo jobCategoryType { get; set; }

        public JobCategoriesVo(){

            this.jobCategoriesId = Guid.NewGuid();
    	 this.isActive = true;
    	}
    }
}
