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

    public class DspmAssetAccessTopologyItem : AbstractModel
    {
        
        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 资产名
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 资产账号
        /// </summary>
        [JsonProperty("AssetAccount")]
        public string AssetAccount{ get; set; }

        /// <summary>
        /// 主机地址
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [JsonProperty("AccountType")]
        public long? AccountType{ get; set; }

        /// <summary>
        /// 资产地址
        /// </summary>
        [JsonProperty("AssetIp")]
        public string AssetIp{ get; set; }

        /// <summary>
        /// 访问来源ip地址
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// 访问来源ip类型
        /// </summary>
        [JsonProperty("SourceIpType")]
        public string SourceIpType{ get; set; }

        /// <summary>
        /// 访问频率。次/天
        /// </summary>
        [JsonProperty("AccessFrequency")]
        public DspmFrequency AccessFrequency{ get; set; }

        /// <summary>
        /// 执行SQL频率。条/小时。
        /// </summary>
        [JsonProperty("ExecSQLFrequency")]
        public DspmFrequency ExecSQLFrequency{ get; set; }

        /// <summary>
        /// 访问起始时间
        /// </summary>
        [JsonProperty("AccessBeginTime")]
        public string AccessBeginTime{ get; set; }

        /// <summary>
        /// 访问结束时间
        /// </summary>
        [JsonProperty("AccessEndTime")]
        public string AccessEndTime{ get; set; }

        /// <summary>
        /// 账号风险数
        /// </summary>
        [JsonProperty("AccountRisk")]
        public long? AccountRisk{ get; set; }

        /// <summary>
        /// 资产风险数
        /// </summary>
        [JsonProperty("AssetRisk")]
        public long? AssetRisk{ get; set; }

        /// <summary>
        /// 所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

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
        /// 账号告警数
        /// </summary>
        [JsonProperty("AccountAlarm")]
        public long? AccountAlarm{ get; set; }

        /// <summary>
        /// 资产告警数
        /// </summary>
        [JsonProperty("AssetAlarm")]
        public long? AssetAlarm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetAccount", this.AssetAccount);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "AssetIp", this.AssetIp);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "SourceIpType", this.SourceIpType);
            this.SetParamObj(map, prefix + "AccessFrequency.", this.AccessFrequency);
            this.SetParamObj(map, prefix + "ExecSQLFrequency.", this.ExecSQLFrequency);
            this.SetParamSimple(map, prefix + "AccessBeginTime", this.AccessBeginTime);
            this.SetParamSimple(map, prefix + "AccessEndTime", this.AccessEndTime);
            this.SetParamSimple(map, prefix + "AccountRisk", this.AccountRisk);
            this.SetParamSimple(map, prefix + "AssetRisk", this.AssetRisk);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IdentifyType", this.IdentifyType);
            this.SetParamObj(map, prefix + "OwnerUin.", this.OwnerUin);
            this.SetParamObj(map, prefix + "Person.", this.Person);
            this.SetParamSimple(map, prefix + "AccountAlarm", this.AccountAlarm);
            this.SetParamSimple(map, prefix + "AssetAlarm", this.AssetAlarm);
        }
    }
}

