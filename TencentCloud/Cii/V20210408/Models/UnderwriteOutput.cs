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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnderwriteOutput : AbstractModel
    {
        
        /// <summary>
        /// 客户ID
        /// </summary>
        [JsonProperty("CustomerId")]
        public string CustomerId{ get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("Results")]
        public InsuranceResult[] Results{ get; set; }

        /// <summary>
        /// 复核时间
        /// </summary>
        [JsonProperty("ReviewTime")]
        public string ReviewTime{ get; set; }

        /// <summary>
        /// 人工复核结果
        /// </summary>
        [JsonProperty("ManualDetail")]
        public UnderwriteConclusion[] ManualDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamSimple(map, prefix + "ReviewTime", this.ReviewTime);
            this.SetParamArrayObj(map, prefix + "ManualDetail.", this.ManualDetail);
        }
    }
}

