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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeCompHighlightConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否禁用视频浓缩
        /// </summary>
        [JsonProperty("DisableHighlight")]
        public bool? DisableHighlight{ get; set; }

        /// <summary>
        /// 包含在浓缩结果中的目标类别。可选值：
        /// 
        /// - `person`：人
        /// - `pet`：宠物
        /// - `vehicle`：车辆
        /// </summary>
        [JsonProperty("DetectTypes")]
        public string[] DetectTypes{ get; set; }

        /// <summary>
        /// 指定是否返回浓缩视频的摘要文本
        /// </summary>
        [JsonProperty("EnableSummary")]
        public bool? EnableSummary{ get; set; }

        /// <summary>
        /// 指定返回的关键帧图像数量
        /// </summary>
        [JsonProperty("KeyFramesNum")]
        public long? KeyFramesNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisableHighlight", this.DisableHighlight);
            this.SetParamArraySimple(map, prefix + "DetectTypes.", this.DetectTypes);
            this.SetParamSimple(map, prefix + "EnableSummary", this.EnableSummary);
            this.SetParamSimple(map, prefix + "KeyFramesNum", this.KeyFramesNum);
        }
    }
}

