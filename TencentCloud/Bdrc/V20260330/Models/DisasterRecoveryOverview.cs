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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisasterRecoveryOverview : AbstractModel
    {
        
        /// <summary>
        /// 地域 ID
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 站点对总数
        /// </summary>
        [JsonProperty("SitePairCount")]
        public long? SitePairCount{ get; set; }

        /// <summary>
        /// 跨地域站点对数
        /// </summary>
        [JsonProperty("SitePairCrossRegionCount")]
        public long? SitePairCrossRegionCount{ get; set; }

        /// <summary>
        /// 跨可用区站点对数
        /// </summary>
        [JsonProperty("SitePairCrossZoneCount")]
        public long? SitePairCrossZoneCount{ get; set; }

        /// <summary>
        /// 跨云站点对数
        /// </summary>
        [JsonProperty("SitePairCrossCloudCount")]
        public long? SitePairCrossCloudCount{ get; set; }

        /// <summary>
        /// 保护组总数
        /// </summary>
        [JsonProperty("ProtectGroupCount")]
        public long? ProtectGroupCount{ get; set; }

        /// <summary>
        /// 跨地域保护组数
        /// </summary>
        [JsonProperty("ProtectGroupCrossRegionCount")]
        public long? ProtectGroupCrossRegionCount{ get; set; }

        /// <summary>
        /// 跨可用区保护组数
        /// </summary>
        [JsonProperty("ProtectGroupCrossZoneCount")]
        public long? ProtectGroupCrossZoneCount{ get; set; }

        /// <summary>
        /// 跨云保护组数
        /// </summary>
        [JsonProperty("ProtectGroupCrossCloudCount")]
        public long? ProtectGroupCrossCloudCount{ get; set; }

        /// <summary>
        /// 复制对总数
        /// </summary>
        [JsonProperty("CopyPairCount")]
        public long? CopyPairCount{ get; set; }

        /// <summary>
        /// RPO 正常的复制对数
        /// </summary>
        [JsonProperty("CopyPairSuccessRPOCount")]
        public long? CopyPairSuccessRPOCount{ get; set; }

        /// <summary>
        /// RPO 异常的复制对数
        /// </summary>
        [JsonProperty("CopyPairErrorRPOCount")]
        public long? CopyPairErrorRPOCount{ get; set; }

        /// <summary>
        /// 演练对总数
        /// </summary>
        [JsonProperty("DrillPairCount")]
        public long? DrillPairCount{ get; set; }

        /// <summary>
        /// 演练中
        /// </summary>
        [JsonProperty("DrillPairDrillingCount")]
        public long? DrillPairDrillingCount{ get; set; }

        /// <summary>
        /// 演练失败
        /// </summary>
        [JsonProperty("DrillPairFailedCount")]
        public long? DrillPairFailedCount{ get; set; }

        /// <summary>
        /// 演练成功
        /// </summary>
        [JsonProperty("DrillPairSuccessCount")]
        public long? DrillPairSuccessCount{ get; set; }

        /// <summary>
        /// 受保护资源总数
        /// </summary>
        [JsonProperty("ProtectedResourceCount")]
        public long? ProtectedResourceCount{ get; set; }

        /// <summary>
        /// 受保护资源-复制中
        /// </summary>
        [JsonProperty("ProtectedResourceCopyingCount")]
        public long? ProtectedResourceCopyingCount{ get; set; }

        /// <summary>
        /// 受保护资源-已停止/初始化
        /// </summary>
        [JsonProperty("ProtectedResourceStoppedCount")]
        public long? ProtectedResourceStoppedCount{ get; set; }

        /// <summary>
        /// 切换失败
        /// </summary>
        [JsonProperty("FailoverFailedCount")]
        public long? FailoverFailedCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SitePairCount", this.SitePairCount);
            this.SetParamSimple(map, prefix + "SitePairCrossRegionCount", this.SitePairCrossRegionCount);
            this.SetParamSimple(map, prefix + "SitePairCrossZoneCount", this.SitePairCrossZoneCount);
            this.SetParamSimple(map, prefix + "SitePairCrossCloudCount", this.SitePairCrossCloudCount);
            this.SetParamSimple(map, prefix + "ProtectGroupCount", this.ProtectGroupCount);
            this.SetParamSimple(map, prefix + "ProtectGroupCrossRegionCount", this.ProtectGroupCrossRegionCount);
            this.SetParamSimple(map, prefix + "ProtectGroupCrossZoneCount", this.ProtectGroupCrossZoneCount);
            this.SetParamSimple(map, prefix + "ProtectGroupCrossCloudCount", this.ProtectGroupCrossCloudCount);
            this.SetParamSimple(map, prefix + "CopyPairCount", this.CopyPairCount);
            this.SetParamSimple(map, prefix + "CopyPairSuccessRPOCount", this.CopyPairSuccessRPOCount);
            this.SetParamSimple(map, prefix + "CopyPairErrorRPOCount", this.CopyPairErrorRPOCount);
            this.SetParamSimple(map, prefix + "DrillPairCount", this.DrillPairCount);
            this.SetParamSimple(map, prefix + "DrillPairDrillingCount", this.DrillPairDrillingCount);
            this.SetParamSimple(map, prefix + "DrillPairFailedCount", this.DrillPairFailedCount);
            this.SetParamSimple(map, prefix + "DrillPairSuccessCount", this.DrillPairSuccessCount);
            this.SetParamSimple(map, prefix + "ProtectedResourceCount", this.ProtectedResourceCount);
            this.SetParamSimple(map, prefix + "ProtectedResourceCopyingCount", this.ProtectedResourceCopyingCount);
            this.SetParamSimple(map, prefix + "ProtectedResourceStoppedCount", this.ProtectedResourceStoppedCount);
            this.SetParamSimple(map, prefix + "FailoverFailedCount", this.FailoverFailedCount);
        }
    }
}

