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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDosageDetail : AbstractModel
    {
        
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 账号 ID 是用户在腾讯云的唯一账号标识
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 用量统计类型
        /// </summary>
        [JsonProperty("DosageType")]
        public string DosageType{ get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 子产品编码
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 组件类型编码
        /// </summary>
        [JsonProperty("BillingItemCode")]
        public string BillingItemCode{ get; set; }

        /// <summary>
        /// 组件编码
        /// </summary>
        [JsonProperty("SubBillingItemCode")]
        public string SubBillingItemCode{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductCodeName")]
        public string ProductCodeName{ get; set; }

        /// <summary>
        /// 子产品名称
        /// </summary>
        [JsonProperty("SubProductCodeName")]
        public string SubProductCodeName{ get; set; }

        /// <summary>
        /// 组件类型
        /// </summary>
        [JsonProperty("BillingItemCodeName")]
        public string BillingItemCodeName{ get; set; }

        /// <summary>
        /// 组件
        /// </summary>
        [JsonProperty("SubBillingItemCodeName")]
        public string SubBillingItemCodeName{ get; set; }

        /// <summary>
        /// 用量单位
        /// </summary>
        [JsonProperty("DosageUnit")]
        public string DosageUnit{ get; set; }

        /// <summary>
        /// 用量起始时间
        /// </summary>
        [JsonProperty("DosageBeginTime")]
        public string DosageBeginTime{ get; set; }

        /// <summary>
        /// 用量截止时间
        /// </summary>
        [JsonProperty("DosageEndTime")]
        public string DosageEndTime{ get; set; }

        /// <summary>
        /// 标准用量
        /// </summary>
        [JsonProperty("DosageValue")]
        public float? DosageValue{ get; set; }

        /// <summary>
        /// 抵扣用量
        /// </summary>
        [JsonProperty("DeductValue")]
        public float? DeductValue{ get; set; }

        /// <summary>
        /// 抵扣余量
        /// </summary>
        [JsonProperty("RemainValue")]
        public float? RemainValue{ get; set; }

        /// <summary>
        /// sdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public string SdkAppId{ get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        [JsonProperty("AttrStr")]
        public JsonObject[] AttrStr{ get; set; }

        /// <summary>
        /// 用量模板名称
        /// </summary>
        [JsonProperty("SheetName")]
        public string[] SheetName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "DosageType", this.DosageType);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "BillingItemCode", this.BillingItemCode);
            this.SetParamSimple(map, prefix + "SubBillingItemCode", this.SubBillingItemCode);
            this.SetParamSimple(map, prefix + "ProductCodeName", this.ProductCodeName);
            this.SetParamSimple(map, prefix + "SubProductCodeName", this.SubProductCodeName);
            this.SetParamSimple(map, prefix + "BillingItemCodeName", this.BillingItemCodeName);
            this.SetParamSimple(map, prefix + "SubBillingItemCodeName", this.SubBillingItemCodeName);
            this.SetParamSimple(map, prefix + "DosageUnit", this.DosageUnit);
            this.SetParamSimple(map, prefix + "DosageBeginTime", this.DosageBeginTime);
            this.SetParamSimple(map, prefix + "DosageEndTime", this.DosageEndTime);
            this.SetParamSimple(map, prefix + "DosageValue", this.DosageValue);
            this.SetParamSimple(map, prefix + "DeductValue", this.DeductValue);
            this.SetParamSimple(map, prefix + "RemainValue", this.RemainValue);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamArrayObj(map, prefix + "AttrStr.", this.AttrStr);
            this.SetParamArraySimple(map, prefix + "SheetName.", this.SheetName);
        }
    }
}

