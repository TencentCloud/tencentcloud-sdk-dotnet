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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskIdentificationFeedbackInfo : AbstractModel
    {
        
        /// <summary>
        /// 审查结果ID
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// 反馈结果
        /// 
        /// - 1: 其他错误
        /// - 2: 审查错误
        /// - 3: 审查正确
        /// </summary>
        [JsonProperty("FeedbackResult")]
        public long? FeedbackResult{ get; set; }

        /// <summary>
        /// 反馈原因
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "FeedbackResult", this.FeedbackResult);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

