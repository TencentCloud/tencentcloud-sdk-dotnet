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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVideoDownloadUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 通道 ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 下载的开始时间，UTC 秒数，开始和结束时间段最长为60分钟，且不能跨天。
        /// 注意：实际下载的文件时长可能会大于该时段时长，通过指定IsRespActualTime参数可以获取实际下载的开始时间和结束时间。 原因是下载是TS切片对齐的，其目的也是为了保证用户下载数据的完整性，完全包含其指定的时间段。
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 下载的结束时间，UTC 秒数，开始和结束时间段最长为60分钟，且不能跨天。
        /// 注意：实际下载的文件时长可能会大于该时段时长，通过指定IsRespActualTime参数可以获取实际下载的开始时间和结束时间。 原因是下载是TS切片对齐的，其目的也是为了保证用户下载数据的完整性，完全包含其指定的时间段。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 文件格式，"mp4"：mp4格式，"ts"：ts文件格式
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 响应data中是否携带实际下载录像的开始时间与结束时间
        /// </summary>
        [JsonProperty("IsRespActualTime")]
        public bool? IsRespActualTime{ get; set; }

        /// <summary>
        /// 是否返回内网下载URL，默认是false，返回公网下载URL，true则返回内网下载URL
        /// </summary>
        [JsonProperty("IsInternal")]
        public bool? IsInternal{ get; set; }

        /// <summary>
        /// 设置URL的有效期, 最小值是1秒, 最大值是86400秒, 不设置的话, 默认是600秒
        /// </summary>
        [JsonProperty("Expires")]
        public long? Expires{ get; set; }

        /// <summary>
        /// 下载的MP4文件是否支持G711音频编码. 
        /// 注意: 如果云端录像中的音频编码为AAC, 那么下载的MP4默认是支持AAC编码的
        /// 如果云端录像中的音频编码为G711且 IsSupportG711设置为true时, 下载的MP4是支持G711音频编码
        /// 如果云端录像中的音频编码为G711且 IsSupportG711设置为false时, 下载的MP4是不支持G711音频编码
        /// 该参数只对FileType为mp4才有效, 不设置的话, 默认是false
        /// </summary>
        [JsonProperty("IsSupportG711")]
        public bool? IsSupportG711{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "IsRespActualTime", this.IsRespActualTime);
            this.SetParamSimple(map, prefix + "IsInternal", this.IsInternal);
            this.SetParamSimple(map, prefix + "Expires", this.Expires);
            this.SetParamSimple(map, prefix + "IsSupportG711", this.IsSupportG711);
        }
    }
}

