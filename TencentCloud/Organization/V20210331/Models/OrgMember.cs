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
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// 成员名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 成员类型，邀请：Invite， 创建：Create
        /// </summary>
        [JsonProperty("MemberType")]
        public string MemberType{ get; set; }

        /// <summary>
        /// 关系策略类型
        /// </summary>
        [JsonProperty("OrgPolicyType")]
        public string OrgPolicyType{ get; set; }

        /// <summary>
        /// 关系策略名
        /// </summary>
        [JsonProperty("OrgPolicyName")]
        public string OrgPolicyName{ get; set; }

        /// <summary>
        /// 关系策略权限
        /// </summary>
        [JsonProperty("OrgPermission")]
        public OrgPermission[] OrgPermission{ get; set; }

        /// <summary>
        /// 所属节点ID
        /// </summary>
        [JsonProperty("NodeId")]
        public long? NodeId{ get; set; }

        /// <summary>
        /// 所属节点名
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否允许成员退出。允许：Allow，不允许：Denied。
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }

        /// <summary>
        /// 代付者Uin
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// 代付者名称
        /// </summary>
        [JsonProperty("PayName")]
        public string PayName{ get; set; }

        /// <summary>
        /// 管理身份
        /// </summary>
        [JsonProperty("OrgIdentity")]
        public MemberIdentity[] OrgIdentity{ get; set; }

        /// <summary>
        /// 安全信息绑定状态  未绑定：Unbound，待激活：Valid，绑定成功：Success，绑定失败：Failed
        /// </summary>
        [JsonProperty("BindStatus")]
        public string BindStatus{ get; set; }

        /// <summary>
        /// 成员权限状态 已确认：Confirmed ，待确认：UnConfirmed
        /// </summary>
        [JsonProperty("PermissionStatus")]
        public string PermissionStatus{ get; set; }

        /// <summary>
        /// 成员标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 腾讯云昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }


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
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
            this.SetParamSimple(map, prefix + "PayName", this.PayName);
            this.SetParamArrayObj(map, prefix + "OrgIdentity.", this.OrgIdentity);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "PermissionStatus", this.PermissionStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
        }
    }
}

