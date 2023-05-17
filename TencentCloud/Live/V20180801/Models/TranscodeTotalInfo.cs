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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TranscodeTotalInfo : AbstractModel
    {
        
        /// <summary>
        /// 时间点，
        /// 使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 转码时长，单位：分钟。
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 编码方式，带模块，
        /// 示例：
        /// liveprocessor_H264 =》直播转码-H264，
        /// liveprocessor_H265 =》 直播转码-H265，
        /// topspeed_H264 =》极速高清-H264，
        /// topspeed_H265 =》极速高清-H265。
        /// </summary>
        [JsonProperty("ModuleCodec")]
        public string ModuleCodec{ get; set; }

        /// <summary>
        /// 分辨率，
        /// 示例：540*480。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ModuleCodec", this.ModuleCodec);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
        }
    }
}

