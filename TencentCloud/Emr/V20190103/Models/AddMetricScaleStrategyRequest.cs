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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddMetricScaleStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 1表示按负载规则扩缩容，2表示按时间规则扩缩容。必须填写，并且和下面的规则策略匹配
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// 按负载扩容的规则。
        /// </summary>
        [JsonProperty("LoadAutoScaleStrategy")]
        public LoadAutoScaleStrategy LoadAutoScaleStrategy{ get; set; }

        /// <summary>
        /// 按时间扩缩容的规则。
        /// </summary>
        [JsonProperty("TimeAutoScaleStrategy")]
        public TimeAutoScaleStrategy TimeAutoScaleStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamObj(map, prefix + "LoadAutoScaleStrategy.", this.LoadAutoScaleStrategy);
            this.SetParamObj(map, prefix + "TimeAutoScaleStrategy.", this.TimeAutoScaleStrategy);
        }
    }
}

