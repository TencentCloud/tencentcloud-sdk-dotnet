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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwStatusMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>操作类型。describe_scene 表示发现场景和二级下拉选项；fetch_scene 表示获取具体场景快照。必填。</p>
        /// </summary>
        [JsonProperty("Op")]
        public string Op{ get; set; }

        /// <summary>
        /// <p>防火墙场景类型。支持 internet_edge（互联网边界防火墙）、nat_cluster（NAT边界防火墙-集群）、nat_ha（NAT边界防火墙-主备）、vpc_cluster（VPC边界防火墙-集群）、vpc_ha（VPC边界防火墙-主备）。必填。</p>
        /// </summary>
        [JsonProperty("FirewallType")]
        public string FirewallType{ get; set; }

        /// <summary>
        /// <p>二级下拉选项 ID。fetch_scene 按需传入；internet_edge 为地域，NAT 为实例 ID，VPC 带宽场景为防火墙组 ID；vpc_cluster 的 connections 汇总场景会忽略该参数。</p>
        /// </summary>
        [JsonProperty("SelectionId")]
        public string SelectionId{ get; set; }

        /// <summary>
        /// <p>二级下拉显示名称。可替代 SelectionId 按名称匹配。</p>
        /// </summary>
        [JsonProperty("SelectionName")]
        public string SelectionName{ get; set; }

        /// <summary>
        /// <p>引擎实例 ID。主要用于 vpc_ha 下一个防火墙组对应多个实例的场景。</p>
        /// </summary>
        [JsonProperty("SelectionInstanceId")]
        public string SelectionInstanceId{ get; set; }

        /// <summary>
        /// <p>指标页签。fetch_scene 可传；不传时使用该场景默认值。支持 bandwidth、connections。</p>
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// <p>指标下的视角。fetch_scene 可传；不传时使用该场景默认值。支持 ip、subnet、session、switch、vpc，实际可用组合以 describe_scene 返回为准。</p>
        /// </summary>
        [JsonProperty("Perspective")]
        public string Perspective{ get; set; }

        /// <summary>
        /// <p>NAT 主备连接数 IP 视角范围。external 表示外部 IP，asset 表示资产 IP；仅 nat_ha + connections + ip 使用。</p>
        /// </summary>
        [JsonProperty("IpScope")]
        public string IpScope{ get; set; }

        /// <summary>
        /// <p>预设时间范围。默认 24h；fetch_scene 使用。支持 5m、15m、30m、1h、6h、24h、3d、7d、30d、today、yesterday、day_before_yesterday、this_week、last_week、this_month。</p>
        /// </summary>
        [JsonProperty("TimePreset")]
        public string TimePreset{ get; set; }

        /// <summary>
        /// <p>自定义开始时间。格式 YYYY-MM-DD HH:MM:SS；必须与 EndTime 同时传，最大跨度 30 天。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>自定义结束时间。格式 YYYY-MM-DD HH:MM:SS；必须与 StartTime 同时传，最大跨度 30 天。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>页码，从 1 开始。默认 1；fetch_scene 列表视角使用。</p>
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// <p>每页条数。默认 10，最大 100；fetch_scene 列表视角使用。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>是否只获取概览数据。true 时 fetch_scene 只请求 overview，跳过 table/detail，适合只看场景快照汇总。</p>
        /// </summary>
        [JsonProperty("OverviewOnly")]
        public bool? OverviewOnly{ get; set; }

        /// <summary>
        /// <p>原始偏移量覆盖。可选，传入后覆盖 Page 计算结果；必须大于等于 0 且不超过安全上限。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>排序字段。可选，只接受当前场景后端允许的安全字段。</p>
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// <p>排序方向。默认 desc；支持 asc、desc。</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// <p>过滤条件列表。可选，最多 5 个；是否支持以及字段名以具体 fetch_scene 场景为准。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public CfwStatusMonitorFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Op", this.Op);
            this.SetParamSimple(map, prefix + "FirewallType", this.FirewallType);
            this.SetParamSimple(map, prefix + "SelectionId", this.SelectionId);
            this.SetParamSimple(map, prefix + "SelectionName", this.SelectionName);
            this.SetParamSimple(map, prefix + "SelectionInstanceId", this.SelectionInstanceId);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Perspective", this.Perspective);
            this.SetParamSimple(map, prefix + "IpScope", this.IpScope);
            this.SetParamSimple(map, prefix + "TimePreset", this.TimePreset);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OverviewOnly", this.OverviewOnly);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

