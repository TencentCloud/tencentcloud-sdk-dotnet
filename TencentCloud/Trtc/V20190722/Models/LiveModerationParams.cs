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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveModerationParams : AbstractModel
    {
        
        /// <summary>
        /// <p>AI 内容理解任务类型</p><p>枚举值：</p><ul><li>1： 音频切片理解</li><li>2： 视频截帧理解</li><li>3： 音视切片+视频截帧理解 </li></ul><p>默认值：3</p>
        /// </summary>
        [JsonProperty("ModerationType")]
        public ulong? ModerationType{ get; set; }

        /// <summary>
        /// <p>持续没有上行推流的状态超过MaxIdleTime的时长，自动停止切片。</p><p>取值范围：[30, 1800]</p><p>单位：秒</p><p>默认值：30</p>
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// <p>视频截帧间隔</p><p>取值范围：[1, 60]</p><p>单位：秒</p><p>默认值：5</p>
        /// </summary>
        [JsonProperty("SliceVideo")]
        public ulong? SliceVideo{ get; set; }

        /// <summary>
        /// <p>音频切片时长</p><p>取值范围：[5, 60]</p><p>单位：秒</p><p>默认值：15</p>
        /// </summary>
        [JsonProperty("SliceAudio")]
        public ulong? SliceAudio{ get; set; }

        /// <summary>
        /// <p>是否保存文件</p><p>枚举值：</p><ul><li>0： 0不保存</li><li>1： 1保存所有</li><li>2： 仅命中</li></ul><p>默认值：1</p>
        /// </summary>
        [JsonProperty("SaveModerationFile")]
        public ulong? SaveModerationFile{ get; set; }

        /// <summary>
        /// <p>是否回调所有内容理解结果</p><p>枚举值：</p><ul><li>0： 回调所有结果</li><li>1： 仅回调命中结果</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("CallbackAllResults")]
        public ulong? CallbackAllResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModerationType", this.ModerationType);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "SliceVideo", this.SliceVideo);
            this.SetParamSimple(map, prefix + "SliceAudio", this.SliceAudio);
            this.SetParamSimple(map, prefix + "SaveModerationFile", this.SaveModerationFile);
            this.SetParamSimple(map, prefix + "CallbackAllResults", this.CallbackAllResults);
        }
    }
}

