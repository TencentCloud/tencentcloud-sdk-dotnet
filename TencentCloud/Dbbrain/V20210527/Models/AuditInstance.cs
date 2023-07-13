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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditInstance : AbstractModel
    {
        
        /// <summary>
        /// 审计状态，已开通审计为：YES，未开通审计为：ON。
        /// </summary>
        [JsonProperty("AuditStatus")]
        public string AuditStatus{ get; set; }

        /// <summary>
        /// 审计日志大小，为兼容老版本用。
        /// </summary>
        [JsonProperty("BillingAmount")]
        public long? BillingAmount{ get; set; }

        /// <summary>
        /// 计费确认状态，0-未确认；1-已确认。
        /// </summary>
        [JsonProperty("BillingConfirmed")]
        public long? BillingConfirmed{ get; set; }

        /// <summary>
        /// 低频存储时长。
        /// </summary>
        [JsonProperty("ColdLogExpireDay")]
        public long? ColdLogExpireDay{ get; set; }

        /// <summary>
        /// 低频日志存储量单位MB。
        /// </summary>
        [JsonProperty("ColdLogSize")]
        public long? ColdLogSize{ get; set; }

        /// <summary>
        /// 高频日志存储天数。
        /// </summary>
        [JsonProperty("HotLogExpireDay")]
        public long? HotLogExpireDay{ get; set; }

        /// <summary>
        /// 高频日志存储量，单位MB。
        /// </summary>
        [JsonProperty("HotLogSize")]
        public long? HotLogSize{ get; set; }

        /// <summary>
        /// 实例Id。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 日志保存总天数，为高频存储时长+低频存储时长。
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// 实例创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例详细信息。
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public AuditInstanceInfo InstanceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "BillingAmount", this.BillingAmount);
            this.SetParamSimple(map, prefix + "BillingConfirmed", this.BillingConfirmed);
            this.SetParamSimple(map, prefix + "ColdLogExpireDay", this.ColdLogExpireDay);
            this.SetParamSimple(map, prefix + "ColdLogSize", this.ColdLogSize);
            this.SetParamSimple(map, prefix + "HotLogExpireDay", this.HotLogExpireDay);
            this.SetParamSimple(map, prefix + "HotLogSize", this.HotLogSize);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
        }
    }
}

