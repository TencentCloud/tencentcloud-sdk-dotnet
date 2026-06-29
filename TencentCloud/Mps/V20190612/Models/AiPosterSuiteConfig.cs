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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiPosterSuiteConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>出图模式</p><p>枚举值：</p><ul><li>auto： 全自动模式。此模式下支持CustomVariables传入。</li><li>modify： 修改模式。此模式下需要在AddOnParameter.ExtPrompt字段提供对应描述。此模式下禁止CustomVariables传入。</li></ul><p>默认值：auto</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>电商平台视觉模板id</p><p>如需个性化定制视觉模板，请提交工单。</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>子图配置。</p>
        /// </summary>
        [JsonProperty("Recipe")]
        public RecipeItem[] Recipe{ get; set; }

        /// <summary>
        /// <p>子图文案语言。</p><p>枚举值：</p><ul><li>zh-CN： 简体中文</li><li>en-US： 美式英语</li></ul><p>默认值：zh-CN</p><p>如需支持更多语言输出，请提交工单。</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>子图比例。</p><p>枚举值：</p><ul><li>1:1： 1:1</li><li>3:4： 3:4</li><li>4:3： 4:3</li><li>9:16： 9:16</li><li>16:9： 16:9</li></ul><p>默认值：1:1</p>
        /// </summary>
        [JsonProperty("PanelRatio")]
        public string PanelRatio{ get; set; }

        /// <summary>
        /// <p>子图分辨率</p><p>枚举值：</p><ul><li>720： 720</li><li>1K： 1K</li><li>2K： 2K</li><li>4K： 4K</li></ul><p>默认值：1K</p>
        /// </summary>
        [JsonProperty("PanelResolution")]
        public string PanelResolution{ get; set; }

        /// <summary>
        /// <p>用户自定义变量。</p>
        /// </summary>
        [JsonProperty("CustomVariables")]
        public CustomVariable[] CustomVariables{ get; set; }

        /// <summary>
        /// <p>模型名称。</p><p>枚举值：</p><ul><li>WAND-suite-1.0-flash： WAND-suite-1.0-flash</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArrayObj(map, prefix + "Recipe.", this.Recipe);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "PanelRatio", this.PanelRatio);
            this.SetParamSimple(map, prefix + "PanelResolution", this.PanelResolution);
            this.SetParamArrayObj(map, prefix + "CustomVariables.", this.CustomVariables);
            this.SetParamSimple(map, prefix + "Model", this.Model);
        }
    }
}

