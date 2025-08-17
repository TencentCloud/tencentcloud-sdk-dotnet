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

    public class MPSTemplate : AbstractModel
    {
        
        /// <summary>
        /// MPS 模板的类型。取值：
        /// <li>Transcode: 转码模板。</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// MPS 任务模板详情内容。
        /// 示例：{"Definition":24214,"Name":"test","Comment":"","Type":"Preset","EnhanceConfig":{"VideoEnhance":{"FrameRate":{"Switch":"ON","Fps":50},"SuperResolution":{"Switch":"ON","Type":"lq"}}}}
        /// </summary>
        [JsonProperty("MPSTemplateInfo")]
        public string MPSTemplateInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "MPSTemplateInfo", this.MPSTemplateInfo);
        }
    }
}

