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

    public class ModifyTeamMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 团队 ID。
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// 团队成员 ID。
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// 成员备注，长度不能超过15个字符。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 成员角色，可取值有：
        /// <li>Admin：团队管理员；</li>
        /// <li>Member：普通成员。</li>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，可以修改任意团队成员的信息。如果指定操作者，则操作者必须为团队的管理员或者所有者。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

