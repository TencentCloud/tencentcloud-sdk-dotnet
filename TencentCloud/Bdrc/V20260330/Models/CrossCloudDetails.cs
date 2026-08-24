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

    public class CrossCloudDetails : AbstractModel
    {
        
        /// <summary>
        /// 源端云名称（跨云对端云名称）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceCloudName")]
        public string SourceCloudName{ get; set; }

        /// <summary>
        /// 目标端云名称（跨云本端云名称）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetCloudName")]
        public string TargetCloudName{ get; set; }

        /// <summary>
        /// 源端云AppId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceAppId")]
        public long? SourceAppId{ get; set; }

        /// <summary>
        /// 源端云主账号 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceUin")]
        public string SourceUin{ get; set; }

        /// <summary>
        /// 源端云子账号 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceSubAccountUin")]
        public string SourceSubAccountUin{ get; set; }

        /// <summary>
        /// 源端云用户名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceUserName")]
        public string SourceUserName{ get; set; }

        /// <summary>
        /// 目标端云AppId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetAppId")]
        public long? TargetAppId{ get; set; }

        /// <summary>
        /// 目标端云主账号 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetUin")]
        public string TargetUin{ get; set; }

        /// <summary>
        /// 目标端云子账号 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetSubAccountUin")]
        public string TargetSubAccountUin{ get; set; }

        /// <summary>
        /// 对端云的地域显示名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeerRegionName")]
        public string PeerRegionName{ get; set; }

        /// <summary>
        /// 对端云的可用区显示名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeerZoneName")]
        public string PeerZoneName{ get; set; }

        /// <summary>
        /// 对端云的VPC显示名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeerVpcName")]
        public string PeerVpcName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceCloudName", this.SourceCloudName);
            this.SetParamSimple(map, prefix + "TargetCloudName", this.TargetCloudName);
            this.SetParamSimple(map, prefix + "SourceAppId", this.SourceAppId);
            this.SetParamSimple(map, prefix + "SourceUin", this.SourceUin);
            this.SetParamSimple(map, prefix + "SourceSubAccountUin", this.SourceSubAccountUin);
            this.SetParamSimple(map, prefix + "SourceUserName", this.SourceUserName);
            this.SetParamSimple(map, prefix + "TargetAppId", this.TargetAppId);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "TargetSubAccountUin", this.TargetSubAccountUin);
            this.SetParamSimple(map, prefix + "PeerRegionName", this.PeerRegionName);
            this.SetParamSimple(map, prefix + "PeerZoneName", this.PeerZoneName);
            this.SetParamSimple(map, prefix + "PeerVpcName", this.PeerVpcName);
        }
    }
}

