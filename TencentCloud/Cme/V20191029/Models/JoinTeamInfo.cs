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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JoinTeamInfo : AbstractModel
    {
        
        /// <summary>
        /// 团队 ID。
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// 团队名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 团队成员个数。
        /// </summary>
        [JsonProperty("MemberCount")]
        public ulong? MemberCount{ get; set; }

        /// <summary>
        /// 成员在团队中的角色，取值有：
        /// <li>Owner：团队所有者，添加团队成员及修改团队成员解决时不能填此角色；</li>
        /// <li>Admin：团队管理员；</li>
        /// <li>Member：普通成员。</li>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MemberCount", this.MemberCount);
            this.SetParamSimple(map, prefix + "Role", this.Role);
        }
    }
}

