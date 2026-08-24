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

    public class SupportRegionInfo : AbstractModel
    {
        
        /// <summary>
        /// 生产地域。
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// 支持类型：REGION（地域级，整个生产地域均支持容灾）；ZONE（可用区级，按 SupportZoneRules 控制粒度）。
        /// </summary>
        [JsonProperty("SupportType")]
        public string SupportType{ get; set; }

        /// <summary>
        /// 配置状态：valid（生效）/ invalid（停用）。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 可用区级容灾规则列表。仅当 SupportType=ZONE 时有效；REGION 类型时该字段返回空数组。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportZoneRules")]
        public SupportZoneRule[] SupportZoneRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SupportType", this.SupportType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "SupportZoneRules.", this.SupportZoneRules);
        }
    }
}

