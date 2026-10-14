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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VLTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>模板ID</p>
        /// </summary>
        [JsonProperty("VLTemplateId")]
        public string VLTemplateId{ get; set; }

        /// <summary>
        /// <p>AI 模型</p><p>枚举值：</p><ul><li>IVC-G： 视图默认大模型</li></ul>
        /// </summary>
        [JsonProperty("AIModel")]
        public string AIModel{ get; set; }

        /// <summary>
        /// <p>AI场景名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>AI场景描述</p>
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// <p>提示词</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>分析模式</p><p>枚举值：</p><ul><li>image： 图片模式</li><li>video： 视频模式</li></ul>
        /// </summary>
        [JsonProperty("AnalysisMode")]
        public string AnalysisMode{ get; set; }

        /// <summary>
        /// <p>图片场景配置</p>
        /// </summary>
        [JsonProperty("ImageConfig")]
        public ImageSceneInfo ImageConfig{ get; set; }

        /// <summary>
        /// <p>生效时段列表</p>
        /// </summary>
        [JsonProperty("Times")]
        public EffectiveTime[] Times{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>最近一次更新时间</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// <p>是否关联到视觉理解计划</p>
        /// </summary>
        [JsonProperty("IsUsed")]
        public bool? IsUsed{ get; set; }

        /// <summary>
        /// <p>视频场景配置</p>
        /// </summary>
        [JsonProperty("VideoConfig")]
        public VideoSceneInfo VideoConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VLTemplateId", this.VLTemplateId);
            this.SetParamSimple(map, prefix + "AIModel", this.AIModel);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "AnalysisMode", this.AnalysisMode);
            this.SetParamObj(map, prefix + "ImageConfig.", this.ImageConfig);
            this.SetParamArrayObj(map, prefix + "Times.", this.Times);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "IsUsed", this.IsUsed);
            this.SetParamObj(map, prefix + "VideoConfig.", this.VideoConfig);
        }
    }
}

