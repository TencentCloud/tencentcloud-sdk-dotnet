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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStatisticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 统计类型。可选值 Interface：接口类型、Service：服务类型、Group：部署组类型、Instance：实例类型、SQL：SQL类型、NoSQL：NoSQL类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 步长，单位秒。可选值 60、3600、86400
        /// </summary>
        [JsonProperty("TimeStep")]
        public ulong? TimeStep{ get; set; }

        /// <summary>
        /// 偏移量，取值范围大于等于0，默认值为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 单页请求配置数量，取值范围[1, 50]，默认值为10
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 命名空间ID。此字段，和 NamespaceIdList 或者 MetricDimensionValues 字段包含 namespaceId 维度信息。三者选其一。
        /// 可通过[DescribeSimpleNamespaces](https://cloud.tencent.com/document/product/649/36096)查询已经创建的命名空间，也可以通过登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=namespace)查看
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 排序字段:AvgTimeConsuming[默认]、RequestCount、ErrorRate。实例监控还支持 CpuPercent
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序方式：ASC:0、DESC:1
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// 开始时间：年月日 时分秒2020-05-12 14:43:12， 不能为空
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 开始时间：年月日 时分秒2020-05-12 14:43:12， 不能为空
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 搜索关键词
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 维度。此字段，和 NamespaceIdList 或者 MetricDimensionValues 字段包含 namespaceId 维度信息。三者选其一
        /// </summary>
        [JsonProperty("MetricDimensionValues")]
        public MetricDimensionValue[] MetricDimensionValues{ get; set; }

        /// <summary>
        /// 聚合关键词
        /// </summary>
        [JsonProperty("BucketKey")]
        public string BucketKey{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 命名空间ID数组。此字段，和 NamespaceIdList 或者 MetricDimensionValues 字段包含 namespaceId 维度信息。三者选其一
        /// </summary>
        [JsonProperty("NamespaceIdList")]
        public string[] NamespaceIdList{ get; set; }

        /// <summary>
        /// 独占配置中心的ID。
        /// 可通过调用[DescribeClusterInstances](https://cloud.tencent.com/document/product/649/36048)查询已导入的实例列表或登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=instance)进行查询。实例ID例如：ins-6decplwk。
        /// </summary>
        [JsonProperty("ConfigCenterInstanceId")]
        public string ConfigCenterInstanceId{ get; set; }

        /// <summary>
        /// 服务过滤
        /// </summary>
        [JsonProperty("ServiceFilter")]
        public string ServiceFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TimeStep", this.TimeStep);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamArrayObj(map, prefix + "MetricDimensionValues.", this.MetricDimensionValues);
            this.SetParamSimple(map, prefix + "BucketKey", this.BucketKey);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamArraySimple(map, prefix + "NamespaceIdList.", this.NamespaceIdList);
            this.SetParamSimple(map, prefix + "ConfigCenterInstanceId", this.ConfigCenterInstanceId);
            this.SetParamSimple(map, prefix + "ServiceFilter", this.ServiceFilter);
        }
    }
}

