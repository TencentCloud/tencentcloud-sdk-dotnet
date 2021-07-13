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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAccountSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 策略数
        /// </summary>
        [JsonProperty("Policies")]
        public ulong? Policies{ get; set; }

        /// <summary>
        /// 角色数
        /// </summary>
        [JsonProperty("Roles")]
        public ulong? Roles{ get; set; }

        /// <summary>
        /// 身份提供商数
        /// </summary>
        [JsonProperty("Idps")]
        public ulong? Idps{ get; set; }

        /// <summary>
        /// 子账户数
        /// </summary>
        [JsonProperty("User")]
        public ulong? User{ get; set; }

        /// <summary>
        /// 分组数
        /// </summary>
        [JsonProperty("Group")]
        public ulong? Group{ get; set; }

        /// <summary>
        /// 分组用户总数
        /// </summary>
        [JsonProperty("Member")]
        public ulong? Member{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Policies", this.Policies);
            this.SetParamSimple(map, prefix + "Roles", this.Roles);
            this.SetParamSimple(map, prefix + "Idps", this.Idps);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Member", this.Member);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

