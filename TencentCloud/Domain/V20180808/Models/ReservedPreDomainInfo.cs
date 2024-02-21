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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedPreDomainInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 1. 预定成功 2. 预定失败（预定失败Reason字段将会被赋值）3. 域名交割中 4. 域名交割完成
        /// </summary>
        [JsonProperty("ReservedStatus")]
        public long? ReservedStatus{ get; set; }

        /// <summary>
        /// 域名预定失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 预计变更所有权时间（仅用于参考，实际时间会存在误差）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChangeOwnerTime")]
        public string ChangeOwnerTime{ get; set; }

        /// <summary>
        /// 注册时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegTime")]
        public string RegTime{ get; set; }

        /// <summary>
        /// 到期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 资源ID，用于删除资源信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "ReservedStatus", this.ReservedStatus);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "ChangeOwnerTime", this.ChangeOwnerTime);
            this.SetParamSimple(map, prefix + "RegTime", this.RegTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

