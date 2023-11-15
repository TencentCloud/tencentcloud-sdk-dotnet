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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmListRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警开始时间，必填,时间戳秒
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// 告警结束时间，必填，时间戳秒
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 分页查询，第几页
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 工作空间id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 应用token
        /// </summary>
        [JsonProperty("ApplicationToken")]
        public string ApplicationToken{ get; set; }

        /// <summary>
        /// 告警状态
        /// </summary>
        [JsonProperty("Statuses")]
        public string[] Statuses{ get; set; }

        /// <summary>
        /// 告警类型
        /// </summary>
        [JsonProperty("AlarmTypeSet")]
        public AlarmTypeInfo[] AlarmTypeSet{ get; set; }

        /// <summary>
        /// 告警级别id
        /// </summary>
        [JsonProperty("LevelSet")]
        public long?[] LevelSet{ get; set; }

        /// <summary>
        /// 告警id
        /// </summary>
        [JsonProperty("IdSet")]
        public string[] IdSet{ get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("AppIdSet")]
        public long?[] AppIdSet{ get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("WIDSet")]
        public string[] WIDSet{ get; set; }

        /// <summary>
        /// 空间层级
        /// </summary>
        [JsonProperty("SpaceCodeSet")]
        public string[] SpaceCodeSet{ get; set; }

        /// <summary>
        /// 应用扩展字段1
        /// </summary>
        [JsonProperty("ExtendOne")]
        public string[] ExtendOne{ get; set; }

        /// <summary>
        /// 应用扩展字段2
        /// </summary>
        [JsonProperty("ExtendTwo")]
        public string[] ExtendTwo{ get; set; }

        /// <summary>
        /// 当前告警处理人，填孪生中台的用户id
        /// </summary>
        [JsonProperty("ProcessorSet")]
        public string[] ProcessorSet{ get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        [JsonProperty("GroupIdSet")]
        public long?[] GroupIdSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamArraySimple(map, prefix + "Statuses.", this.Statuses);
            this.SetParamArrayObj(map, prefix + "AlarmTypeSet.", this.AlarmTypeSet);
            this.SetParamArraySimple(map, prefix + "LevelSet.", this.LevelSet);
            this.SetParamArraySimple(map, prefix + "IdSet.", this.IdSet);
            this.SetParamArraySimple(map, prefix + "AppIdSet.", this.AppIdSet);
            this.SetParamArraySimple(map, prefix + "WIDSet.", this.WIDSet);
            this.SetParamArraySimple(map, prefix + "SpaceCodeSet.", this.SpaceCodeSet);
            this.SetParamArraySimple(map, prefix + "ExtendOne.", this.ExtendOne);
            this.SetParamArraySimple(map, prefix + "ExtendTwo.", this.ExtendTwo);
            this.SetParamArraySimple(map, prefix + "ProcessorSet.", this.ProcessorSet);
            this.SetParamArraySimple(map, prefix + "GroupIdSet.", this.GroupIdSet);
        }
    }
}

