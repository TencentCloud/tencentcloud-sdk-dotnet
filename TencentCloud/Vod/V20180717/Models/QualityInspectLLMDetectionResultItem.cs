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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityInspectLLMDetectionResultItem : AbstractModel
    {
        
        /// <summary>
        /// <p>检测分类。</p><p>枚举值：</p><ul><li>AIGCQualityCharacteristics： AIGC 质量特征。</li></ul>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>检测分组。</p><p>枚举值：</p><ul><li>AIGCAuthenticity： AIGC 真实性，包括人体合理性、物理合理性、跨帧一致性等。</li><li>AIGCTechQuality： AIGC 技术质量，包括画幅、黑边、强行竖屏等。</li></ul>
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// <p>检测类型名称。</p><p>枚举值：</p><ul><li>BodyPoseCheck： 人体姿态合理性，属于 AIGCAuthenticity。</li><li>BodyDetailCheck： 人体细节合理性，包括手指数、五官对称等，属于 AIGCAuthenticity。</li><li>PhysicRulesCheck： 物理规律合理性，包括透视、光影、重力等，属于 AIGCAuthenticity。</li><li>ObjectConsistencyCheck： 跨帧物体一致性，属于 AIGCAuthenticity。</li><li>FormatCheck： 画幅、黑边、强行竖屏等格式问题，属于 AIGCTechQuality。</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>整体质量得分，范围 [0, 100]，越高表示越好。</p>
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// <p>判断置信度，范围 [0, 100]，越高表示越确定。</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// <p>检测发现的问题列表，无问题时为空。</p>
        /// </summary>
        [JsonProperty("IssueSet")]
        public QualityInspectLLMDetectionIssue[] IssueSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArrayObj(map, prefix + "IssueSet.", this.IssueSet);
        }
    }
}

