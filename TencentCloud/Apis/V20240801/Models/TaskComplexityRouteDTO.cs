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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskComplexityRouteDTO : AbstractModel
    {
        
        /// <summary>
        /// <p>倾向度</p><p>取值范围：[0, 1]</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComplexityBias")]
        public float? ComplexityBias{ get; set; }

        /// <summary>
        /// <p>简单模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SimpleTargetModels")]
        public TargetModelDTO[] SimpleTargetModels{ get; set; }

        /// <summary>
        /// <p>复杂模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComplexTargetModels")]
        public TargetModelDTO[] ComplexTargetModels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComplexityBias", this.ComplexityBias);
            this.SetParamArrayObj(map, prefix + "SimpleTargetModels.", this.SimpleTargetModels);
            this.SetParamArrayObj(map, prefix + "ComplexTargetModels.", this.ComplexTargetModels);
        }
    }
}

