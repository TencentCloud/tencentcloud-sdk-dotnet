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

    public class SupportZoneRule : AbstractModel
    {
        
        /// <summary>
        /// 生产可用区。
        /// </summary>
        [JsonProperty("SourceZone")]
        public string SourceZone{ get; set; }

        /// <summary>
        /// 是否支持容灾到生产地域内的全部可用区。true 时 TargetZones 可忽略。
        /// </summary>
        [JsonProperty("IsAllZoneSupport")]
        public bool? IsAllZoneSupport{ get; set; }

        /// <summary>
        /// 目标可用区列表。当 IsAllZoneSupport=false 时枚举具体可容灾到的可用区。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetZones")]
        public string[] TargetZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceZone", this.SourceZone);
            this.SetParamSimple(map, prefix + "IsAllZoneSupport", this.IsAllZoneSupport);
            this.SetParamArraySimple(map, prefix + "TargetZones.", this.TargetZones);
        }
    }
}

