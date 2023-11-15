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

    public class ChangeAlarmStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警的id，返回的列表中的id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 告警状态 processed unprocessed processing misreport shield
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 告警处理时间
        /// </summary>
        [JsonProperty("ProcessTime")]
        public long? ProcessTime{ get; set; }

        /// <summary>
        /// 处理类型
        /// </summary>
        [JsonProperty("ProcessType")]
        public string ProcessType{ get; set; }

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
        /// 平台告警处理人
        /// </summary>
        [JsonProperty("Processor")]
        public string Processor{ get; set; }

        /// <summary>
        /// 告警处理的描述信息
        /// </summary>
        [JsonProperty("ProcessDescription")]
        public string ProcessDescription{ get; set; }

        /// <summary>
        /// 告警处理的扩展信息，可以为JSON字符串
        /// </summary>
        [JsonProperty("ProcessExtend")]
        public string ProcessExtend{ get; set; }

        /// <summary>
        /// 扩展字段1，目前存的应用告警处理人
        /// </summary>
        [JsonProperty("ExtendOne")]
        public string ExtendOne{ get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public long? ApplicationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProcessTime", this.ProcessTime);
            this.SetParamSimple(map, prefix + "ProcessType", this.ProcessType);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamSimple(map, prefix + "Processor", this.Processor);
            this.SetParamSimple(map, prefix + "ProcessDescription", this.ProcessDescription);
            this.SetParamSimple(map, prefix + "ProcessExtend", this.ProcessExtend);
            this.SetParamSimple(map, prefix + "ExtendOne", this.ExtendOne);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
        }
    }
}

