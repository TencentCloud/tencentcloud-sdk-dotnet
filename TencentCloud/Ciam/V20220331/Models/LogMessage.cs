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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogMessage : AbstractModel
    {
        
        /// <summary>
        /// 日志标识
        /// </summary>
        [JsonProperty("LogId")]
        public string LogId{ get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 用户池ID
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// 事件编码
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// 事件发生时间戳，单位：毫秒
        /// </summary>
        [JsonProperty("EventDate")]
        public long? EventDate{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 事件参与者
        /// 
        /// <li> **TENANT** </li>  租户
        /// <li> **USER** </li>  用户
        /// </summary>
        [JsonProperty("Participant")]
        public string Participant{ get; set; }

        /// <summary>
        /// 应用clientId
        /// </summary>
        [JsonProperty("ApplicationClientId")]
        public string ApplicationClientId{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 认证源ID
        /// </summary>
        [JsonProperty("AuthSourceId")]
        public string AuthSourceId{ get; set; }

        /// <summary>
        /// 认证源名称
        /// </summary>
        [JsonProperty("AuthSourceName")]
        public string AuthSourceName{ get; set; }

        /// <summary>
        /// 认证源类型
        /// </summary>
        [JsonProperty("AuthSourceType")]
        public string AuthSourceType{ get; set; }

        /// <summary>
        /// 认证源类别
        /// </summary>
        [JsonProperty("AuthSourceCategory")]
        public string AuthSourceCategory{ get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 用户代理
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 日志结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionResult")]
        public string ActionResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamSimple(map, prefix + "EventDate", this.EventDate);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Participant", this.Participant);
            this.SetParamSimple(map, prefix + "ApplicationClientId", this.ApplicationClientId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "AuthSourceId", this.AuthSourceId);
            this.SetParamSimple(map, prefix + "AuthSourceName", this.AuthSourceName);
            this.SetParamSimple(map, prefix + "AuthSourceType", this.AuthSourceType);
            this.SetParamSimple(map, prefix + "AuthSourceCategory", this.AuthSourceCategory);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "ActionResult", this.ActionResult);
        }
    }
}

