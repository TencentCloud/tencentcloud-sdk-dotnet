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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TCBAccessInstance : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 统一域名状态
        /// </summary>
        [JsonProperty("UnionStatus")]
        public long? UnionStatus{ get; set; }

        /// <summary>
        /// 是否被抢占, 被抢占表示域名被其他环境绑定了，需要解绑或者重新绑定。
        /// </summary>
        [JsonProperty("IsPreempted")]
        public bool? IsPreempted{ get; set; }

        /// <summary>
        /// icp黑名单封禁状态，0-未封禁，1-封禁
        /// </summary>
        [JsonProperty("ICPStatus")]
        public long? ICPStatus{ get; set; }

        /// <summary>
        /// 已绑定证书ID
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UnionStatus", this.UnionStatus);
            this.SetParamSimple(map, prefix + "IsPreempted", this.IsPreempted);
            this.SetParamSimple(map, prefix + "ICPStatus", this.ICPStatus);
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
        }
    }
}

