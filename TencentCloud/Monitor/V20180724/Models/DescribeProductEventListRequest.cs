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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProductEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// 接口模块名，固定值"monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 产品类型过滤，比如"cvm"表示云服务器
        /// </summary>
        [JsonProperty("ProductName")]
        public string[] ProductName{ get; set; }

        /// <summary>
        /// 事件名称过滤，比如"guest_reboot"表示机器重启
        /// </summary>
        [JsonProperty("EventName")]
        public string[] EventName{ get; set; }

        /// <summary>
        /// 影响对象，比如ins-19708ino
        /// </summary>
        [JsonProperty("InstanceId")]
        public string[] InstanceId{ get; set; }

        /// <summary>
        /// 维度过滤，比如外网IP:10.0.0.1
        /// </summary>
        [JsonProperty("Dimensions")]
        public DescribeProductEventListDimensions[] Dimensions{ get; set; }

        /// <summary>
        /// 地域过滤，比如gz
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

        /// <summary>
        /// 事件类型过滤，取值范围["status_change","abnormal"]，分别表示状态变更、异常事件
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// 事件状态过滤，取值范围["recover","alarm","-"]，分别表示已恢复、未恢复、无状态
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// 项目ID过滤
        /// </summary>
        [JsonProperty("Project")]
        public string[] Project{ get; set; }

        /// <summary>
        /// 告警状态配置过滤，1表示已配置，0表示未配置
        /// </summary>
        [JsonProperty("IsAlarmConfig")]
        public long? IsAlarmConfig{ get; set; }

        /// <summary>
        /// 按更新时间排序，ASC表示升序，DESC表示降序，默认DESC
        /// </summary>
        [JsonProperty("TimeOrder")]
        public string TimeOrder{ get; set; }

        /// <summary>
        /// 起始时间，默认一天前的时间戳
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间，默认当前时间戳
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 页偏移量，默认0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 每页返回的数量，默认20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamArraySimple(map, prefix + "ProductName.", this.ProductName);
            this.SetParamArraySimple(map, prefix + "EventName.", this.EventName);
            this.SetParamArraySimple(map, prefix + "InstanceId.", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "Project.", this.Project);
            this.SetParamSimple(map, prefix + "IsAlarmConfig", this.IsAlarmConfig);
            this.SetParamSimple(map, prefix + "TimeOrder", this.TimeOrder);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

