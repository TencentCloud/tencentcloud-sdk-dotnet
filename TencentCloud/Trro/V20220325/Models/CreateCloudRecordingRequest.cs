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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudRecordingRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 视频流号
        /// </summary>
        [JsonProperty("VideoStreamId")]
        public long? VideoStreamId{ get; set; }

        /// <summary>
        /// 腾讯云对象存储COS以及第三方云存储的账号信息
        /// </summary>
        [JsonProperty("CloudStorage")]
        public CloudStorage CloudStorage{ get; set; }

        /// <summary>
        /// 如果是aac或者mp4文件格式，超过长度限制后，系统会自动拆分视频文件。单位：分钟。默认为1440min（24h），取值范围为1-1440。【单文件限制最大为2G，满足文件大小 >2G 或录制时长度 > 24h任意一个条件，文件都会自动切分】 Hls 格式录制此参数不生效。
        /// </summary>
        [JsonProperty("MaxMediaFileDuration")]
        public long? MaxMediaFileDuration{ get; set; }

        /// <summary>
        /// 输出文件的格式（存储至COS等第三方存储时有效）。0：输出文件为hls格式。1：输出文件格式为hls+mp4。2：输出文件格式为hls+aac 。3：(默认)输出文件格式为mp4。4：输出文件格式为aac。
        /// </summary>
        [JsonProperty("OutputFormat")]
        public long? OutputFormat{ get; set; }

        /// <summary>
        /// 房间内持续没有主播的状态超过MaxIdleTime的时长，自动停止录制，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于 86400秒(24小时)。 示例值：30
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public long? MaxIdleTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "VideoStreamId", this.VideoStreamId);
            this.SetParamObj(map, prefix + "CloudStorage.", this.CloudStorage);
            this.SetParamSimple(map, prefix + "MaxMediaFileDuration", this.MaxMediaFileDuration);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
        }
    }
}

