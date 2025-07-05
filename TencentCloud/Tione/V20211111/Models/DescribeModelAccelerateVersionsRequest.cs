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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelAccelerateVersionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件
        ///     Filter.Name: 枚举值: ModelJobName (任务名称)|TrainingModelVersionId (模型版本id)
        ///     Filter.Values: 当长度为1时，支持模糊查询; 不为1时，精确查询
        /// 每次请求的Filters的上限为10，Filter.Values的上限为100
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段; 枚举值: CreateTime (创建时间) ；默认CreateTime
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方向; 枚举值: ASC | DESC；默认DESC
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 分页查询起始位置，如：Limit为100，第一页Offset为0，第二页Offset为100....即每页左边为闭区间; 默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页查询每页大小，最大20000; 默认10
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("TrainingModelId")]
        public string TrainingModelId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "TrainingModelId", this.TrainingModelId);
        }
    }
}

