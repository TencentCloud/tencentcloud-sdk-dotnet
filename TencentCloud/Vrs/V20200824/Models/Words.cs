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

namespace TencentCloud.Vrs.V20200824.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Words : AbstractModel
    {
        
        /// <summary>
        /// 准确度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PronAccuracy")]
        public float? PronAccuracy{ get; set; }

        /// <summary>
        /// 流畅度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PronFluency")]
        public float? PronFluency{ get; set; }

        /// <summary>
        /// tag: 0: match, 1: insert, 2: delete, 3: replace, 4: oov, 5: unknown
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public long? Tag{ get; set; }

        /// <summary>
        /// 字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PronAccuracy", this.PronAccuracy);
            this.SetParamSimple(map, prefix + "PronFluency", this.PronFluency);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Word", this.Word);
        }
    }
}

