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

    public class RetrievalLivenessExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// 命中的模版类型，其中Common-公共库；Auto-自动聚类库；Owner-自建模版库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HitGroup")]
        public string HitGroup{ get; set; }

        /// <summary>
        /// 命中的相似度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SimilarityScore")]
        public float? SimilarityScore{ get; set; }

        /// <summary>
        /// 命中的模板id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HitTemplate")]
        public string HitTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HitGroup", this.HitGroup);
            this.SetParamSimple(map, prefix + "SimilarityScore", this.SimilarityScore);
            this.SetParamSimple(map, prefix + "HitTemplate", this.HitTemplate);
        }
    }
}

