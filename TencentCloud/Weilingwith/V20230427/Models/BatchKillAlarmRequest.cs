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

    public class BatchKillAlarmRequest : AbstractModel
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
        /// 告警状态: unprocessed processing
        /// </summary>
        [JsonProperty("StatusSet")]
        public string[] StatusSet{ get; set; }

        /// <summary>
        /// 工作空间id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 当前操作用户id
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 当前操作用户名称
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 应用token
        /// </summary>
        [JsonProperty("ApplicationToken")]
        public string ApplicationToken{ get; set; }

        /// <summary>
        /// 当前告警处理人，填孪生中台用户id,多个用逗号分隔
        /// </summary>
        [JsonProperty("ProcessorId")]
        public string ProcessorId{ get; set; }

        /// <summary>
        /// 告警子类型(如果传告警子类型，则必传父类型)
        /// </summary>
        [JsonProperty("AlarmTypeSet")]
        public AlarmTypeInfo[] AlarmTypeSet{ get; set; }

        /// <summary>
        /// 告警级别,包括1~5
        /// </summary>
        [JsonProperty("LevelSet")]
        public long?[] LevelSet{ get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("WIDSet")]
        public string[] WIDSet{ get; set; }

        /// <summary>
        /// 告警id
        /// </summary>
        [JsonProperty("IdSet")]
        public string[] IdSet{ get; set; }

        /// <summary>
        /// 告警处理的说明
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "StatusSet.", this.StatusSet);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamSimple(map, prefix + "ProcessorId", this.ProcessorId);
            this.SetParamArrayObj(map, prefix + "AlarmTypeSet.", this.AlarmTypeSet);
            this.SetParamArraySimple(map, prefix + "LevelSet.", this.LevelSet);
            this.SetParamArraySimple(map, prefix + "WIDSet.", this.WIDSet);
            this.SetParamArraySimple(map, prefix + "IdSet.", this.IdSet);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
        }
    }
}

