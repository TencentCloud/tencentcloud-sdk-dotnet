/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Iir.V20200417.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductInfo : AbstractModel
    {
        
        /// <summary>
        /// 1表示找到同款商品，以下字段为同款商品信息； 
        /// 0表示未找到同款商品， 具体商品信息为空（参考价格、名称、品牌等），仅提供商品类目。  
        /// 是否找到同款的判断依据为Score分值，分值越大则同款的可能性越大。
        /// </summary>
        [JsonProperty("FindSKU")]
        public long? FindSKU{ get; set; }

        /// <summary>
        /// 本商品在图片中的坐标，表示为矩形框的四个顶点坐标。
        /// </summary>
        [JsonProperty("Location")]
        public Location Location{ get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// 参考价格，综合多个信息源，仅供参考。
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 识别结果的商品类目。 
        /// 包含：鞋、图书音像、箱包、美妆个护、服饰、家电数码、玩具乐器、食品饮料、珠宝、家居家装、药品、酒水、绿植园艺、其他商品、非商品等。 
        /// 当类别为“非商品”时，除Location、Score和本字段之外的商品信息为空。
        /// </summary>
        [JsonProperty("ProductCategory")]
        public string ProductCategory{ get; set; }

        /// <summary>
        /// 输入图片中的主体物品和输出结果的相似度。分值越大，输出结果与输入图片是同款的可能性越高。
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// 搜索到的商品配图URL
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FindSKU", this.FindSKU);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "ProductCategory", this.ProductCategory);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Image", this.Image);
        }
    }
}

