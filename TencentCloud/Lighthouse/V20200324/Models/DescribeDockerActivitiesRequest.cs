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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDockerActivitiesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。可通过[DescribeInstances](https://cloud.tencent.com/document/product/1207/47573)接口返回值中的InstanceId获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Docker活动ID列表。可通过[DescribeDockerActivities](https://cloud.tencent.com/document/product/1207/95476)接口返回值中的ActivityId获取。
        /// </summary>
        [JsonProperty("ActivityIds")]
        public string[] ActivityIds{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 活动创建时间的起始值，时间戳秒数。
        /// </summary>
        [JsonProperty("CreatedTimeBegin")]
        public long? CreatedTimeBegin{ get; set; }

        /// <summary>
        /// 活动创建时间的结束值，时间戳秒数。
        /// </summary>
        [JsonProperty("CreatedTimeEnd")]
        public long? CreatedTimeEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "ActivityIds.", this.ActivityIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "CreatedTimeBegin", this.CreatedTimeBegin);
            this.SetParamSimple(map, prefix + "CreatedTimeEnd", this.CreatedTimeEnd);
        }
    }
}

