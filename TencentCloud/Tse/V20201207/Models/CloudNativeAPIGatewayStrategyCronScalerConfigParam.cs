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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudNativeAPIGatewayStrategyCronScalerConfigParam : AbstractModel
    {
        
        /// <summary>
        /// 定时伸缩周期
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// 定时伸缩开始时间
        /// </summary>
        [JsonProperty("StartAt")]
        public string StartAt{ get; set; }

        /// <summary>
        /// 定时伸缩目标节点数，不超过指标伸缩中定义的最大节点数
        /// </summary>
        [JsonProperty("TargetReplicas")]
        public long? TargetReplicas{ get; set; }

        /// <summary>
        /// 定时伸缩cron表达式，无需输入
        /// </summary>
        [JsonProperty("Crontab")]
        public string Crontab{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartAt", this.StartAt);
            this.SetParamSimple(map, prefix + "TargetReplicas", this.TargetReplicas);
            this.SetParamSimple(map, prefix + "Crontab", this.Crontab);
        }
    }
}

