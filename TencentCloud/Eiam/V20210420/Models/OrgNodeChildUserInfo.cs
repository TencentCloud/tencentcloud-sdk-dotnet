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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrgNodeChildUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 机构ID，是机构节点全局唯一标识，长度限制：64个字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgNodeId")]
        public string OrgNodeId{ get; set; }

        /// <summary>
        /// 用户信息列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserInfo")]
        public UserInfo[] UserInfo{ get; set; }

        /// <summary>
        /// 当前机构节点下的用户总数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalUserNum")]
        public long? TotalUserNum{ get; set; }

        /// <summary>
        /// 组织机构ID路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgNodeIdPath")]
        public string OrgNodeIdPath{ get; set; }

        /// <summary>
        /// 组织机构名称路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgNodeNamePath")]
        public string OrgNodeNamePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrgNodeId", this.OrgNodeId);
            this.SetParamArrayObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "TotalUserNum", this.TotalUserNum);
            this.SetParamSimple(map, prefix + "OrgNodeIdPath", this.OrgNodeIdPath);
            this.SetParamSimple(map, prefix + "OrgNodeNamePath", this.OrgNodeNamePath);
        }
    }
}

