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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRoomRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>课堂名称。<br>字符数不超过256</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>预定的课堂开始时间，unix时间戳（秒）。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// <p>预定的课堂结束时间，unix时间戳（秒）。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// <p>低代码互动课堂的SdkAppId。</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// <p>头像区域，摄像头视频画面的分辨率。可以有如下取值：<br>1 标清<br>2 高清<br>3 全高清<br>注意：连麦人数（MaxMicNumber）&gt;6时，仅可使用标清</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public ulong? Resolution{ get; set; }

        /// <summary>
        /// <p>设置课堂同时最大可与老师进行连麦互动的人数，该参数支持正式上课/开播前调用修改房间修改。小班课取值范围[0,16]，大班课取值范围[0,1]，当取值为0时表示当前课堂/直播，不支持连麦互动。该取值影响计费，请根据业务实际情况设置。计费规则见“购买指南”下“计费概述”。</p>
        /// </summary>
        [JsonProperty("MaxMicNumber")]
        public ulong? MaxMicNumber{ get; set; }

        /// <summary>
        /// <p>课堂子类型，可以有以下取值：videodoc 文档+视频video 纯视频</p>
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// <p>老师ID。通过[注册用户]接口获取的UserId。指定后该用户在房间内拥有老师权限。</p>
        /// </summary>
        [JsonProperty("TeacherId")]
        public string TeacherId{ get; set; }

        /// <summary>
        /// <p>进入课堂时是否自动连麦。可以有以下取值：<br>0 不自动连麦（需要手动申请上麦，默认值）<br>1 自动连麦</p>
        /// </summary>
        [JsonProperty("AutoMic")]
        public ulong? AutoMic{ get; set; }

        /// <summary>
        /// <p>释放音视频权限后是否自动取消连麦。可以有以下取值：<br>0 自动取消连麦（默认值）<br>1 保持连麦状态</p>
        /// </summary>
        [JsonProperty("TurnOffMic")]
        public ulong? TurnOffMic{ get; set; }

        /// <summary>
        /// <p>声音音质。可以有以下取值：<br>0：流畅模式（默认值），占用更小的带宽、拥有更好的降噪效果，适用于1对1、小班教学、多人音视频会议等场景。<br>1：高音质模式，适合需要高保真传输音乐的场景，但降噪效果会被削弱，适用于音乐教学场景。</p>
        /// </summary>
        [JsonProperty("AudioQuality")]
        public ulong? AudioQuality{ get; set; }

        /// <summary>
        /// <p>录制方式，可以有以下取值：0 开启自动录制（默认值）1  禁止录制2 开启手动录制 注： - 如果该配置取值为0，录制将从上课后开始，课堂结束后停止。 - 如果该配置取值为2，需通过startRecord、stopRecord接口控制录制的开始和结束。</p>
        /// </summary>
        [JsonProperty("DisableRecord")]
        public ulong? DisableRecord{ get; set; }

        /// <summary>
        /// <p>助教Id列表。通过[注册用户]接口获取的UserId。指定后该用户在房间内拥有助教权限。</p>
        /// </summary>
        [JsonProperty("Assistants")]
        public string[] Assistants{ get; set; }

        /// <summary>
        /// <p>rtc人数。</p>
        /// </summary>
        [JsonProperty("RTCAudienceNumber")]
        [System.Obsolete]
        public ulong? RTCAudienceNumber{ get; set; }

        /// <summary>
        /// <p>观看类型。互动观看 （默认）</p>
        /// </summary>
        [JsonProperty("AudienceType")]
        public ulong? AudienceType{ get; set; }

        /// <summary>
        /// <p>录制模板。未配置时默认取值0。录制模板枚举值参考：https://cloud.tencent.com/document/product/1639/89744</p>
        /// </summary>
        [JsonProperty("RecordLayout")]
        public ulong? RecordLayout{ get; set; }

        /// <summary>
        /// <p>课堂绑定的群组ID,非空时限制组成员进入</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>是否允许老师/助教直接控制学生的摄像头/麦克风。可以有以下取值：<br>0 不允许直接控制（需同意，默认值）<br>1 允许直接控制（无需同意）</p>
        /// </summary>
        [JsonProperty("EnableDirectControl")]
        public ulong? EnableDirectControl{ get; set; }

        /// <summary>
        /// <p>开启专注模式。<br>0 收看全部角色音视频(默认)<br>1 只看老师和助教</p>
        /// </summary>
        [JsonProperty("InteractionMode")]
        public long? InteractionMode{ get; set; }

        /// <summary>
        /// <p>横竖屏。0：横屏开播（默认值）; 1：竖屏开播，当前仅支持移动端的纯视频类型</p>
        /// </summary>
        [JsonProperty("VideoOrientation")]
        public ulong? VideoOrientation{ get; set; }

        /// <summary>
        /// <p>开启课后评分。 0：不开启(默认)  1：开启</p>
        /// </summary>
        [JsonProperty("IsGradingRequiredPostClass")]
        public long? IsGradingRequiredPostClass{ get; set; }

        /// <summary>
        /// <p>课堂类型。  注：大班课的布局(layout)只有三分屏</p><p>枚举值：</p><ul><li>0： 小班课（默认值）</li><li>1： 大班课</li><li>2： 1V1 (预留参数，暂未开放);</li><li>3： 圆桌会议</li><li>4： 分组直播 </li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("RoomType")]
        public long? RoomType{ get; set; }

        /// <summary>
        /// <p>嘉宾Id列表。当圆桌会议模式（RoomType==3）时生效</p>
        /// </summary>
        [JsonProperty("Guests")]
        public string[] Guests{ get; set; }

        /// <summary>
        /// <p>拖堂时间：单位分钟，0为不限制(默认值), -1为不能拖堂，大于0为拖堂的时间，最大值120分钟</p>
        /// </summary>
        [JsonProperty("EndDelayTime")]
        public long? EndDelayTime{ get; set; }

        /// <summary>
        /// <p>直播类型：0 常规（默认）1 伪直播 2 RTMP推流直播</p>
        /// </summary>
        [JsonProperty("LiveType")]
        public ulong? LiveType{ get; set; }

        /// <summary>
        /// <p>伪直播链接。 支持的协议以及格式： 协议：HTTP、HTTPS、RTMP、HLS 。格式：FLV、MP3、MP4、MPEG-TS、MOV、MKV、M4A。视频编码：H.264、VP8。音频编码：AAC、OPUS。</p><p>注意：伪直播视频规格建议最高使用1080p 30fps，4k视频会有兼容性问题导致直播失败。</p>
        /// </summary>
        [JsonProperty("RecordLiveUrl")]
        public string RecordLiveUrl{ get; set; }

        /// <summary>
        /// <p>是否自动开始上课：0 不自动上课（默认） 1 自动上课 live_type=1或2的时候有效</p>
        /// </summary>
        [JsonProperty("EnableAutoStart")]
        public ulong? EnableAutoStart{ get; set; }

        /// <summary>
        /// <p>录制文件背景图片，支持png、jpg、jpeg、bmp格式，暂不支持透明通道</p>
        /// </summary>
        [JsonProperty("RecordBackground")]
        public string RecordBackground{ get; set; }

        /// <summary>
        /// <p>录制自定义场景。注意：仅recordlayout=9的时候此参数有效。需注意各类参数配置正确能够生效。不然会造成录制失败，失败后无法补救。数据内容为用户自定义场景参数，数据格式为json键值对方式，其中键值对的value为string类型。</p><p>自定义场景参数的含义。如下：<br>     scene：自定义js/css对应的场景值。如scene=recordScene，会加载 recordScene 场景对应的 js/css，这样就可以自定义录制页面的元素。<br>    lng：录制页面对应的语种。如lng=en，则录制界面为en。（枚举值：en,zh，zh-TW，jp，ar，kr，vi）<br>     customToken：录制页面中涉及客户自己的服务需要鉴权时进行配置。一般情况下，无需配置。</p>
        /// </summary>
        [JsonProperty("RecordScene")]
        public string RecordScene{ get; set; }

        /// <summary>
        /// <p>录制自定义语言，仅recordlayout=9的时候此参数有效</p>
        /// </summary>
        [JsonProperty("RecordLang")]
        [System.Obsolete]
        public string RecordLang{ get; set; }

        /// <summary>
        /// <p>录制类型 0 仅录制混流（默认） ;1 录制混流+单流，该模式下除混流录制基础上，分别录制老师、台上学生的音视频流，每路录制都会产生相应的录制费用 。示例：0</p>
        /// </summary>
        [JsonProperty("RecordStream")]
        public ulong? RecordStream{ get; set; }

        /// <summary>
        /// <p>板书截图生成类型。0 不生成板书（默认）；1 全量模式；2 单页去重模式</p>
        /// </summary>
        [JsonProperty("WhiteBoardSnapshotMode")]
        public ulong? WhiteBoardSnapshotMode{ get; set; }

        /// <summary>
        /// <p>字幕转写功能开关。可以有以下取值：<br>0 不开启字幕转写功能（默认值）<br>1 自动转写模式：上课自动开启，下课自动停止<br>2 手动转写模式：支持老师或者助教通过客户端API手动开启/关闭字幕转写<br>设置0和1时客户端均不展示手动开关，设置2时老师或者助教端展示字幕转写开关</p>
        /// </summary>
        [JsonProperty("SubtitlesTranscription")]
        public ulong? SubtitlesTranscription{ get; set; }

        /// <summary>
        /// <p>录制文件合并开关。0 关闭 1 开启 注：只有在一节课多次启用手动录制时，此功能才有效</p>
        /// </summary>
        [JsonProperty("RecordMerge")]
        public ulong? RecordMerge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "MaxMicNumber", this.MaxMicNumber);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "TeacherId", this.TeacherId);
            this.SetParamSimple(map, prefix + "AutoMic", this.AutoMic);
            this.SetParamSimple(map, prefix + "TurnOffMic", this.TurnOffMic);
            this.SetParamSimple(map, prefix + "AudioQuality", this.AudioQuality);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamArraySimple(map, prefix + "Assistants.", this.Assistants);
            this.SetParamSimple(map, prefix + "RTCAudienceNumber", this.RTCAudienceNumber);
            this.SetParamSimple(map, prefix + "AudienceType", this.AudienceType);
            this.SetParamSimple(map, prefix + "RecordLayout", this.RecordLayout);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EnableDirectControl", this.EnableDirectControl);
            this.SetParamSimple(map, prefix + "InteractionMode", this.InteractionMode);
            this.SetParamSimple(map, prefix + "VideoOrientation", this.VideoOrientation);
            this.SetParamSimple(map, prefix + "IsGradingRequiredPostClass", this.IsGradingRequiredPostClass);
            this.SetParamSimple(map, prefix + "RoomType", this.RoomType);
            this.SetParamArraySimple(map, prefix + "Guests.", this.Guests);
            this.SetParamSimple(map, prefix + "EndDelayTime", this.EndDelayTime);
            this.SetParamSimple(map, prefix + "LiveType", this.LiveType);
            this.SetParamSimple(map, prefix + "RecordLiveUrl", this.RecordLiveUrl);
            this.SetParamSimple(map, prefix + "EnableAutoStart", this.EnableAutoStart);
            this.SetParamSimple(map, prefix + "RecordBackground", this.RecordBackground);
            this.SetParamSimple(map, prefix + "RecordScene", this.RecordScene);
            this.SetParamSimple(map, prefix + "RecordLang", this.RecordLang);
            this.SetParamSimple(map, prefix + "RecordStream", this.RecordStream);
            this.SetParamSimple(map, prefix + "WhiteBoardSnapshotMode", this.WhiteBoardSnapshotMode);
            this.SetParamSimple(map, prefix + "SubtitlesTranscription", this.SubtitlesTranscription);
            this.SetParamSimple(map, prefix + "RecordMerge", this.RecordMerge);
        }
    }
}

