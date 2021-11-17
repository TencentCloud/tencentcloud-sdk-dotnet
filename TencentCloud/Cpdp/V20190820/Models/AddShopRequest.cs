/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddShopRequest : AbstractModel
    {
        
        /// <summary>
        /// 收单系统分配的开放ID
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 门店简称（例如：南山店）
        /// </summary>
        [JsonProperty("ShopName")]
        public string ShopName{ get; set; }

        /// <summary>
        /// 商户编号
        /// </summary>
        [JsonProperty("MerchantNo")]
        public string MerchantNo{ get; set; }

        /// <summary>
        /// 整体门面（含招牌）图片【公共区】
        /// </summary>
        [JsonProperty("PictureTwo")]
        public string PictureTwo{ get; set; }

        /// <summary>
        /// 店内环境图片【公共区】
        /// </summary>
        [JsonProperty("PictureThree")]
        public string PictureThree{ get; set; }

        /// <summary>
        /// 整体门面（含招牌）图片【公共区】
        /// </summary>
        [JsonProperty("PictureOne")]
        public string PictureOne{ get; set; }

        /// <summary>
        /// 门店电话
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// 机构门店主键（系统有唯一性校验），建议使用门店表的主键ID，防止重复添加门店
        /// </summary>
        [JsonProperty("OutShopId")]
        public string OutShopId{ get; set; }

        /// <summary>
        /// 门店所在的城市编码
        /// </summary>
        [JsonProperty("CityId")]
        public string CityId{ get; set; }

        /// <summary>
        /// 门店全称（例如：江山小厨（南山店））
        /// </summary>
        [JsonProperty("ShopFullName")]
        public string ShopFullName{ get; set; }

        /// <summary>
        /// 营业时间，多个以小写逗号分开(9:00-12:00,13:00-18:00)
        /// </summary>
        [JsonProperty("OpenHours")]
        public string OpenHours{ get; set; }

        /// <summary>
        /// 门店详细地址，不含省市区县名称
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 收单系统分配的密钥
        /// </summary>
        [JsonProperty("OpenKey")]
        public string OpenKey{ get; set; }

        /// <summary>
        /// 沙箱环境填sandbox，正式环境不填
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// 高德地图纬度
        /// </summary>
        [JsonProperty("LatitudeTwo")]
        public string LatitudeTwo{ get; set; }

        /// <summary>
        /// 其他照片【公共区】
        /// </summary>
        [JsonProperty("OtherPicture")]
        public string OtherPicture{ get; set; }

        /// <summary>
        /// 高德地图经度
        /// </summary>
        [JsonProperty("LongitudeTwo")]
        public string LongitudeTwo{ get; set; }

        /// <summary>
        /// 门店负责人
        /// </summary>
        [JsonProperty("Contact")]
        public string Contact{ get; set; }

        /// <summary>
        /// 百度地图经度
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude{ get; set; }

        /// <summary>
        /// 百度地图纬度
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude{ get; set; }

        /// <summary>
        /// 负责人手机号码
        /// </summary>
        [JsonProperty("FinancialTelephone")]
        public string FinancialTelephone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "ShopName", this.ShopName);
            this.SetParamSimple(map, prefix + "MerchantNo", this.MerchantNo);
            this.SetParamSimple(map, prefix + "PictureTwo", this.PictureTwo);
            this.SetParamSimple(map, prefix + "PictureThree", this.PictureThree);
            this.SetParamSimple(map, prefix + "PictureOne", this.PictureOne);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "OutShopId", this.OutShopId);
            this.SetParamSimple(map, prefix + "CityId", this.CityId);
            this.SetParamSimple(map, prefix + "ShopFullName", this.ShopFullName);
            this.SetParamSimple(map, prefix + "OpenHours", this.OpenHours);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "OpenKey", this.OpenKey);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "LatitudeTwo", this.LatitudeTwo);
            this.SetParamSimple(map, prefix + "OtherPicture", this.OtherPicture);
            this.SetParamSimple(map, prefix + "LongitudeTwo", this.LongitudeTwo);
            this.SetParamSimple(map, prefix + "Contact", this.Contact);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "FinancialTelephone", this.FinancialTelephone);
        }
    }
}

