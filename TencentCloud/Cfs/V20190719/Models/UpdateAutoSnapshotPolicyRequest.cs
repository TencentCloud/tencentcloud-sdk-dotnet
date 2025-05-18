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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAutoSnapshotPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 快照策略ID,查询快照策略列表获取
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// 快照策略名称，不超过64个字符
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 快照定期备份，按照星期一到星期日。 1代表星期一，7代表星期日，与DayOfMonth，IntervalDays 三者选一个
        /// </summary>
        [JsonProperty("DayOfWeek")]
        public string DayOfWeek{ get; set; }

        /// <summary>
        /// 快照定期备份在一天的哪一小时
        /// </summary>
        [JsonProperty("Hour")]
        public string Hour{ get; set; }

        /// <summary>
        /// 快照保留天数
        /// </summary>
        [JsonProperty("AliveDays")]
        public ulong? AliveDays{ get; set; }

        /// <summary>
        /// 是否激活定期快照功能；1代表激活，0代表未激活
        /// </summary>
        [JsonProperty("IsActivated")]
        public ulong? IsActivated{ get; set; }

        /// <summary>
        /// 定期快照在每月的第几天创建快照，该参数与DayOfWeek,IntervalDays 三者选一
        /// </summary>
        [JsonProperty("DayOfMonth")]
        public string DayOfMonth{ get; set; }

        /// <summary>
        /// 间隔天数定期执行快照，该参数与DayOfWeek,DayOfMonth 三者选一
        /// </summary>
        [JsonProperty("IntervalDays")]
        public ulong? IntervalDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "DayOfWeek", this.DayOfWeek);
            this.SetParamSimple(map, prefix + "Hour", this.Hour);
            this.SetParamSimple(map, prefix + "AliveDays", this.AliveDays);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "DayOfMonth", this.DayOfMonth);
            this.SetParamSimple(map, prefix + "IntervalDays", this.IntervalDays);
        }
    }
}

