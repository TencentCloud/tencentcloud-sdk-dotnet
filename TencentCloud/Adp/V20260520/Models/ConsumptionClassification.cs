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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsumptionClassification : AbstractModel
    {
        
        /// <summary>
        /// <p>消耗场景（如推理/训练/评测等）</p>
        /// </summary>
        [JsonProperty("ConsumptionScene")]
        public string ConsumptionScene{ get; set; }

        /// <summary>
        /// <p>消耗目标（如具体模型名/插件名/平台功能名）</p>
        /// </summary>
        [JsonProperty("ConsumptionTarget")]
        public string ConsumptionTarget{ get; set; }

        /// <summary>
        /// <p>消耗类型，取值集合由业务方定义（如 model/plugin/platform 等）</p>
        /// </summary>
        [JsonProperty("ConsumptionType")]
        public string ConsumptionType{ get; set; }

        /// <summary>
        /// <p>套餐包名称</p>
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumptionScene", this.ConsumptionScene);
            this.SetParamSimple(map, prefix + "ConsumptionTarget", this.ConsumptionTarget);
            this.SetParamSimple(map, prefix + "ConsumptionType", this.ConsumptionType);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
        }
    }
}

