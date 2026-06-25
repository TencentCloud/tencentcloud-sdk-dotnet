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

    public class SubmitHunyuan3DPartJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需进行组件生成的3D模型文件，仅支持FBX格式。</p>
        /// </summary>
        [JsonProperty("File")]
        public InputFile3D File{ get; set; }

        /// <summary>
        /// <p>组件生成模型版本，默认为1.5</p><p>枚举值：</p><ul><li>1.5： 1.5模型</li></ul><p>默认值：1.5</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>是否分步骤进行组件生成；<br>开启后，输入原始模型后，可生成带分割信息的模型以及分割数据，可对此信息编辑后再传入带有分割信息的模型和分割数据进行编辑后的组件生成；<br>此参数默认关闭。</p>
        /// </summary>
        [JsonProperty("PartSegmentationInfo")]
        public string PartSegmentationInfo{ get; set; }

        /// <summary>
        /// <p>是否开启后处理，开启后将只输出一个模型链接，默认关闭。 （开启此接口后，需额外增加20积分）</p>
        /// </summary>
        [JsonProperty("EnableStagedGeneration")]
        public bool? EnableStagedGeneration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "File.", this.File);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "PartSegmentationInfo", this.PartSegmentationInfo);
            this.SetParamSimple(map, prefix + "EnableStagedGeneration", this.EnableStagedGeneration);
        }
    }
}

