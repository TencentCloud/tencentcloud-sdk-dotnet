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

    public class ToolAdvanceConfig : AbstractModel
    {
        
        /// <summary>
        /// 工具调用结果是否直接返回给用户
        /// </summary>
        [JsonProperty("EnableDirectResultReturn")]
        public bool? EnableDirectResultReturn{ get; set; }

        /// <summary>
        /// 输出样式 1-文本 2-json 3-widget
        /// </summary>
        [JsonProperty("OutputType")]
        public long? OutputType{ get; set; }

        /// <summary>
        /// 原始结构化JSON输出
        /// </summary>
        [JsonProperty("RawStructuredOutput")]
        public string RawStructuredOutput{ get; set; }

        /// <summary>
        /// 自定义文本输出，多行展示
        /// </summary>
        [JsonProperty("CustomTextOutputs")]
        public string CustomTextOutputs{ get; set; }

        /// <summary>
        /// Widget输出配置
        /// </summary>
        [JsonProperty("OutputWidgetConfig")]
        public OutputWidgetConfig OutputWidgetConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableDirectResultReturn", this.EnableDirectResultReturn);
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamSimple(map, prefix + "RawStructuredOutput", this.RawStructuredOutput);
            this.SetParamSimple(map, prefix + "CustomTextOutputs", this.CustomTextOutputs);
            this.SetParamObj(map, prefix + "OutputWidgetConfig.", this.OutputWidgetConfig);
        }
    }
}

