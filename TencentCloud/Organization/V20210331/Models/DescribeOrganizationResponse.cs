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

    public class DescribeOrganizationResponse : AbstractModel
    {
        
        /// <summary>
        /// 企业组织ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgId")]
        public long? OrgId{ get; set; }

        /// <summary>
        /// 创建者UIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostUin")]
        public long? HostUin{ get; set; }

        /// <summary>
        /// 创建者昵称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 企业组织类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgType")]
        public long? OrgType{ get; set; }

        /// <summary>
        /// 组织管理员：true，组织成员：false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsManager")]
        public bool? IsManager{ get; set; }

        /// <summary>
        /// 策略类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgPolicyType")]
        public string OrgPolicyType{ get; set; }

        /// <summary>
        /// 策略名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgPolicyName")]
        public string OrgPolicyName{ get; set; }

        /// <summary>
        /// 策略权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgPermission")]
        public OrgPermission[] OrgPermission{ get; set; }

        /// <summary>
        /// 根节点ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootNodeId")]
        public long? RootNodeId{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 成员加入时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JoinTime")]
        public string JoinTime{ get; set; }

        /// <summary>
        /// 是否允许退出。允许：Allow，不允许：Denied。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }

        /// <summary>
        /// 代付者Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// 代付者名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayName")]
        public string PayName{ get; set; }

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
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamSimple(map, prefix + "HostUin", this.HostUin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "OrgType", this.OrgType);
            this.SetParamSimple(map, prefix + "IsManager", this.IsManager);
            this.SetParamSimple(map, prefix + "OrgPolicyType", this.OrgPolicyType);
            this.SetParamSimple(map, prefix + "OrgPolicyName", this.OrgPolicyName);
            this.SetParamArrayObj(map, prefix + "OrgPermission.", this.OrgPermission);
            this.SetParamSimple(map, prefix + "RootNodeId", this.RootNodeId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "JoinTime", this.JoinTime);
            this.SetParamSimple(map, prefix + "IsAllowQuit", this.IsAllowQuit);
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
            this.SetParamSimple(map, prefix + "PayName", this.PayName);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

