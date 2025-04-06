
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace DTO{
    public class PromotionGroup
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }

        public PromotionGroup(string groupId, string groupName)
        {
            GroupId = groupId;
            GroupName = groupName;
        }
    }
 }