/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupLine : AbstractModel
    {
        
        /// <summary>
        /// 分组线路id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DnsLineId")]
        public ulong? DnsLineId{ get; set; }

        /// <summary>
        /// 父节点 0为根节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Parent")]
        public ulong? Parent{ get; set; }

        /// <summary>
        /// 线路名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LineName")]
        public string LineName{ get; set; }

        /// <summary>
        /// 10=9 DNSPod 线路 id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LineId")]
        public string LineId{ get; set; }

        /// <summary>
        /// 是否已使用过
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Useful")]
        public bool? Useful{ get; set; }

        /// <summary>
        /// 0为未使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubGroup")]
        public ulong? SubGroup{ get; set; }

        /// <summary>
        /// 权限标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinePackage")]
        public ulong? LinePackage{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DnsLineId", this.DnsLineId);
            this.SetParamSimple(map, prefix + "Parent", this.Parent);
            this.SetParamSimple(map, prefix + "LineName", this.LineName);
            this.SetParamSimple(map, prefix + "LineId", this.LineId);
            this.SetParamSimple(map, prefix + "Useful", this.Useful);
            this.SetParamSimple(map, prefix + "SubGroup", this.SubGroup);
            this.SetParamSimple(map, prefix + "LinePackage", this.LinePackage);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
        }
    }
}

