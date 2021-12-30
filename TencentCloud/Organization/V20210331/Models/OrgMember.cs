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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrgMember : AbstractModel
    {
        
        /// <summary>
        /// 成员Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// 成员名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 成员类型，邀请：Invite， 创建：Create
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemberType")]
        public string MemberType{ get; set; }

        /// <summary>
        /// 关系策略类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgPolicyType")]
        public string OrgPolicyType{ get; set; }

        /// <summary>
        /// 关系策略名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgPolicyName")]
        public string OrgPolicyName{ get; set; }

        /// <summary>
        /// 关系策略权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgPermission")]
        public OrgPermission[] OrgPermission{ get; set; }

        /// <summary>
        /// 所属节点ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeId")]
        public long? NodeId{ get; set; }

        /// <summary>
        /// 所属节点名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否允许成员退出。允许：Allow，不允许：Denied。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MemberType", this.MemberType);
            this.SetParamSimple(map, prefix + "OrgPolicyType", this.OrgPolicyType);
            this.SetParamSimple(map, prefix + "OrgPolicyName", this.OrgPolicyName);
            this.SetParamArrayObj(map, prefix + "OrgPermission.", this.OrgPermission);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsAllowQuit", this.IsAllowQuit);
        }
    }
}

