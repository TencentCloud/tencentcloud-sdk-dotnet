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

    public class ActivityResult : AbstractModel
    {
        
        /// <summary>
        /// 原子任务类型。
        /// <li>Transcode：转码。</li>
        /// <li>SampleSnapshot：采样截图。</li>
        /// <li>AnimatedGraphics：转动图。</li>
        /// <li>SnapshotByTimeOffset：时间点截图。</li>
        /// <li>ImageSprites：雪碧图。</li>
        /// <li>AdaptiveDynamicStreaming：自适应码流。</li>
        /// <li>AiContentReview：内容审核。</li>
        /// <li>AIRecognition：智能识别。</li>
        /// <li>AIAnalysis：智能分析。</li>
        /// </summary>
        [JsonProperty("ActivityType")]
        public string ActivityType{ get; set; }

        /// <summary>
        /// 原子任务输出。
        /// </summary>
        [JsonProperty("ActivityResItem")]
        public ActivityResItem ActivityResItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityType", this.ActivityType);
            this.SetParamObj(map, prefix + "ActivityResItem.", this.ActivityResItem);
        }
    }
}

