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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmAssetAccount : AbstractModel
    {
        
        /// <summary>
        /// 账号名
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 主机地址
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 账号类型。 0-未定义 1-服务账号 2-个人账号 3-临时账号
        /// </summary>
        [JsonProperty("AccountType")]
        public long? AccountType{ get; set; }

        /// <summary>
        /// 所属对象。uin或个人id
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// 权限信息
        /// </summary>
        [JsonProperty("Privilege")]
        public DspmDbAccountPrivilege Privilege{ get; set; }

        /// <summary>
        /// 状态。 0-不活跃 1-活跃 2-已删除
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 账号创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 访问权限生效时间。
        /// </summary>
        [JsonProperty("ValidateFrom")]
        public string ValidateFrom{ get; set; }

        /// <summary>
        /// 访问权限失效时间。
        /// </summary>
        [JsonProperty("ValidateTo")]
        public string ValidateTo{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 是否新账号
        /// </summary>
        [JsonProperty("IsNewAccount")]
        public long? IsNewAccount{ get; set; }

        /// <summary>
        /// 身份类型。非身份账号为null。0-未定义 2-长期身份 3-临时身份
        /// </summary>
        [JsonProperty("IdentifyType")]
        public long? IdentifyType{ get; set; }

        /// <summary>
        /// 所属云账号uin用户。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public DspmUinUser OwnerUin{ get; set; }

        /// <summary>
        /// 所属个人用户信息。
        /// </summary>
        [JsonProperty("Person")]
        public DspmPersonUser Person{ get; set; }

        /// <summary>
        /// 风险统计信息
        /// </summary>
        [JsonProperty("RiskCount")]
        public DspmRiskCount RiskCount{ get; set; }

        /// <summary>
        /// 预设权限。
        /// </summary>
        [JsonProperty("PresetPrivilege")]
        public DspmDbAccountPrivilege PresetPrivilege{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamObj(map, prefix + "Privilege.", this.Privilege);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ValidateFrom", this.ValidateFrom);
            this.SetParamSimple(map, prefix + "ValidateTo", this.ValidateTo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "IsNewAccount", this.IsNewAccount);
            this.SetParamSimple(map, prefix + "IdentifyType", this.IdentifyType);
            this.SetParamObj(map, prefix + "OwnerUin.", this.OwnerUin);
            this.SetParamObj(map, prefix + "Person.", this.Person);
            this.SetParamObj(map, prefix + "RiskCount.", this.RiskCount);
            this.SetParamObj(map, prefix + "PresetPrivilege.", this.PresetPrivilege);
        }
    }
}

