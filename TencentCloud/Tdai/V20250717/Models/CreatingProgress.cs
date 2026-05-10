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

namespace TencentCloud.Tdai.V20250717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatingProgress : AbstractModel
    {
        
        /// <summary>
        /// <p>总步骤数</p>
        /// </summary>
        [JsonProperty("TotalSteps")]
        public long? TotalSteps{ get; set; }

        /// <summary>
        /// <p>当前步骤</p>
        /// </summary>
        [JsonProperty("CurrentStep")]
        public long? CurrentStep{ get; set; }

        /// <summary>
        /// <p>步骤详情</p>
        /// </summary>
        [JsonProperty("Steps")]
        public CreatingStepInfo[] Steps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalSteps", this.TotalSteps);
            this.SetParamSimple(map, prefix + "CurrentStep", this.CurrentStep);
            this.SetParamArrayObj(map, prefix + "Steps.", this.Steps);
        }
    }
}

