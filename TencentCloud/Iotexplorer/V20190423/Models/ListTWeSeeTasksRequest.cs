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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListTWeSeeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>设备名称</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>分页拉取数量</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>产品 ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>算法类目。可选值：</p><ul><li><code>COMPREHENSION</code>：视觉理解</li><li><code>HIGHLIGHT</code>：视频浓缩</li><li><code>SUMMARIZATION</code>：每日/每周总结</li></ul>
        /// </summary>
        [JsonProperty("ServiceCategory")]
        public string ServiceCategory{ get; set; }

        /// <summary>
        /// <p>通道 ID</p>
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// <p>查询任务时间范围的结束时间（毫秒级 UNIX 时间戳）。不传则不生效时间范围条件。</p>
        /// </summary>
        [JsonProperty("EndTimeMs")]
        public long? EndTimeMs{ get; set; }

        /// <summary>
        /// <p>下载 URL 的过期时间（秒级 UNIX 时间戳）。若传入该参数，则响应中将包含所有文件的下载 URL</p>
        /// </summary>
        [JsonProperty("FileURLExpireTime")]
        public long? FileURLExpireTime{ get; set; }

        /// <summary>
        /// <p>任务结果过滤条件</p>
        /// </summary>
        [JsonProperty("Filters")]
        public VisionRecognitionTaskFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>分页拉取偏移</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>算法类型。</p><p>当 ServiceCategory 为 <code>COMPREHENSION</code> 时，可选值包括：</p><ul><li><code>VID_COMP</code>：视频理解</li><li><code>IMG_COMP</code>：图片理解</li><li><code>CONT_PERSON_MOTIONLESS</code>：静姿检测</li></ul><p>当 ServiceCategory 为 <code>HIGHLIGHT</code> 时，可选值包括：</p><ul><li><code>COMP_HIGHLIGHT</code>：视频浓缩</li></ul><p>当 ServiceCategory 为 <code>SUMMARIZATION</code> 时，可选值包括：</p><ul><li><code>DAILY_SUM</code>：每日总结</li><li><code>WEEKLY_SUM</code>：每周总结</li></ul>
        /// </summary>
        [JsonProperty("ServiceTypes")]
        public string[] ServiceTypes{ get; set; }

        /// <summary>
        /// <p>查询任务时间范围的起始时间（毫秒级 UNIX 时间戳）。不传则不生效时间范围条件。</p>
        /// </summary>
        [JsonProperty("StartTimeMs")]
        public long? StartTimeMs{ get; set; }

        /// <summary>
        /// <p>要查询的任务的状态条件。不传则不按照状态过滤，可选值：</p><ul><li><code>1</code>：失败</li><li><code>2</code>：空结果</li><li><code>3</code>：有效结果</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ServiceCategory", this.ServiceCategory);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "EndTimeMs", this.EndTimeMs);
            this.SetParamSimple(map, prefix + "FileURLExpireTime", this.FileURLExpireTime);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "ServiceTypes.", this.ServiceTypes);
            this.SetParamSimple(map, prefix + "StartTimeMs", this.StartTimeMs);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

