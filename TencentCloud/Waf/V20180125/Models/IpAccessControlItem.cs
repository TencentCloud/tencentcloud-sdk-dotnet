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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpAccessControlItem : AbstractModel
    {
        
        /// <summary>
        /// mongo表自增Id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 动作
        /// </summary>
        [JsonProperty("ActionType")]
        public ulong? ActionType{ get; set; }

        /// <summary>
        /// ip
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [JsonProperty("TsVersion")]
        public ulong? TsVersion{ get; set; }

        /// <summary>
        /// 有效截止时间戳
        /// </summary>
        [JsonProperty("ValidTs")]
        public ulong? ValidTs{ get; set; }

        /// <summary>
        /// 生效状态
        /// </summary>
        [JsonProperty("ValidStatus")]
        public long? ValidStatus{ get; set; }

        /// <summary>
        /// 55000001
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// IP列表
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// 规则创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 定时任务类型
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// 周期任务类型
        /// </summary>
        [JsonProperty("CronType")]
        public string CronType{ get; set; }

        /// <summary>
        /// 定时任务配置详情
        /// </summary>
        [JsonProperty("JobDateTime")]
        public JobDateTime JobDateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "TsVersion", this.TsVersion);
            this.SetParamSimple(map, prefix + "ValidTs", this.ValidTs);
            this.SetParamSimple(map, prefix + "ValidStatus", this.ValidStatus);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamSimple(map, prefix + "CronType", this.CronType);
            this.SetParamObj(map, prefix + "JobDateTime.", this.JobDateTime);
        }
    }
}

