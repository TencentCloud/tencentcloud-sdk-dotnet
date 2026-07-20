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
        /// 操作类型。describe_scene 表示发现场景和二级下拉选项；fetch_scene 表示获取具体场景快照。必填。
        /// </summary>
        [JsonProperty("Op")]
        public string Op{ get; set; }

        /// <summary>
        /// 防火墙场景类型。支持 internet_edge（互联网边界防火墙）、nat_cluster（NAT边界防火墙-集群）、nat_ha（NAT边界防火墙-主备）、vpc_cluster（VPC边界防火墙-集群）、vpc_ha（VPC边界防火墙-主备）。必填。
        /// </summary>
        [JsonProperty("FirewallType")]
        public string FirewallType{ get; set; }

        /// <summary>
        /// 二级下拉选项 ID。fetch_scene 按需传入，值来自 describe_scene 返回的 selection.available_options[].id；internet_edge 为地域，NAT 为实例 ID，VPC 带宽场景为防火墙组 ID；vpc_cluster 的 connections 汇总场景会忽略该参数。
        /// </summary>
        [JsonProperty("SelectionId")]
        public string SelectionId{ get; set; }

        /// <summary>
        /// 二级下拉显示名称。可替代 SelectionId 按名称匹配，值来自 describe_scene 返回的 selection.available_options[].name。
        /// </summary>
        [JsonProperty("SelectionName")]
        public string SelectionName{ get; set; }

        /// <summary>
        /// 引擎实例 ID。主要用于 vpc_ha 下一个防火墙组对应多个实例的场景，优先使用 describe_scene 返回的 selection.available_options[].instance_id；如只有 instance_ids，则从数组中选择一个字符串值。
        /// </summary>
        [JsonProperty("SelectionInstanceId")]
        public string SelectionInstanceId{ get; set; }

        /// <summary>
        /// 指标页签。fetch_scene 可传；不传时使用该场景默认值。支持 bandwidth、connections。
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 指标下的视角。fetch_scene 可传；不传时使用该场景默认值。支持 ip、subnet、session、switch、vpc，实际可用组合以 describe_scene 返回为准。
        /// </summary>
        [JsonProperty("Perspective")]
        public string Perspective{ get; set; }

        /// <summary>
        /// NAT 主备连接数 IP 视角范围。external 表示外部 IP，asset 表示资产 IP；仅 nat_ha + connections + ip 使用，其他组合传入将返回 InvalidParameter。
        /// </summary>
        [JsonProperty("IpScope")]
        public string IpScope{ get; set; }

        /// <summary>
        /// 预设时间范围。默认 24h；fetch_scene 使用。支持 5m、15m、30m、1h、6h、24h、3d、7d、30d、today、yesterday、day_before_yesterday、this_week、last_week、this_month。
        /// </summary>
        [JsonProperty("TimePreset")]
        public string TimePreset{ get; set; }

        /// <summary>
        /// 自定义开始时间。格式 YYYY-MM-DD HH:MM:SS；必须与 EndTime 同时传，最大跨度 30 天。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 自定义结束时间。格式 YYYY-MM-DD HH:MM:SS；必须与 StartTime 同时传，最大跨度 30 天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 页码，从 1 开始。默认 1；fetch_scene 列表视角使用。
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// 每页条数。默认 10，取值 1 至 100；fetch_scene 列表视角使用。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 是否只获取概览数据。true 时 fetch_scene 只请求 overview，跳过 table/detail，适合只看场景快照汇总。
        /// </summary>
        [JsonProperty("OverviewOnly")]
        public bool? OverviewOnly{ get; set; }

        /// <summary>
        /// 原始偏移量覆盖。可选，传入后覆盖 Page 计算结果；取值 0 至 10000。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序字段。可选。互联网边界 IP、NAT IP/子网视角支持 InputMax、OutputMax；VPC switch 视角支持 SwitchName；VPC ip/vpc 视角支持 FlowMax；其他组合不要传。
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// 排序方向。默认 desc；支持 asc、desc。
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// 过滤条件列表。保留字段；当前公开 fetch_scene 场景均不支持，调用方不要传。
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

