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

    public class Conditions : AbstractModel
    {
        
        /// <summary>
        /// 只支持6和12两个值
        /// </summary>
        [JsonProperty("TimeRange")]
        public ulong? TimeRange{ get; set; }

        /// <summary>
        /// 产品名称代码
        /// </summary>
        [JsonProperty("BusinessCode")]
        public string BusinessCode{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 付费模式，可选prePay和postPay
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 资源关键字
        /// </summary>
        [JsonProperty("ResourceKeyword")]
        public string ResourceKeyword{ get; set; }

        /// <summary>
        /// 产品名称代码
        /// </summary>
        [JsonProperty("BusinessCodes")]
        public string[] BusinessCodes{ get; set; }

        /// <summary>
        /// 子产品名称代码
        /// </summary>
        [JsonProperty("ProductCodes")]
        public string[] ProductCodes{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("RegionIds")]
        public long?[] RegionIds{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 付费模式，可选prePay和postPay
        /// </summary>
        [JsonProperty("PayModes")]
        public string[] PayModes{ get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonProperty("ActionTypes")]
        public string[] ActionTypes{ get; set; }

        /// <summary>
        /// 是否隐藏0元流水
        /// </summary>
        [JsonProperty("HideFreeCost")]
        public long? HideFreeCost{ get; set; }

        /// <summary>
        /// 排序规则，可选desc和asc
        /// </summary>
        [JsonProperty("OrderByCost")]
        public string OrderByCost{ get; set; }

        /// <summary>
        /// 交易ID
        /// </summary>
        [JsonProperty("BillIds")]
        public string[] BillIds{ get; set; }

        /// <summary>
        /// 组件编码
        /// </summary>
        [JsonProperty("ComponentCodes")]
        public string[] ComponentCodes{ get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("FileTypes")]
        public string[] FileTypes{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong?[] Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
            this.SetParamSimple(map, prefix + "BusinessCode", this.BusinessCode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ResourceKeyword", this.ResourceKeyword);
            this.SetParamArraySimple(map, prefix + "BusinessCodes.", this.BusinessCodes);
            this.SetParamArraySimple(map, prefix + "ProductCodes.", this.ProductCodes);
            this.SetParamArraySimple(map, prefix + "RegionIds.", this.RegionIds);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "PayModes.", this.PayModes);
            this.SetParamArraySimple(map, prefix + "ActionTypes.", this.ActionTypes);
            this.SetParamSimple(map, prefix + "HideFreeCost", this.HideFreeCost);
            this.SetParamSimple(map, prefix + "OrderByCost", this.OrderByCost);
            this.SetParamArraySimple(map, prefix + "BillIds.", this.BillIds);
            this.SetParamArraySimple(map, prefix + "ComponentCodes.", this.ComponentCodes);
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamArraySimple(map, prefix + "FileTypes.", this.FileTypes);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
        }
    }
}

