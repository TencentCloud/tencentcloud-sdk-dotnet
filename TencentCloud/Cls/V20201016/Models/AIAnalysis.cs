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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIAnalysis : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启告警AI诊断</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>是否显示诊断过程</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("HideProcess")]
        public bool? HideProcess{ get; set; }

        /// <summary>
        /// <p>AI诊断告警时给AI的提示词</p><p>参数格式：请详细诊断根因</p>
        /// </summary>
        [JsonProperty("UserPrompt")]
        public string UserPrompt{ get; set; }

        /// <summary>
        /// <p>AI 分析的数据范围</p>
        /// </summary>
        [JsonProperty("AnalysisDataScope")]
        public AIAnalysisDataScope[] AnalysisDataScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "HideProcess", this.HideProcess);
            this.SetParamSimple(map, prefix + "UserPrompt", this.UserPrompt);
            this.SetParamArrayObj(map, prefix + "AnalysisDataScope.", this.AnalysisDataScope);
        }
    }
}

