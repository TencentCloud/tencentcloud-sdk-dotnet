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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProductDataRecord : AbstractModel
    {
        
        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 产品名称(英文)
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 宽度，单位毫米
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// 高度，单位毫米
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// 深度，单位毫米
        /// </summary>
        [JsonProperty("Depth")]
        public string Depth{ get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [JsonProperty("KeyWord")]
        public string KeyWord{ get; set; }

        /// <summary>
        /// 简短描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonProperty("ImageLink")]
        public string[] ImageLink{ get; set; }

        /// <summary>
        /// 厂家名称
        /// </summary>
        [JsonProperty("ManufacturerName")]
        public string ManufacturerName{ get; set; }

        /// <summary>
        /// 厂家地址
        /// </summary>
        [JsonProperty("ManufacturerAddress")]
        public string ManufacturerAddress{ get; set; }

        /// <summary>
        /// 企业社会信用代码
        /// </summary>
        [JsonProperty("FirmCode")]
        public string FirmCode{ get; set; }

        /// <summary>
        /// 表示数据查询状态
        /// checkResult	状态说明
        /// 1	 经查，该商品条码已在中国物品编码中心注册
        /// 2	经查，该厂商识别代码已在中国物品编码中心注册，但编码信息未按规定通报。
        /// 3	经查，该厂商识别代码已于xxxxx注销，请关注产品生产日期。
        /// 4	经查，该企业以及条码未经条码中心注册，属于违法使用
        /// -1	经查，该商品条码被冒用
        /// -2	经查，该厂商识别代码已在中国物品编码中心注册，但该产品已经下市
        /// S001                未找到该厂商识别代码的注册信息。
        /// S002		该厂商识别代码已经在GS1注册，但编码信息未通报
        /// S003		该商品条码已在GS1通报
        /// S004		该商品条码已注销
        /// S005		数字不正确。GS1前缀（3位国家/地区代码）用于特殊用途。
        /// E001		完整性失败：此GTIN的长度无效。
        /// E002		完整性失败：校验位不正确。
        /// E003		完整性失败：字符串包含字母数字字符。
        /// E004		数字不正确。GS1前缀（3位国家/地区代码）不存在。
        /// E005		数字不正确。GS1前缀（3位国家/地区代码）用于特殊用途。
        /// E006		数字不正确。尚未分配该GS1公司前缀。
        /// E008	        经查，该企业厂商识别代码以及条码尚未通报
        /// </summary>
        [JsonProperty("CheckResult")]
        public string CheckResult{ get; set; }

        /// <summary>
        /// UNSPSC分类码
        /// </summary>
        [JsonProperty("CategoryCode")]
        public string CategoryCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "KeyWord", this.KeyWord);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "ImageLink.", this.ImageLink);
            this.SetParamSimple(map, prefix + "ManufacturerName", this.ManufacturerName);
            this.SetParamSimple(map, prefix + "ManufacturerAddress", this.ManufacturerAddress);
            this.SetParamSimple(map, prefix + "FirmCode", this.FirmCode);
            this.SetParamSimple(map, prefix + "CheckResult", this.CheckResult);
            this.SetParamSimple(map, prefix + "CategoryCode", this.CategoryCode);
        }
    }
}

