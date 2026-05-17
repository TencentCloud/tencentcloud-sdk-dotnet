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

    public class CosOverview : AbstractModel
    {
        
        /// <summary>
        /// 资产总数
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// 需要立即处理的资产数
        /// </summary>
        [JsonProperty("AlarmAssetCount")]
        public long? AlarmAssetCount{ get; set; }

        /// <summary>
        /// 需要加固的资产数
        /// </summary>
        [JsonProperty("RiskAssetCount")]
        public long? RiskAssetCount{ get; set; }

        /// <summary>
        /// 告警总数
        /// </summary>
        [JsonProperty("AlarmCount")]
        public long? AlarmCount{ get; set; }

        /// <summary>
        /// 当日新增告警总数
        /// </summary>
        [JsonProperty("IncrementAlarmCount")]
        public long? IncrementAlarmCount{ get; set; }

        /// <summary>
        /// 风险总数
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// 当日新增告警总数
        /// </summary>
        [JsonProperty("IncrementRiskCount")]
        public long? IncrementRiskCount{ get; set; }

        /// <summary>
        /// 风险top详情
        /// </summary>
        [JsonProperty("RiskTop")]
        public CosRiskInfo[] RiskTop{ get; set; }

        /// <summary>
        /// 告警风险top
        /// </summary>
        [JsonProperty("AlarmTop")]
        public CosRiskInfo[] AlarmTop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "AlarmAssetCount", this.AlarmAssetCount);
            this.SetParamSimple(map, prefix + "RiskAssetCount", this.RiskAssetCount);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "IncrementAlarmCount", this.IncrementAlarmCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "IncrementRiskCount", this.IncrementRiskCount);
            this.SetParamArrayObj(map, prefix + "RiskTop.", this.RiskTop);
            this.SetParamArrayObj(map, prefix + "AlarmTop.", this.AlarmTop);
        }
    }
}

