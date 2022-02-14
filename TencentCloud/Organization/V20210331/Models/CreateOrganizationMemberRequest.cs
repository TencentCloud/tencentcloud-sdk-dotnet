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

    public class CreateOrganizationMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 关系策略  取值：Financial
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 关系权限 取值：1-查看账单、2-查看余额、3-资金划拨、4-合并出账、5-开票 ，1、2 默认必须
        /// </summary>
        [JsonProperty("PermissionIds")]
        public ulong?[] PermissionIds{ get; set; }

        /// <summary>
        /// 成员所属部门的节点ID
        /// </summary>
        [JsonProperty("NodeId")]
        public long? NodeId{ get; set; }

        /// <summary>
        /// 账号名
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 重试创建传记录ID
        /// </summary>
        [JsonProperty("RecordId")]
        public long? RecordId{ get; set; }

        /// <summary>
        /// 代付者Uin
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// 管理身份
        /// </summary>
        [JsonProperty("IdentityRoleID")]
        public ulong?[] IdentityRoleID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamArraySimple(map, prefix + "PermissionIds.", this.PermissionIds);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
            this.SetParamArraySimple(map, prefix + "IdentityRoleID.", this.IdentityRoleID);
        }
    }
}

