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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTopologyNewRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务系统 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 上游层级
        /// </summary>
        [JsonProperty("UpLevel")]
        public long? UpLevel{ get; set; }

        /// <summary>
        /// 应用实例信息
        /// </summary>
        [JsonProperty("ServiceInstance")]
        public string ServiceInstance{ get; set; }

        /// <summary>
        /// 下游层级
        /// </summary>
        [JsonProperty("DownLevel")]
        public long? DownLevel{ get; set; }

        /// <summary>
        /// 视角
        /// </summary>
        [JsonProperty("View")]
        public string View{ get; set; }

        /// <summary>
        /// 过滤器
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 表示Topic（MQ拓扑图用）
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 视图筛选列表
        /// </summary>
        [JsonProperty("Selectors")]
        public Selectors Selectors{ get; set; }

        /// <summary>
        /// 视图ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// TraceID
        /// </summary>
        [JsonProperty("TraceID")]
        public string TraceID{ get; set; }

        /// <summary>
        /// 查询top5慢响应节点
        /// </summary>
        [JsonProperty("IsSlowTopFive")]
        public bool? IsSlowTopFive{ get; set; }

        /// <summary>
        /// 是否获取资源层信息
        /// </summary>
        [JsonProperty("GetResource")]
        public bool? GetResource{ get; set; }

        /// <summary>
        /// 根据应用标签过滤
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// 不显示的节点类型
        /// </summary>
        [JsonProperty("Hidden")]
        public Selectors Hidden{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "UpLevel", this.UpLevel);
            this.SetParamSimple(map, prefix + "ServiceInstance", this.ServiceInstance);
            this.SetParamSimple(map, prefix + "DownLevel", this.DownLevel);
            this.SetParamSimple(map, prefix + "View", this.View);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamObj(map, prefix + "Selectors.", this.Selectors);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TraceID", this.TraceID);
            this.SetParamSimple(map, prefix + "IsSlowTopFive", this.IsSlowTopFive);
            this.SetParamSimple(map, prefix + "GetResource", this.GetResource);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "Hidden.", this.Hidden);
        }
    }
}

