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

    public class AssetStatisticsInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>资产总数</p>
        /// </summary>
        [JsonProperty("AssetTotalCount")]
        public ulong? AssetTotalCount{ get; set; }

        /// <summary>
        /// <p>近7天新增资产数量</p>
        /// </summary>
        [JsonProperty("AssetAddCount")]
        public ulong? AssetAddCount{ get; set; }

        /// <summary>
        /// <p>有风险资产数量</p>
        /// </summary>
        [JsonProperty("RiskAssetCount")]
        public ulong? RiskAssetCount{ get; set; }

        /// <summary>
        /// <p>有告警资产数量</p>
        /// </summary>
        [JsonProperty("AlarmAssetCount")]
        public ulong? AlarmAssetCount{ get; set; }

        /// <summary>
        /// <p>公网资产数量</p>
        /// </summary>
        [JsonProperty("PublicAssetCount")]
        public ulong? PublicAssetCount{ get; set; }

        /// <summary>
        /// <p>暴露资产数量</p>
        /// </summary>
        [JsonProperty("ExposeAssetCount")]
        public ulong? ExposeAssetCount{ get; set; }

        /// <summary>
        /// <p>主机资产数量</p>
        /// </summary>
        [JsonProperty("CloudHostAssetCount")]
        public ulong? CloudHostAssetCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetTotalCount", this.AssetTotalCount);
            this.SetParamSimple(map, prefix + "AssetAddCount", this.AssetAddCount);
            this.SetParamSimple(map, prefix + "RiskAssetCount", this.RiskAssetCount);
            this.SetParamSimple(map, prefix + "AlarmAssetCount", this.AlarmAssetCount);
            this.SetParamSimple(map, prefix + "PublicAssetCount", this.PublicAssetCount);
            this.SetParamSimple(map, prefix + "ExposeAssetCount", this.ExposeAssetCount);
            this.SetParamSimple(map, prefix + "CloudHostAssetCount", this.CloudHostAssetCount);
        }
    }
}

