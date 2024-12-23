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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspaInstance : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例ID。
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// DSPA实例名称。
        /// </summary>
        [JsonProperty("DspaName")]
        public string DspaName{ get; set; }

        /// <summary>
        /// DSPA实例描述信息。
        /// </summary>
        [JsonProperty("DspaDescription")]
        public string DspaDescription{ get; set; }

        /// <summary>
        /// DSPA实例已授权的数据库实例数量。
        /// </summary>
        [JsonProperty("DBAuthCount")]
        public ulong? DBAuthCount{ get; set; }

        /// <summary>
        /// DSPA实例已绑定的cos桶数量。
        /// </summary>
        [JsonProperty("CosBindCount")]
        public ulong? CosBindCount{ get; set; }

        /// <summary>
        /// DSPA实例版本。
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }

        /// <summary>
        /// DSPA实例状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 实例过期时间戳。
        /// </summary>
        [JsonProperty("ExpiredAt")]
        public ulong? ExpiredAt{ get; set; }

        /// <summary>
        /// 账户APPID。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 体验版本信息。
        /// </summary>
        [JsonProperty("TrialVersion")]
        public string TrialVersion{ get; set; }

        /// <summary>
        /// 体验版本过期时间戳。
        /// </summary>
        [JsonProperty("TrialEndAt")]
        public ulong? TrialEndAt{ get; set; }

        /// <summary>
        /// DB已购配额。
        /// </summary>
        [JsonProperty("DbTotalQuota")]
        public long? DbTotalQuota{ get; set; }

        /// <summary>
        /// COS已购配额。
        /// </summary>
        [JsonProperty("CosTotalQuota")]
        public long? CosTotalQuota{ get; set; }

        /// <summary>
        /// COS配额单位，例如:TB。
        /// </summary>
        [JsonProperty("CosQuotaUnit")]
        public string CosQuotaUnit{ get; set; }

        /// <summary>
        /// 0: 默认状态(用户未设置)
        /// 1: 开启自动续费
        /// 2: 明确不自动续费
        /// </summary>
        [JsonProperty("RenewFlag")]
        public ulong? RenewFlag{ get; set; }

        /// <summary>
        /// 实例渠道
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 已授权的实例数量
        /// </summary>
        [JsonProperty("InsAuthCount")]
        public long? InsAuthCount{ get; set; }

        /// <summary>
        /// 已购买的实例数量
        /// </summary>
        [JsonProperty("InsTotalQuota")]
        public long? InsTotalQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "DspaName", this.DspaName);
            this.SetParamSimple(map, prefix + "DspaDescription", this.DspaDescription);
            this.SetParamSimple(map, prefix + "DBAuthCount", this.DBAuthCount);
            this.SetParamSimple(map, prefix + "CosBindCount", this.CosBindCount);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ExpiredAt", this.ExpiredAt);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TrialVersion", this.TrialVersion);
            this.SetParamSimple(map, prefix + "TrialEndAt", this.TrialEndAt);
            this.SetParamSimple(map, prefix + "DbTotalQuota", this.DbTotalQuota);
            this.SetParamSimple(map, prefix + "CosTotalQuota", this.CosTotalQuota);
            this.SetParamSimple(map, prefix + "CosQuotaUnit", this.CosQuotaUnit);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "InsAuthCount", this.InsAuthCount);
            this.SetParamSimple(map, prefix + "InsTotalQuota", this.InsTotalQuota);
        }
    }
}

