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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServerlessInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 索引集群ID
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 索引名
        /// </summary>
        [JsonProperty("IndexNames")]
        public string[] IndexNames{ get; set; }

        /// <summary>
        /// 分页起始位置
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 一页展示数量
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 排序字段，支持索引名：IndexName、索引存储量：IndexStorage、索引创建时间：IndexCreateTime
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 过滤索引状态
        /// </summary>
        [JsonProperty("IndexStatusList")]
        public string[] IndexStatusList{ get; set; }

        /// <summary>
        /// 排序顺序，支持asc、desc，默认为desc
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 索引空间ID列表
        /// </summary>
        [JsonProperty("SpaceIds")]
        public string[] SpaceIds{ get; set; }

        /// <summary>
        /// 数据链路数据源类型
        /// </summary>
        [JsonProperty("DiSourceTypes")]
        public string[] DiSourceTypes{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "IndexNames.", this.IndexNames);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamArraySimple(map, prefix + "IndexStatusList.", this.IndexStatusList);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamArraySimple(map, prefix + "SpaceIds.", this.SpaceIds);
            this.SetParamArraySimple(map, prefix + "DiSourceTypes.", this.DiSourceTypes);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
        }
    }
}

