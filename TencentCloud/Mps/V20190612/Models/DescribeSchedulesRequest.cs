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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSchedulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 编排 ID 过滤条件，数组长度限制：100。
        /// </summary>
        [JsonProperty("ScheduleIds")]
        public long?[] ScheduleIds{ get; set; }

        /// <summary>
        /// 编排触发类型，可选值：
        /// <li>CosFileUpload： 腾讯云 COS 文件上传触发</li>
        /// <li>AwsS3FileUpload：Aws S3 文件上传触发。</li>
        /// 不填或者为空表示全部。
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// 状态，取值范围：
        /// <li>Enabled：已启用，</li>
        /// <li>Disabled：已禁用。</li>
        /// 不填此参数，则不区编排状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 分页偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回记录条数，默认值：10，最大值：100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ScheduleIds.", this.ScheduleIds);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

