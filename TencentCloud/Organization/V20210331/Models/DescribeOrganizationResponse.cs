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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrganizationResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>企业组织ID。</p>
        /// </summary>
        [JsonProperty("OrgId")]
        public long? OrgId{ get; set; }

        /// <summary>
        /// <p>创建者UIN。</p>
        /// </summary>
        [JsonProperty("HostUin")]
        public long? HostUin{ get; set; }

        /// <summary>
        /// <p>创建者昵称。</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>企业组织类型。</p>
        /// </summary>
        [JsonProperty("OrgType")]
        public long? OrgType{ get; set; }

        /// <summary>
        /// <p>是否组织管理员。是：true ，否：false</p>
        /// </summary>
        [JsonProperty("IsManager")]
        public bool? IsManager{ get; set; }

        /// <summary>
        /// <p>策略类型。财务管理：Financial</p>
        /// </summary>
        [JsonProperty("OrgPolicyType")]
        public string OrgPolicyType{ get; set; }

        /// <summary>
        /// <p>策略名。</p>
        /// </summary>
        [JsonProperty("OrgPolicyName")]
        public string OrgPolicyName{ get; set; }

        /// <summary>
        /// <p>成员财务权限列表。</p>
        /// </summary>
        [JsonProperty("OrgPermission")]
        public OrgPermission[] OrgPermission{ get; set; }

        /// <summary>
        /// <p>组织根节点ID。</p>
        /// </summary>
        [JsonProperty("RootNodeId")]
        public long? RootNodeId{ get; set; }

        /// <summary>
        /// <p>组织创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>成员加入时间。</p>
        /// </summary>
        [JsonProperty("JoinTime")]
        public string JoinTime{ get; set; }

        /// <summary>
        /// <p>成员是否允许退出。允许：Allow，不允许：Denied</p>
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }

        /// <summary>
        /// <p>代付者Uin。</p>
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// <p>代付者名称。</p>
        /// </summary>
        [JsonProperty("PayName")]
        public string PayName{ get; set; }

        /// <summary>
        /// <p>是否可信服务管理员。是：true，否：false</p>
        /// </summary>
        [JsonProperty("IsAssignManager")]
        public bool? IsAssignManager{ get; set; }

        /// <summary>
        /// <p>是否实名主体管理员。是：true，否：false</p>
        /// </summary>
        [JsonProperty("IsAuthManager")]
        public bool? IsAuthManager{ get; set; }

        /// <summary>
        /// <p>创建/邀请成员时可设置的财务权限列表</p>
        /// </summary>
        [JsonProperty("MemberPermissionOptions")]
        public MemberPermissionOption[] MemberPermissionOptions{ get; set; }

        /// <summary>
        /// <p>创建/邀请成员时的默认付费方式。</p><p>枚举值：</p><ul><li>SelfPay： 自付</li><li>BehalfPay： 代付</li></ul>
        /// </summary>
        [JsonProperty("DefaultPayType")]
        public string DefaultPayType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamSimple(map, prefix + "IsAssignManager", this.IsAssignManager);
            this.SetParamSimple(map, prefix + "IsAuthManager", this.IsAuthManager);
            this.SetParamArrayObj(map, prefix + "MemberPermissionOptions.", this.MemberPermissionOptions);
            this.SetParamSimple(map, prefix + "DefaultPayType", this.DefaultPayType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

