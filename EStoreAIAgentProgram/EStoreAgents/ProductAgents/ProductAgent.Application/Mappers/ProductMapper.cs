using ProductAgent.Domain.DTOs;
using ProductAgent.Domain.Models;

namespace ProductAgent.Application.Mappers
{
    public static class ProductMapper
    {

        /// <summary>
        /// ToMapProducts is an Extension Method
        /// </summary>
        /// <param name="productModels"></param>
        /// <returns></returns>
        public static List<ProductDTO>
            ToMapProducts(this List<ProductModel> productModels)
        {
            List<ProductDTO> productDTOs = null;

            if (productModels != null || productModels.Count != 0)
            {
                productDTOs = new List<ProductDTO>();

                foreach(ProductModel productModel in productModels)
                {
                    productDTOs.Add(productModel.ToMapProduct());
                }
            }

            return productDTOs;
        }

        public static ProductDTO
            ToMapProduct(this ProductModel productModel)
        {
            ProductDTO productDTO = null;
            if (productModel != null)
            {
                productDTO = new ProductDTO(productModel.Id,
                    productModel.ProductName,
                    productModel.ProductDescription,
                    productModel.BrandName,
                    productModel.Category,
                    productModel.ImageName,
                    productModel.ImageURL,
                    productModel.Price,
                    productModel.Quantity);
            }

            return productDTO;
        }
    }
}
