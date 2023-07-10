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

namespace TencentCloud.Soe.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Tone : AbstractModel
    {
        
        /// <summary>
        /// 检测结果是否有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Valid")]
        public bool? Valid{ get; set; }

        /// <summary>
        /// 文本标准声调，数值范围[-1,1,2,3,4]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RefTone")]
        public long? RefTone{ get; set; }

        /// <summary>
        /// 实际发音声调，数值范围[-1,1,2,3,4]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HypothesisTone")]
        public long? HypothesisTone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Valid", this.Valid);
            this.SetParamSimple(map, prefix + "RefTone", this.RefTone);
            this.SetParamSimple(map, prefix + "HypothesisTone", this.HypothesisTone);
        }
    }
}

