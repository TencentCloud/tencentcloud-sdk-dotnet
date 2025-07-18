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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KnowledgeCapacityPieGraphDetail : AbstractModel
    {
        
        /// <summary>
        /// 当前应用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 当前应用使用的字符数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedCharSize")]
        public string UsedCharSize{ get; set; }

        /// <summary>
        /// 当前应用对于总用量的占比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Proportion")]
        public float? Proportion{ get; set; }

        /// <summary>
        /// 知识库类型:0默认1共享
        /// </summary>
        [JsonProperty("KnowledgeType")]
        public long? KnowledgeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "UsedCharSize", this.UsedCharSize);
            this.SetParamSimple(map, prefix + "Proportion", this.Proportion);
            this.SetParamSimple(map, prefix + "KnowledgeType", this.KnowledgeType);
        }
    }
}

