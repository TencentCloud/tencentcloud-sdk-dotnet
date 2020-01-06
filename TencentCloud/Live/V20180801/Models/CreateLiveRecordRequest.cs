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

    public class CreateLiveRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 流名称。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 推流路径，与推流和播放地址中的AppName保持一致，默认为 live。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 推流域名。多域名推流必须设置。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 录制开始时间。中国标准时间，需要URLEncode(rfc3986)。如 2017-01-01 10:10:01，编码为：2017-01-01+10%3a10%3a01。
        /// 定时录制模式，必须设置该字段；实时视频录制模式，忽略该字段。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 录制结束时间。中国标准时间，需要URLEncode(rfc3986)。如 2017-01-01 10:30:01，编码为：2017-01-01+10%3a30%3a01。
        /// 定时录制模式，必须设置该字段；实时录制模式，为可选字段。如果通过Highlight参数，设置录制为实时视频录制模式，其设置的结束时间不应超过当前时间+30分钟，如果设置的结束时间超过当前时间+30分钟或者小于当前时间或者不设置该参数，则实际结束时间为当前时间+30分钟。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 录制类型。
        /// “video” : 音视频录制【默认】。
        /// “audio” : 纯音频录制。
        /// 在定时录制模式或实时视频录制模式下，该参数均有效，不区分大小写。
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// 录制文件格式。其值为：
        /// “flv”【默认】,“hls”,”mp4”,“aac”,”mp3”。
        /// 在定时录制模式或实时视频录制模式下，该参数均有效，不区分大小写。
        /// </summary>
        [JsonProperty("FileFormat")]
        public string FileFormat{ get; set; }

        /// <summary>
        /// 开启实时视频录制模式标志。
        /// 0：不开启实时视频录制模式，即定时录制模式【默认】。见[示例一](#.E7.A4.BA.E4.BE.8B1-.E5.88.9B.E5.BB.BA.E5.AE.9A.E6.97.B6.E5.BD.95.E5.88.B6.E4.BB.BB.E5.8A.A1)。
        /// 1：开启实时视频录制模式。见[示例二](#.E7.A4.BA.E4.BE.8B2-.E5.88.9B.E5.BB.BA.E5.AE.9E.E6.97.B6.E5.BD.95.E5.88.B6.E4.BB.BB.E5.8A.A1)。
        /// </summary>
        [JsonProperty("Highlight")]
        public long? Highlight{ get; set; }

        /// <summary>
        /// 开启A+B=C混流C流录制标志。
        /// 0：不开启A+B=C混流C流录制【默认】。
        /// 1：开启A+B=C混流C流录制。
        /// 在定时录制模式或实时视频录制模式下，该参数均有效。
        /// </summary>
        [JsonProperty("MixStream")]
        public long? MixStream{ get; set; }

        /// <summary>
        /// 录制流参数。当前支持以下参数：
        /// record_interval - 录制分片时长，单位 秒，1800 - 7200
        /// storage_time - 录制文件存储时长，单位 秒
        /// eg. record_interval=3600&storage_time=2592000
        /// 注：参数需要url encode。
        /// 在定时录制模式或实时视频录制模式下，该参数均有效。
        /// </summary>
        [JsonProperty("StreamParam")]
        public string StreamParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RecordType", this.RecordType);
            this.SetParamSimple(map, prefix + "FileFormat", this.FileFormat);
            this.SetParamSimple(map, prefix + "Highlight", this.Highlight);
            this.SetParamSimple(map, prefix + "MixStream", this.MixStream);
            this.SetParamSimple(map, prefix + "StreamParam", this.StreamParam);
        }
    }
}

