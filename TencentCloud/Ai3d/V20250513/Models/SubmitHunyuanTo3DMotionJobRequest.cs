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

namespace TencentCloud.Ai3d.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitHunyuanTo3DMotionJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>输入文本prompt，限定最大字符为128。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>模型名称：HY-Motion-1.0，默认HY-Motion-1.0。</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>需重定向的模型地址，只能支持混元生3D动画生成的模型（动画模板的接口）</p>
        /// </summary>
        [JsonProperty("RetargetFile")]
        public InputFile3D RetargetFile{ get; set; }

        /// <summary>
        /// <p>生成动画的时长，默认5，范围：1-12（单位s）</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>默认true，返回的fbx是否带蒙皮mesh</p>
        /// </summary>
        [JsonProperty("EnableMesh")]
        public bool? EnableMesh{ get; set; }

        /// <summary>
        /// <p>是否开启prompt扩写，开启后将补充完善输入的prompt。<br>默认false。</p>
        /// </summary>
        [JsonProperty("EnableRewrite")]
        public bool? EnableRewrite{ get; set; }

        /// <summary>
        /// <p>是否开启时长自动匹配，开启后将自动根据prompt匹配适合时长的动作数据<br>默认false。</p>
        /// </summary>
        [JsonProperty("EnableDurationEst")]
        public bool? EnableDurationEst{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamObj(map, prefix + "RetargetFile.", this.RetargetFile);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "EnableMesh", this.EnableMesh);
            this.SetParamSimple(map, prefix + "EnableRewrite", this.EnableRewrite);
            this.SetParamSimple(map, prefix + "EnableDurationEst", this.EnableDurationEst);
        }
    }
}

