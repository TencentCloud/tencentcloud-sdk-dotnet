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
        /// 审核任务类型， 1:音频切片审核，2:视频截帧审核，3:音视切片审核+视频截帧审核4:音频流式审核 5:音频流式+视频截帧审核  默认值1 （流式审核需要供应商支持才生效）
        /// </summary>
        [JsonProperty("ModerationType")]
        public ulong? ModerationType{ get; set; }

        /// <summary>
        /// 房间内持续没有用户（主播）上行推流的状态超过MaxIdleTime的时长，自动停止切片，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于1800秒(0.5小时)。示例值：30 
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// 音频切片时长，默认15s 示例值：15
        /// </summary>
        [JsonProperty("SliceAudio")]
        public ulong? SliceAudio{ get; set; }

        /// <summary>
        /// 视频截帧间隔时长，默认5s
        /// </summary>
        [JsonProperty("SliceVideo")]
        public ulong? SliceVideo{ get; set; }

        /// <summary>
        /// 供应商枚举，
        /// tianyu : 天御内容安全 （支持 1:音频切片审核，2:视频截帧审核，3:音视切片审核+视频截帧审核）
        /// ace  : ACE内容安全 （支持 1:音频切片审核，2:视频截帧审核，3:音视切片审核+视频截帧审核）
        /// shumei : 数美审核（支持 1:音频切片审核，2:视频截帧审核，3:音视切片审核+视频截帧审核）
        /// yidun : 网易易盾审核 （支持 1:音频切片审核，2:视频截帧审核，3:音视切片审核+视频截帧审核）
        /// </summary>
        [JsonProperty("ModerationSupplier")]
        public string ModerationSupplier{ get; set; }

        /// <summary>
        /// 第三方审核商送审需要配置信息
        /// </summary>
        [JsonProperty("ModerationSupplierParam")]
        public ModerationSupplierParam ModerationSupplierParam{ get; set; }

        /// <summary>
        /// 是否保存命中文件 0 默认不保存  1 保存命中文件
        /// </summary>
        [JsonProperty("SaveModerationFile")]
        public ulong? SaveModerationFile{ get; set; }

        /// <summary>
        /// 是否回调所有审核结果:
        /// 0 默认回调所有结果 
        /// 1 仅回调命中结果 
        /// </summary>
        [JsonProperty("CallbackAllResults")]
        public ulong? CallbackAllResults{ get; set; }

        /// <summary>
        /// 指定订阅流白名单或者黑名单。
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

