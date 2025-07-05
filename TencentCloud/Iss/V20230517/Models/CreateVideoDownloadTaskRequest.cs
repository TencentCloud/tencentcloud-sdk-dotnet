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

    public class CreateVideoDownloadTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 通道ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 默认1倍速，支持（1,2,4,8）倍速
        /// </summary>
        [JsonProperty("Scale")]
        public long? Scale{ get; set; }

        /// <summary>
        /// 转码后的mp4文件过期时间（支持7,15,30,60,90,180,365）
        /// </summary>
        [JsonProperty("Expire")]
        public long? Expire{ get; set; }

        /// <summary>
        /// 下载文件格式，当前仅支持（1：mp4）
        /// </summary>
        [JsonProperty("FileType")]
        public long? FileType{ get; set; }

        /// <summary>
        /// 完成策略（0：拉流失败但是录像不完整则认为任务失败，不生成 MP4；1：拉流失败但是录像不完整则认为任务成功，生成 mp4）
        /// </summary>
        [JsonProperty("CompletionPolicy")]
        public long? CompletionPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Scale", this.Scale);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CompletionPolicy", this.CompletionPolicy);
        }
    }
}

