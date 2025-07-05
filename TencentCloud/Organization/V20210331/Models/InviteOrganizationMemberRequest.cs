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

    public class InviteOrganizationMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// 被邀请账号Uin。
        /// </summary>
        [JsonProperty("MemberUin")]
        public long? MemberUin{ get; set; }

        /// <summary>
        /// 成员名称。最大长度为25个字符，支持英文字母、数字、汉字、符号+@、&._[]-:,
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 关系策略。取值：Financial
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 成员财务权限ID列表。取值：1-查看账单、2-查看余额、3-资金划拨、4-合并出账、5-开票、6-优惠继承、7-代付费，1、2 默认必须
        /// </summary>
        [JsonProperty("PermissionIds")]
        public ulong?[] PermissionIds{ get; set; }

        /// <summary>
        /// 成员所属部门的节点ID。可以通过[DescribeOrganizationNodes](https://cloud.tencent.com/document/product/850/82926)获取
        /// </summary>
        [JsonProperty("NodeId")]
        public long? NodeId{ get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否允许成员退出。允许：Allow，不允许：Denied。
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }

        /// <summary>
        /// 代付者Uin。成员代付费时需要
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// 互信实名主体名称。
        /// </summary>
        [JsonProperty("RelationAuthName")]
        public string RelationAuthName{ get; set; }

        /// <summary>
        /// 互信主体证明文件列表。
        /// </summary>
        [JsonProperty("AuthFile")]
        public AuthRelationFile[] AuthFile{ get; set; }

        /// <summary>
        /// 成员标签列表。最大10个
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamArraySimple(map, prefix + "PermissionIds.", this.PermissionIds);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "IsAllowQuit", this.IsAllowQuit);
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
            this.SetParamSimple(map, prefix + "RelationAuthName", this.RelationAuthName);
            this.SetParamArrayObj(map, prefix + "AuthFile.", this.AuthFile);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

