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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRedisClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// Redis独享集群 ID。请登录[专用集群控制台](https://console.cloud.tencent.com/cdc/dedicatedcluster/index?rid=1
        /// )切换至**云服务管理**页面，在下拉框选择**云数据库 Redis**，可获取独享集群ID。
        /// </summary>
        [JsonProperty("RedisClusterIds")]
        public string[] RedisClusterIds{ get; set; }

        /// <summary>
        /// 集群状态。
        /// - 1：流程。
        /// - 2：运行中。
        /// - 3：已隔离。
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// 项目ID数组。请登录[项目管理](https://console.cloud.tencent.com/project)页面，在**项目名称**中复制项目 ID。
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 续费模式。
        /// - 0：默认状态，手动续费。
        /// - 1：自动续费。
        /// - 2：明确不自动续费。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long?[] AutoRenewFlag{ get; set; }

        /// <summary>
        /// Redis 独享集群名称。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 搜索关键词：支持集群 ID、集群名称。
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// 分页限制返回大小，不传则默认为20。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，取Limit整数倍
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 本地专用集群 ID，请登录[专用集群控制台](https://console.cloud.tencent.com/cdc/dedicatedcluster/index?rid=1
        /// )实例列表获取集群 ID。
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RedisClusterIds.", this.RedisClusterIds);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "AutoRenewFlag.", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
        }
    }
}

