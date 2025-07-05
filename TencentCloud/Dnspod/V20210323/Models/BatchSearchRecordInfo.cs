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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchSearchRecordInfo : AbstractModel
    {
        
        /// <summary>
        /// 解析记录 ID
        /// </summary>
        [JsonProperty("RecordId")]
        public ulong? RecordId{ get; set; }

        /// <summary>
        /// 解析线路
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 记录备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// TTL(秒)
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// 记录是否启用
        /// </summary>
        [JsonProperty("Enabled")]
        public ulong? Enabled{ get; set; }

        /// <summary>
        /// 权重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 记录分组 ID
        /// </summary>
        [JsonProperty("GroupId")]
        public ulong? GroupId{ get; set; }

        /// <summary>
        /// 子域名
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// 解析值
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// MX优先级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MX")]
        public ulong? MX{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "MX", this.MX);
        }
    }
}

