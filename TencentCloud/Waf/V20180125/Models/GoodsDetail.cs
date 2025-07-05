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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GoodsDetail : AbstractModel
    {
        
        /// <summary>
        /// 时间间隔
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 单位，支持m、y、d
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 二级产品码
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 计费策略id
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// waf产品码
        /// </summary>
        [JsonProperty("ProductInfo")]
        public ProductInfo[] ProductInfo{ get; set; }

        /// <summary>
        /// waf实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// QPS数量
        /// </summary>
        [JsonProperty("ElasticQps")]
        public long? ElasticQps{ get; set; }

        /// <summary>
        /// 弹性账单
        /// </summary>
        [JsonProperty("FlexBill")]
        public long? FlexBill{ get; set; }

        /// <summary>
        /// 1:自动续费，0:不自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// waf购买的实际地域信息
        /// </summary>
        [JsonProperty("RealRegion")]
        public long? RealRegion{ get; set; }

        /// <summary>
        /// Waf实例对应的二级产品码
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 计费细项标签数组
        /// </summary>
        [JsonProperty("LabelTypes")]
        public string[] LabelTypes{ get; set; }

        /// <summary>
        /// 计费细项标签数量，一般和SvLabelType一一对应
        /// </summary>
        [JsonProperty("LabelCounts")]
        public long?[] LabelCounts{ get; set; }

        /// <summary>
        /// 变配使用，实例到期时间
        /// </summary>
        [JsonProperty("CurDeadline")]
        public string CurDeadline{ get; set; }

        /// <summary>
        /// 对存在的实例购买bot 或api 安全
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamArrayObj(map, prefix + "ProductInfo.", this.ProductInfo);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ElasticQps", this.ElasticQps);
            this.SetParamSimple(map, prefix + "FlexBill", this.FlexBill);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "RealRegion", this.RealRegion);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "LabelTypes.", this.LabelTypes);
            this.SetParamArraySimple(map, prefix + "LabelCounts.", this.LabelCounts);
            this.SetParamSimple(map, prefix + "CurDeadline", this.CurDeadline);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

