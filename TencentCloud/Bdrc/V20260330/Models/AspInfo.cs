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

    public class AspInfo : AbstractModel
    {
        
        /// <summary>
        /// 备份策略ID
        /// </summary>
        [JsonProperty("AspId")]
        public string AspId{ get; set; }

        /// <summary>
        /// 备份策略名称
        /// </summary>
        [JsonProperty("AspName")]
        public string AspName{ get; set; }

        /// <summary>
        /// 备份策略状态
        /// </summary>
        [JsonProperty("AspState")]
        public string AspState{ get; set; }

        /// <summary>
        /// 备份策略执行详情
        /// </summary>
        [JsonProperty("Policy")]
        public Policy[] Policy{ get; set; }

        /// <summary>
        /// 备份策略是否使能
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// 是否永久保留
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// 保留时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AspId", this.AspId);
            this.SetParamSimple(map, prefix + "AspName", this.AspName);
            this.SetParamSimple(map, prefix + "AspState", this.AspState);
            this.SetParamArrayObj(map, prefix + "Policy.", this.Policy);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

