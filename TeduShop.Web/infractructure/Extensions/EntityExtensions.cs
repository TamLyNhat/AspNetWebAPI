using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;
using TeduShop.Web.Models;

namespace TeduShop.Web.infractructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVm)
        {
            //  public int ID { set; get; }

            //public string Name { set; get; }

            //public string Alias { set; get; }

            //public string Description { set; get; }

            //public int? ParentID { set; get; }
            //public int? DisplayOrder { set; get; }

            //public string Image { set; get; }

            //public bool? HomeFlag { set; get; }

            postCategory.ID = postCategoryVm.ID;
            postCategory.Name = postCategoryVm.Name;
            postCategory.Alias = postCategoryVm.Alias;
            postCategory.Description = postCategoryVm.Description;
            postCategory.ParentID = postCategoryVm.ParentID;
            postCategory.DisplayOrder = postCategoryVm.DisplayOrder;
            postCategory.Image = postCategoryVm.Image;
            postCategory.HomeFlag = postCategoryVm.HomeFlag;

            postCategory.CreatedDate = postCategoryVm.CreatedDate;
            postCategory.CreateBy = postCategoryVm.CreateBy;
            postCategory.UpdateDate = postCategoryVm.UpdateDate;
            postCategory.UpdateBy = postCategoryVm.UpdateBy;
            postCategory.MetaDesciption = postCategoryVm.MetaDesciption;
            postCategory.MetaKeyword = postCategoryVm.MetaKeyword;
            postCategory.Status = postCategoryVm.Status;

        }

        public static void UpdatePost(this Post post, PostViewModel postVm)
        {
            //           public int ID { set; get; }
            //public string Name { set; get; }
            //public string Alias { set; get; }

            //public int CategoryID { set; get; }

            //public string Image { set; get; }

            //public string Description { set; get; }

            //public string Content { set; get; }

            //public bool? HomeFlag { set; get; }
            //public bool? HotFlag { set; get; }
            //public int? ViewCount { set; get; }

            post.ID = postVm.ID;
            post.Name = postVm.Name;
            post.Alias = postVm.Alias;
            post.CategoryID = postVm.CategoryID;
            post.Description = postVm.Description;
            post.Content = postVm.Content;
            post.Image = postVm.Image;
            post.HomeFlag = postVm.HomeFlag;
            post.HotFlag = postVm.HotFlag;
            post.ViewCount = postVm.ViewCount;

            post.CreatedDate = post.CreatedDate;
            post.CreateBy = post.CreateBy;
            post.UpdateDate = post.UpdateDate;
            post.UpdateBy = post.UpdateBy;
            post.MetaDesciption = post.MetaDesciption;
            post.MetaKeyword = post.MetaKeyword;
            post.Status = post.Status;
        }
    }
}