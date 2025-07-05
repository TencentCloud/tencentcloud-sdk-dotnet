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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCCFrequencyRulesResponse : AbstractModel
    {
        
        /// <summary>
        /// 访问频率控制规则列表
        /// </summary>
        [JsonProperty("CCFrequencyRuleList")]
        public CCFrequencyRule[] CCFrequencyRuleList{ get; set; }

        /// <summary>
        /// 访问频率控制规则开关状态，取值[on(开启)，off(关闭)]
        /// </summary>
        [JsonProperty("CCFrequencyRuleStatus")]
        public string CCFrequencyRuleStatus{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CCFrequencyRuleList.", this.CCFrequencyRuleList);
            this.SetParamSimple(map, prefix + "CCFrequencyRuleStatus", this.CCFrequencyRuleStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

