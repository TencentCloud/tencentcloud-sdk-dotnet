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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListVideoDownloadTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备名称，用于模糊搜索
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 通道名称，用于模糊搜索
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 任务状态（0：准备中，1：执行中，2：已完成，3：失败）
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 排序规则（仅支持 StartTime，倒序为-StartTime）
        /// </summary>
        [JsonProperty("SortRule")]
        public string SortRule{ get; set; }

        /// <summary>
        /// 响应是否携带预览地址(0:不携带；1:携带)
        /// </summary>
        [JsonProperty("WithPreviewUrl")]
        public long? WithPreviewUrl{ get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 下载任务 ID
        /// </summary>
        [JsonProperty("DownloadTaskId")]
        public string DownloadTaskId{ get; set; }

        /// <summary>
        /// 下载地址过期时间，单位秒，最大为 1 天， 86400秒
        /// </summary>
        [JsonProperty("UrlExpires")]
        public long? UrlExpires{ get; set; }

        /// <summary>
        /// 任务日期，默认当天
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SortRule", this.SortRule);
            this.SetParamSimple(map, prefix + "WithPreviewUrl", this.WithPreviewUrl);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "DownloadTaskId", this.DownloadTaskId);
            this.SetParamSimple(map, prefix + "UrlExpires", this.UrlExpires);
            this.SetParamSimple(map, prefix + "Date", this.Date);
        }
    }
}

