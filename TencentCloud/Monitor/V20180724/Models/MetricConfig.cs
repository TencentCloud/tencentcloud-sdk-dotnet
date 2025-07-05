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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricConfig : AbstractModel
    {
        
        /// <summary>
        /// 允许使用的运算符
        /// </summary>
        [JsonProperty("Operator")]
        public string[] Operator{ get; set; }

        /// <summary>
        /// 允许配置的数据周期，以秒为单位
        /// </summary>
        [JsonProperty("Period")]
        public long?[] Period{ get; set; }

        /// <summary>
        /// 允许配置的持续周期个数
        /// </summary>
        [JsonProperty("ContinuePeriod")]
        public long?[] ContinuePeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "Period.", this.Period);
            this.SetParamArraySimple(map, prefix + "ContinuePeriod.", this.ContinuePeriod);
        }
    }
}

