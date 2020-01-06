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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WatermarkCycleConfigForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 水印在视频里第一次出现的播放时间点，单位：秒。
        /// </summary>
        [JsonProperty("StartTime")]
        public float? StartTime{ get; set; }

        /// <summary>
        /// 在一个水印周期内，水印显示的持续时间，单位：秒。
        /// </summary>
        [JsonProperty("DisplayDuration")]
        public float? DisplayDuration{ get; set; }

        /// <summary>
        /// 一个水印周期的持续时间，单位：秒。
        /// 填 0 表示水印只持续一个水印周期（即在整个视频里只显示 DisplayDuration 秒）。
        /// </summary>
        [JsonProperty("CycleDuration")]
        public float? CycleDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "DisplayDuration", this.DisplayDuration);
            this.SetParamSimple(map, prefix + "CycleDuration", this.CycleDuration);
        }
    }
}

