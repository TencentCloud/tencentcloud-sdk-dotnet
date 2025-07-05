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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVULListResponse : AbstractModel
    {
        
        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 漏洞列表
        /// </summary>
        [JsonProperty("Data")]
        public VULBaseInfo[] Data{ get; set; }

        /// <summary>
        /// 漏洞类型列表
        /// </summary>
        [JsonProperty("VULTypeLists")]
        public FilterDataObject[] VULTypeLists{ get; set; }

        /// <summary>
        /// 风险等级列表
        /// </summary>
        [JsonProperty("RiskLevels")]
        public FilterDataObject[] RiskLevels{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public FilterDataObject[] Tags{ get; set; }

        /// <summary>
        /// 产品支持情况
        /// </summary>
        [JsonProperty("ProductSupport")]
        public FilterDataObject[] ProductSupport{ get; set; }

        /// <summary>
        /// 产品支持情况
        /// </summary>
        [JsonProperty("CheckStatus")]
        public FilterDataObject[] CheckStatus{ get; set; }

        /// <summary>
        /// 攻击热度枚举
        /// </summary>
        [JsonProperty("AttackHeat")]
        public FilterDataObject[] AttackHeat{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArrayObj(map, prefix + "VULTypeLists.", this.VULTypeLists);
            this.SetParamArrayObj(map, prefix + "RiskLevels.", this.RiskLevels);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "ProductSupport.", this.ProductSupport);
            this.SetParamArrayObj(map, prefix + "CheckStatus.", this.CheckStatus);
            this.SetParamArrayObj(map, prefix + "AttackHeat.", this.AttackHeat);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

