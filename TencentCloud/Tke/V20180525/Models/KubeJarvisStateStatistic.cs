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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KubeJarvisStateStatistic : AbstractModel
    {
        
        /// <summary>
        /// 诊断结果的健康水平，健康水平取值：
        /// serious：高风险
        /// risk：中风险
        /// warn：低风险
        /// good：健康
        /// failed：诊断流程异常
        /// </summary>
        [JsonProperty("HealthyLevel")]
        public string HealthyLevel{ get; set; }

        /// <summary>
        /// 诊断结果的统计
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthyLevel", this.HealthyLevel);
            this.SetParamSimple(map, prefix + "Count", this.Count);
        }
    }
}

