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
        /// <p>命中的模板类型，其中Common-公共库；Auto-自动聚类库；Owner-自建模板库</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HitGroup")]
        public string HitGroup{ get; set; }

        /// <summary>
        /// <p>请求图像与命中攻击模板的相似度，相似度取值范围[0,2]，取值越小表示命中攻击模板的概率越高。默认阈值为0.6，当SimilarityScore≥0.6时判断为正常，SimilarityScore&lt;0.6是判断为攻击。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SimilarityScore")]
        public float? SimilarityScore{ get; set; }

        /// <summary>
        /// <p>命中的模板id</p>
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

