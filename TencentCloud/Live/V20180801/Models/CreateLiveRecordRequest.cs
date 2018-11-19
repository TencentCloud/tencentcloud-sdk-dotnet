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
        /// 直播流所属应用名称。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 推流域名。多域名推流必须设置。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 任务起始时间，录制视频为精彩视频时，忽略此字段。如 2017-01-01 10:10:01。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间。若指定精彩视频录制，结束时间不超过当前时间+30分钟，如果超过或小于起始时间，则实际结束时间为当前时间+30分钟。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 录制类型。不区分大小写。
        /// “video” : 音视频录制【默认】。
        /// “audio” : 纯音频录制。
        /// </summary>
        [JsonProperty("RecordType")]
        public string RecordType{ get; set; }

        /// <summary>
        /// 录制文件格式。不区分大小写。其值为：
        /// “flv”,“hls”,”mp4”,“aac”,”mp3”，默认“flv”。
        /// </summary>
        [JsonProperty("FileFormat")]
        public string FileFormat{ get; set; }

        /// <summary>
        /// 精彩视频标志。0：普通视频【默认】；1：精彩视频。
        /// </summary>
        [JsonProperty("Highlight")]
        public long? Highlight{ get; set; }

        /// <summary>
        /// A+B=C混流标志。0：非A+B=C混流录制【默认】；1：标示为A+B=C混流录制。
        /// </summary>
        [JsonProperty("MixStream")]
        public long? MixStream{ get; set; }

        /// <summary>
        /// 录制流参数，当前支持以下参数： 
        /// interval 录制分片时长，单位 秒，0 - 7200
        /// storage_time 录制文件存储时长，单位 秒
        /// eg. interval=3600&storage_time=7200
        /// 注：参数需要url encode。
        /// </summary>
        [JsonProperty("StreamParam")]
        public string StreamParam{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
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

