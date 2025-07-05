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

    public class RiskRuleItem : AbstractModel
    {
        
        /// <summary>
        /// 风险检查项ID
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// 云厂商名称
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例类型名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [JsonProperty("RiskTitle")]
        public string RiskTitle{ get; set; }

        /// <summary>
        /// 检查类型
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// 风险危害
        /// </summary>
        [JsonProperty("RiskInfluence")]
        public string RiskInfluence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "RiskTitle", this.RiskTitle);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "RiskInfluence", this.RiskInfluence);
        }
    }
}

