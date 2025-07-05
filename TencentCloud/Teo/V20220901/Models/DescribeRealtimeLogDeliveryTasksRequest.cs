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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRealtimeLogDeliveryTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 分页查询偏移量。默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页查询限制数目。默认值：20，最大值：1000。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 过滤条件，Filters.Values 的上限为 20。该参数不填写时，返回当前 zone-id 下所有实时日志投递任务信息。详细的过滤条件如下：
        /// <li>task-id：按照实时日志投递任务 ID进行过滤。不支持模糊查询。</li>
        /// <li>task-name：按照实时日志投递任务名称进行过滤。支持模糊查询，使用模糊查询时，仅支持填写一个实时日志投递任务名称。</li>
        /// <li>entity-list：按照实时日志投递任务对应的实体进行过滤。不支持模糊查询。示例值：domain.example.com 或者 sid-2s69eb5wcms7。</li>
        /// <li>task-type：按照实时日志投递任务类型进行过滤。不支持模糊查询。可选项如下：<br>   cls: 推送到腾讯云 CLS；<br>   custom_endpoint：推送到自定义 HTTP(S) 地址；<br>   s3：推送到 AWS S3 兼容存储桶地址。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

