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

    public class DspmAssetAccountIdentify : AbstractModel
    {
        
        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 所属云账号uin用户。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public DspmUinUser OwnerUin{ get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        [JsonProperty("IsManager")]
        public long? IsManager{ get; set; }

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
        /// 权限信息
        /// </summary>
        [JsonProperty("Privilege")]
        public DspmDbAccountPrivilege Privilege{ get; set; }

        /// <summary>
        /// 活跃状态。 0-不活跃 1-活跃
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
        /// 访客权限申请次数
        /// </summary>
        [JsonProperty("PersonApplyCount")]
        public long? PersonApplyCount{ get; set; }

        /// <summary>
        /// 资产名
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 风险统计信息
        /// </summary>
        [JsonProperty("RiskCount")]
        public DspmRiskCount RiskCount{ get; set; }

        /// <summary>
        /// 身份类型。非身份账号为null。0-未定义 2-长期身份 3-临时身份
        /// </summary>
        [JsonProperty("IdentifyType")]
        public long? IdentifyType{ get; set; }

        /// <summary>
        /// 所属个人用户信息。
        /// </summary>
        [JsonProperty("Person")]
        public DspmPersonUser Person{ get; set; }

        /// <summary>
        /// 创建者账号uin用户。
        /// </summary>
        [JsonProperty("CreatorUin")]
        public DspmUinUser CreatorUin{ get; set; }

        /// <summary>
        /// 预设权限。
        /// </summary>
        [JsonProperty("PresetPrivilege")]
        public DspmDbAccountPrivilege PresetPrivilege{ get; set; }

        /// <summary>
        /// 内网访问地址，如果有多个，使用';'分割
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 身份id
        /// </summary>
        [JsonProperty("IdentifyId")]
        public string IdentifyId{ get; set; }

        /// <summary>
        /// 资产所属账号app id
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 账号昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 资产所属账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamObj(map, prefix + "OwnerUin.", this.OwnerUin);
            this.SetParamSimple(map, prefix + "IsManager", this.IsManager);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamObj(map, prefix + "Privilege.", this.Privilege);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ValidateFrom", this.ValidateFrom);
            this.SetParamSimple(map, prefix + "ValidateTo", this.ValidateTo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PersonApplyCount", this.PersonApplyCount);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamObj(map, prefix + "RiskCount.", this.RiskCount);
            this.SetParamSimple(map, prefix + "IdentifyType", this.IdentifyType);
            this.SetParamObj(map, prefix + "Person.", this.Person);
            this.SetParamObj(map, prefix + "CreatorUin.", this.CreatorUin);
            this.SetParamObj(map, prefix + "PresetPrivilege.", this.PresetPrivilege);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "IdentifyId", this.IdentifyId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

