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

namespace TencentCloud.Ft.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GradientInfo : AbstractModel
    {
        
        /// <summary>
        /// 图片的展示时长，即单张图片静止不变的时间。GIF默认每张图片0.7s，视频默认每张图片2s
        /// </summary>
        [JsonProperty("Tempo")]
        public float? Tempo{ get; set; }

        /// <summary>
        /// 人像渐变的最长时间，即单张图片使用渐变特效的时间。 GIF默认值为0.5s，视频默值认为1s
        /// </summary>
        [JsonProperty("MorphTime")]
        public float? MorphTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tempo", this.Tempo);
            this.SetParamSimple(map, prefix + "MorphTime", this.MorphTime);
        }
    }
}

