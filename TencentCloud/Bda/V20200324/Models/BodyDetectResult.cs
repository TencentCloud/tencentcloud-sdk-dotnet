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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BodyDetectResult : AbstractModel
    {
        
        /// <summary>
        /// 检测出的人体置信度。 
        /// 误识率百分之十对应的阈值是0.14；误识率百分之五对应的阈值是0.32；误识率百分之二对应的阈值是0.62；误识率百分之一对应的阈值是0.81。 
        /// 通常情况建议使用阈值0.32，可适用大多数情况。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 图中检测出来的人体框
        /// </summary>
        [JsonProperty("BodyRect")]
        public BodyRect BodyRect{ get; set; }

        /// <summary>
        /// 图中检测出的人体属性信息。
        /// </summary>
        [JsonProperty("BodyAttributeInfo")]
        public BodyAttributeInfo BodyAttributeInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamObj(map, prefix + "BodyRect.", this.BodyRect);
            this.SetParamObj(map, prefix + "BodyAttributeInfo.", this.BodyAttributeInfo);
        }
    }
}

