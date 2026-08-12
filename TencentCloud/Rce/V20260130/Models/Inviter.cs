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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Inviter : AbstractModel
    {
        
        /// <summary>
        /// <p>邀请人ID</p>
        /// </summary>
        [JsonProperty("InviterUserId")]
        public string InviterUserId{ get; set; }

        /// <summary>
        /// <p>邀请人电话号码</p><p>参数格式：符合E.164标准的带“+”、地区编码和号码的格式</p>
        /// </summary>
        [JsonProperty("InviterPhone")]
        public string InviterPhone{ get; set; }

        /// <summary>
        /// <p>邀请码</p>
        /// </summary>
        [JsonProperty("InviteCode")]
        public string InviteCode{ get; set; }

        /// <summary>
        /// <p>邀请渠道</p>
        /// </summary>
        [JsonProperty("InviteChannel")]
        public string InviteChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InviterUserId", this.InviterUserId);
            this.SetParamSimple(map, prefix + "InviterPhone", this.InviterPhone);
            this.SetParamSimple(map, prefix + "InviteCode", this.InviteCode);
            this.SetParamSimple(map, prefix + "InviteChannel", this.InviteChannel);
        }
    }
}

