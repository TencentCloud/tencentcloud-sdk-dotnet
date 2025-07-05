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

    public class UpdateOrganizationMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// 成员Uin。
        /// </summary>
        [JsonProperty("MemberUin")]
        public ulong? MemberUin{ get; set; }

        /// <summary>
        /// 成员名称。最大长度为25个字符，支持英文字母、数字、汉字、符号+@、&._[]-:,
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 备注。最大长度为40个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 关系策略类型。PolicyType不为空，PermissionIds不能为空。取值：Financial
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 成员财务权限ID列表。PermissionIds不为空，PolicyType不能为空。
        /// 取值：1-查看账单、2-查看余额、3-资金划拨、4-合并出账、5-开票、6-优惠继承、7-代付费、8-成本分析，如果有值，1、2 默认必须
        /// </summary>
        [JsonProperty("PermissionIds")]
        public ulong?[] PermissionIds{ get; set; }

        /// <summary>
        /// 是否允许成员退出组织。取值：Allow-允许、Denied-不允许
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }

        /// <summary>
        /// 代付者Uin。成员财务权限有代付费时需要，取值为成员对应主体的主体管理员Uin
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// 是否同步组织成员名称到成员账号昵称。取值： 1-同步 0-不同步
        /// </summary>
        [JsonProperty("IsModifyNickName")]
        public ulong? IsModifyNickName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberUin", this.MemberUin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamArraySimple(map, prefix + "PermissionIds.", this.PermissionIds);
            this.SetParamSimple(map, prefix + "IsAllowQuit", this.IsAllowQuit);
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
            this.SetParamSimple(map, prefix + "IsModifyNickName", this.IsModifyNickName);
        }
    }
}

