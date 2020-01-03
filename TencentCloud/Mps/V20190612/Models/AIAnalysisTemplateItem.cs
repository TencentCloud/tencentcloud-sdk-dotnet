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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIAnalysisTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// 智能分析模板唯一标识。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 智能分析模板名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 智能分析模板描述信息。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 智能分类任务控制参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassificationConfigure")]
        public ClassificationConfigureInfo ClassificationConfigure{ get; set; }

        /// <summary>
        /// 智能标签任务控制参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagConfigure")]
        public TagConfigureInfo TagConfigure{ get; set; }

        /// <summary>
        /// 智能封面任务控制参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoverConfigure")]
        public CoverConfigureInfo CoverConfigure{ get; set; }

        /// <summary>
        /// 智能按帧标签任务控制参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameTagConfigure")]
        public FrameTagConfigureInfo FrameTagConfigure{ get; set; }

        /// <summary>
        /// 模板创建时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 模板最后修改时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "ClassificationConfigure.", this.ClassificationConfigure);
            this.SetParamObj(map, prefix + "TagConfigure.", this.TagConfigure);
            this.SetParamObj(map, prefix + "CoverConfigure.", this.CoverConfigure);
            this.SetParamObj(map, prefix + "FrameTagConfigure.", this.FrameTagConfigure);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

