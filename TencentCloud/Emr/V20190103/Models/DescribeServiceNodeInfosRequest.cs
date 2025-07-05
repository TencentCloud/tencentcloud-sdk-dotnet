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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServiceNodeInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 搜索字段
        /// </summary>
        [JsonProperty("SearchText")]
        public string SearchText{ get; set; }

        /// <summary>
        /// '配置状态，-2：配置失败，-1:配置过期，1：已同步', -99 '全部'
        /// </summary>
        [JsonProperty("ConfStatus")]
        public long? ConfStatus{ get; set; }

        /// <summary>
        /// 过滤条件：维护状态
        /// 0代表所有状态
        /// 1代表正常模式
        /// 2代表维护模式
        /// </summary>
        [JsonProperty("MaintainStateId")]
        public long? MaintainStateId{ get; set; }

        /// <summary>
        /// 过滤条件：操作状态
        /// 0代表所有状态
        /// 1代表已启动
        /// 2代表已停止
        /// </summary>
        [JsonProperty("OperatorStateId")]
        public long? OperatorStateId{ get; set; }

        /// <summary>
        /// 过滤条件：健康状态
        /// "0"代表不可用
        /// "1"代表良好
        /// "-2"代表未知
        /// "-99"代表所有
        /// "-3"代表存在隐患
        /// "-4"代表未探测
        /// </summary>
        [JsonProperty("HealthStateId")]
        public string HealthStateId{ get; set; }

        /// <summary>
        /// 服务组件名称，都是大写例如YARN
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 节点名称master,core,task,common,router
        /// </summary>
        [JsonProperty("NodeTypeName")]
        public string NodeTypeName{ get; set; }

        /// <summary>
        /// 过滤条件：dn是否处于维护状态
        /// 0代表所有状态
        /// 1代表处于维护状态
        /// </summary>
        [JsonProperty("DataNodeMaintenanceId")]
        public long? DataNodeMaintenanceId{ get; set; }

        /// <summary>
        /// 支持搜索的字段，目前支持 SearchType	：ipv4
        /// </summary>
        [JsonProperty("SearchFields")]
        public SearchItem[] SearchFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SearchText", this.SearchText);
            this.SetParamSimple(map, prefix + "ConfStatus", this.ConfStatus);
            this.SetParamSimple(map, prefix + "MaintainStateId", this.MaintainStateId);
            this.SetParamSimple(map, prefix + "OperatorStateId", this.OperatorStateId);
            this.SetParamSimple(map, prefix + "HealthStateId", this.HealthStateId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "NodeTypeName", this.NodeTypeName);
            this.SetParamSimple(map, prefix + "DataNodeMaintenanceId", this.DataNodeMaintenanceId);
            this.SetParamArrayObj(map, prefix + "SearchFields.", this.SearchFields);
        }
    }
}

