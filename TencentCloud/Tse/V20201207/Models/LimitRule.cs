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

    public class LimitRule : AbstractModel
    {
        
        /// <summary>
        /// 请求匹配条件
        /// </summary>
        [JsonProperty("Filters")]
        public RuleFilter[] Filters{ get; set; }

        /// <summary>
        /// 参数限流依据组合
        /// </summary>
        [JsonProperty("LimitBy")]
        public KeyValue[] LimitBy{ get; set; }

        /// <summary>
        /// 限流阈值
        /// </summary>
        [JsonProperty("QpsThresholds")]
        public QpsThreshold[] QpsThresholds{ get; set; }

        /// <summary>
        /// 精确限流阈值
        /// </summary>
        [JsonProperty("AccurateQpsThresholds")]
        public AccurateQpsThreshold[] AccurateQpsThresholds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "LimitBy.", this.LimitBy);
            this.SetParamArrayObj(map, prefix + "QpsThresholds.", this.QpsThresholds);
            this.SetParamArrayObj(map, prefix + "AccurateQpsThresholds.", this.AccurateQpsThresholds);
        }
    }
}

