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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceDbAuditStatus : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 审计状态。ON-表示审计已开启，OFF-表示审计关闭
        /// </summary>
        [JsonProperty("AuditStatus")]
        public string AuditStatus{ get; set; }

        /// <summary>
        /// 任务状态。0-无任务；1-审计开启中，2-审计关闭中。
        /// </summary>
        [JsonProperty("AuditTask")]
        public ulong? AuditTask{ get; set; }

        /// <summary>
        /// 日志保留时长。支持值包括：
        /// 7 - 一周；
        /// 30 - 一个月；
        /// 90 - 三个月；
        /// 180 - 六个月；
        /// 365 - 一年；
        /// 1095 - 三年；
        /// 1825 - 五年。
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// 高频存储时长。支持值包括：
        /// 3 - 3天；
        /// 7 - 一周；
        /// 30 - 一个月；
        /// 90 - 三个月；
        /// 180 - 六个月；
        /// 365 - 一年；
        /// 1095 - 三年；
        /// 1825 - 五年。
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public ulong? HighLogExpireDay{ get; set; }

        /// <summary>
        /// 低频存储时长。单位：天，等于日志保存时长减去高频存储时长。
        /// </summary>
        [JsonProperty("LowLogExpireDay")]
        public ulong? LowLogExpireDay{ get; set; }

        /// <summary>
        /// 日志存储量(单位：GB)。
        /// </summary>
        [JsonProperty("BillingAmount")]
        public float? BillingAmount{ get; set; }

        /// <summary>
        /// 高频存储量(单位：GB)。
        /// </summary>
        [JsonProperty("HighRealStorage")]
        public float? HighRealStorage{ get; set; }

        /// <summary>
        /// 低频存储量(单位：GB)。
        /// </summary>
        [JsonProperty("LowRealStorage")]
        public float? LowRealStorage{ get; set; }

        /// <summary>
        /// 是否为全审计。true-表示全审计。
        /// </summary>
        [JsonProperty("AuditAll")]
        public bool? AuditAll{ get; set; }

        /// <summary>
        /// 审计开通时间。
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// 实例相关信息
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public AuditInstanceInfo InstanceInfo{ get; set; }

        /// <summary>
        /// 总存储量(单位：GB)。
        /// </summary>
        [JsonProperty("RealStorage")]
        public float? RealStorage{ get; set; }

        /// <summary>
        /// 是否包含审计策略
        /// </summary>
        [JsonProperty("OldRule")]
        public bool? OldRule{ get; set; }

        /// <summary>
        /// 实例所应用的规则模板。
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "AuditTask", this.AuditTask);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamSimple(map, prefix + "LowLogExpireDay", this.LowLogExpireDay);
            this.SetParamSimple(map, prefix + "BillingAmount", this.BillingAmount);
            this.SetParamSimple(map, prefix + "HighRealStorage", this.HighRealStorage);
            this.SetParamSimple(map, prefix + "LowRealStorage", this.LowRealStorage);
            this.SetParamSimple(map, prefix + "AuditAll", this.AuditAll);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
            this.SetParamSimple(map, prefix + "RealStorage", this.RealStorage);
            this.SetParamSimple(map, prefix + "OldRule", this.OldRule);
            this.SetParamArraySimple(map, prefix + "RuleTemplateIds.", this.RuleTemplateIds);
        }
    }
}

