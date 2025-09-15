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

    public class Activity : AbstractModel
    {
        
        /// <summary>
        /// 原子任务类型：
        /// <li>input: 起始节点</li>
        /// <li>output：终止节点</li>
        /// <li>action-trans：转码</li>
        /// <li>action-samplesnapshot：采样截图</li>
        /// <li>action-AIAnalysis: 分析</li>
        /// <li>action-AIRecognition：识别</li>
        /// <li>action-aiReview：审核</li>
        /// <li>action-animated-graphics：转动图</li>
        /// <li>action-image-sprite：雪碧图</li>
        /// <li>action-snapshotByTimeOffset: 时间点截图</li>
        /// <li>action-adaptive-substream：自适应码流</li>
        /// <li>action-AIQualityControl：媒体质检</li>
        /// <li>action-SmartSubtitles：智能字幕</li>
        /// <li>action-exec-rules：判断规则</li>
        /// <li>action-SmartErase：智能擦除</li>
        /// 
        /// 
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// 后驱节点索引数组
        /// </summary>
        [JsonProperty("ReardriveIndex")]
        public long?[] ReardriveIndex{ get; set; }

        /// <summary>
        /// 原子任务参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityPara")]
        public ActivityPara ActivityPara{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamArraySimple(map, prefix + "ReardriveIndex.", this.ReardriveIndex);
            this.SetParamObj(map, prefix + "ActivityPara.", this.ActivityPara);
        }
    }
}

