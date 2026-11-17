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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtraRiskResult : AbstractModel
    {
        
        /// <summary>
        /// <p>本次附加检查的完成度，回答“这次结果可否采信”。</p><p>枚举值：</p><ul><li>Completed： 本次请求所需的检查均已给出结论（命中或通过）</li><li>Partial： 至少一项检查未能给出结论：依赖不可用、数据不足、入参不完整或非法。结果仅供参考，不代表安全</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>附加风险等级，可能为空字符串</p><p>枚举值：</p><ul><li>High： 存在已生效的风险命中项（此时 RiskDetailList 非空）</li><li>Low： 检查已完成，且确认无命中</li><li>&quot;&quot;（空字符串）    ： 未识别：本次没有任何一项检查能给出结论，或检查未全部完成。既不代表有风险，也不代表安全</li></ul>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>命中的风险项列表，未命中时为空数组 []</p>
        /// </summary>
        [JsonProperty("BlackListResult")]
        public BlackListItem[] BlackListResult{ get; set; }

        /// <summary>
        /// <p>人脸黑名单命中明细，未命中时为空数组 []</p>
        /// </summary>
        [JsonProperty("RiskDetailList")]
        public RiskDetailItem[] RiskDetailList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArrayObj(map, prefix + "BlackListResult.", this.BlackListResult);
            this.SetParamArrayObj(map, prefix + "RiskDetailList.", this.RiskDetailList);
        }
    }
}

