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

    public class ModerationParams : AbstractModel
    {
        
        /// <summary>
        /// <p>AI 内容理解任务类型， 1:音频切片理解，2:视频截帧理解，3:音视切片+视频截帧理解  默认值1 </p><p>枚举值：</p><ul><li>1： 音频切片理解</li></ul>
        /// </summary>
        [JsonProperty("ModerationType")]
        public ulong? ModerationType{ get; set; }

        /// <summary>
        /// <p>房间内持续没有用户（主播）上行推流的状态超过MaxIdleTime的时长，自动停止切片，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于1800秒(0.5小时)。示例值：30</p>
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// <p>音频切片时长，默认15s 示例值：15, 范围15-60s</p>
        /// </summary>
        [JsonProperty("SliceAudio")]
        public ulong? SliceAudio{ get; set; }

        /// <summary>
        /// <p>视频截帧间隔时长，默认5s, 范围1-60s</p>
        /// </summary>
        [JsonProperty("SliceVideo")]
        public ulong? SliceVideo{ get; set; }

        /// <summary>
        /// <p>供应商枚举，<br>trtc : trtc内容理解</p>
        /// </summary>
        [JsonProperty("ModerationSupplier")]
        public string ModerationSupplier{ get; set; }

        /// <summary>
        /// <p>第三方内容理解供应商需要配置信息, ModerationSupplier为trtc时，这个参数可以不需要初始化</p>
        /// </summary>
        [JsonProperty("ModerationSupplierParam")]
        public ModerationSupplierParam ModerationSupplierParam{ get; set; }

        /// <summary>
        /// <p>是否保存文件:  0不保存文件 1保存所有文件 2仅保存命中文件</p>
        /// </summary>
        [JsonProperty("SaveModerationFile")]
        public ulong? SaveModerationFile{ get; set; }

        /// <summary>
        /// <p>是否回调所有内容理解结果:
        /// 0 默认回调所有结果 
        /// 1 仅回调命中结果</p>
        /// </summary>
        [JsonProperty("CallbackAllResults")]
        public ulong? CallbackAllResults{ get; set; }

        /// <summary>
        /// <p>指定订阅流白名单或者黑名单。</p>
        /// </summary>
        [JsonProperty("SubscribeStreamUserIds")]
        public SubscribeModerationUserIds SubscribeStreamUserIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModerationType", this.ModerationType);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "SliceAudio", this.SliceAudio);
            this.SetParamSimple(map, prefix + "SliceVideo", this.SliceVideo);
            this.SetParamSimple(map, prefix + "ModerationSupplier", this.ModerationSupplier);
            this.SetParamObj(map, prefix + "ModerationSupplierParam.", this.ModerationSupplierParam);
            this.SetParamSimple(map, prefix + "SaveModerationFile", this.SaveModerationFile);
            this.SetParamSimple(map, prefix + "CallbackAllResults", this.CallbackAllResults);
            this.SetParamObj(map, prefix + "SubscribeStreamUserIds.", this.SubscribeStreamUserIds);
        }
    }
}

