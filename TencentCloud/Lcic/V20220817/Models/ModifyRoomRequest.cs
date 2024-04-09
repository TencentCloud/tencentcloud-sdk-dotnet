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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoomRequest : AbstractModel
    {
        
        /// <summary>
        /// 房间ID。
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// 低代码互动课堂的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 预定的房间开始时间，unix时间戳（秒）。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 预定的房间结束时间，unix时间戳（秒）。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 老师ID。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("TeacherId")]
        public string TeacherId{ get; set; }

        /// <summary>
        /// 房间名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分辨率。可以有如下取值：
        /// 1 标清
        /// 2 高清
        /// 3 全高清
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("Resolution")]
        public ulong? Resolution{ get; set; }

        /// <summary>
        /// 设置房间/课堂同时最大可与老师进行连麦互动的人数，该参数支持正式上课/开播前调用修改房间修改。
        /// 取值范围[0,16]，当取值为0时表示当前课堂/直播，不支持连麦互动。
        /// </summary>
        [JsonProperty("MaxMicNumber")]
        public ulong? MaxMicNumber{ get; set; }

        /// <summary>
        /// 进入房间时是否自动连麦。可以有以下取值：
        /// 0 不自动连麦（默认值）
        /// 1 自动连麦
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("AutoMic")]
        public ulong? AutoMic{ get; set; }

        /// <summary>
        /// 高音质模式。可以有以下取值：
        /// 0 不开启高音质（默认值）
        /// 1 开启高音质
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("AudioQuality")]
        public ulong? AudioQuality{ get; set; }

        /// <summary>
        /// 房间子类型，可以有以下取值：
        /// videodoc 文档+视频
        /// video 纯视频
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 禁止录制。可以有以下取值：
        /// 0 不禁止录制（默认值）
        /// 1 禁止录制
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("DisableRecord")]
        public ulong? DisableRecord{ get; set; }

        /// <summary>
        /// 助教Id列表。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("Assistants")]
        public string[] Assistants{ get; set; }

        /// <summary>
        /// 房间绑定的群组ID。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 打开学生麦克风/摄像头的授权开关。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("EnableDirectControl")]
        public ulong? EnableDirectControl{ get; set; }

        /// <summary>
        /// 开启专注模式。
        /// 0 收看全部角色音视频(默认)
        /// 1 只看老师和助教
        /// </summary>
        [JsonProperty("InteractionMode")]
        public ulong? InteractionMode{ get; set; }

        /// <summary>
        /// 横竖屏。0：横屏开播（默认值）; 1：竖屏开播，当前仅支持移动端的纯视频类型
        /// </summary>
        [JsonProperty("VideoOrientation")]
        public ulong? VideoOrientation{ get; set; }

        /// <summary>
        /// 开启课后评分。 0：不开启(默认)  1：开启
        /// </summary>
        [JsonProperty("IsGradingRequiredPostClass")]
        public ulong? IsGradingRequiredPostClass{ get; set; }

        /// <summary>
        /// 房间类型: 0 小班课（默认值）; 1 大班课; 2 1V1 （预留参数、暂未开放)
        /// 注：大班课的布局(layout)只有三分屏
        /// </summary>
        [JsonProperty("RoomType")]
        public ulong? RoomType{ get; set; }

        /// <summary>
        /// 录制模板。仅可修改还未开始的房间。录制模板枚举值参考：https://cloud.tencent.com/document/product/1639/89744
        /// </summary>
        [JsonProperty("RecordLayout")]
        public ulong? RecordLayout{ get; set; }

        /// <summary>
        /// 拖堂时间：单位分钟，0为不限制(默认值), -1为不能拖堂，大于0为拖堂的时间，最大值120分钟
        /// </summary>
        [JsonProperty("EndDelayTime")]
        public long? EndDelayTime{ get; set; }

        /// <summary>
        /// 直播方式：0 常规模式（默认）1 回放直播模式（伪直播）
        /// </summary>
        [JsonProperty("LiveType")]
        public ulong? LiveType{ get; set; }

        /// <summary>
        /// 伪直播链接
        /// </summary>
        [JsonProperty("RecordLiveUrl")]
        public string RecordLiveUrl{ get; set; }

        /// <summary>
        /// 是否自动开始上课：0 不自动上课（默认） 1 自动上课 live_type=1的时候有效
        /// </summary>
        [JsonProperty("EnableAutoStart")]
        public ulong? EnableAutoStart{ get; set; }

        /// <summary>
        /// 录制自定义场景，仅recordlayout=9的时候此参数有效,数据内容为用户自定义场景参数，数据格式为json键值对方式，其中键值对的value为string类型。
        /// </summary>
        [JsonProperty("RecordScene")]
        public string RecordScene{ get; set; }

        /// <summary>
        /// 录制自定义语言，仅recordlayout=9的时候此参数有效
        /// </summary>
        [JsonProperty("RecordLang")]
        [System.Obsolete]
        public string RecordLang{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TeacherId", this.TeacherId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "MaxMicNumber", this.MaxMicNumber);
            this.SetParamSimple(map, prefix + "AutoMic", this.AutoMic);
            this.SetParamSimple(map, prefix + "AudioQuality", this.AudioQuality);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamArraySimple(map, prefix + "Assistants.", this.Assistants);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EnableDirectControl", this.EnableDirectControl);
            this.SetParamSimple(map, prefix + "InteractionMode", this.InteractionMode);
            this.SetParamSimple(map, prefix + "VideoOrientation", this.VideoOrientation);
            this.SetParamSimple(map, prefix + "IsGradingRequiredPostClass", this.IsGradingRequiredPostClass);
            this.SetParamSimple(map, prefix + "RoomType", this.RoomType);
            this.SetParamSimple(map, prefix + "RecordLayout", this.RecordLayout);
            this.SetParamSimple(map, prefix + "EndDelayTime", this.EndDelayTime);
            this.SetParamSimple(map, prefix + "LiveType", this.LiveType);
            this.SetParamSimple(map, prefix + "RecordLiveUrl", this.RecordLiveUrl);
            this.SetParamSimple(map, prefix + "EnableAutoStart", this.EnableAutoStart);
            this.SetParamSimple(map, prefix + "RecordScene", this.RecordScene);
            this.SetParamSimple(map, prefix + "RecordLang", this.RecordLang);
        }
    }
}

