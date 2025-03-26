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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAndroidInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量，默认为 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 限制量，默认为20，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 实例ID。每次请求的实例的上限为100。
        /// </summary>
        [JsonProperty("AndroidInstanceIds")]
        public string[] AndroidInstanceIds{ get; set; }

        /// <summary>
        /// 实例地域。目前还不支持按地域进行聚合查询
        /// </summary>
        [JsonProperty("AndroidInstanceRegion")]
        public string AndroidInstanceRegion{ get; set; }

        /// <summary>
        /// 实例可用区
        /// </summary>
        [JsonProperty("AndroidInstanceZone")]
        public string AndroidInstanceZone{ get; set; }

        /// <summary>
        /// 实例分组 ID 列表
        /// </summary>
        [JsonProperty("AndroidInstanceGroupIds")]
        public string[] AndroidInstanceGroupIds{ get; set; }

        /// <summary>
        /// 实例标签选择器
        /// </summary>
        [JsonProperty("LabelSelector")]
        public LabelRequirement[] LabelSelector{ get; set; }

        /// <summary>
        /// 字段过滤器。Filter 的 Name 有以下值：
        /// Name：实例名称
        /// UserId：实例用户ID
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "AndroidInstanceIds.", this.AndroidInstanceIds);
            this.SetParamSimple(map, prefix + "AndroidInstanceRegion", this.AndroidInstanceRegion);
            this.SetParamSimple(map, prefix + "AndroidInstanceZone", this.AndroidInstanceZone);
            this.SetParamArraySimple(map, prefix + "AndroidInstanceGroupIds.", this.AndroidInstanceGroupIds);
            this.SetParamArrayObj(map, prefix + "LabelSelector.", this.LabelSelector);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

