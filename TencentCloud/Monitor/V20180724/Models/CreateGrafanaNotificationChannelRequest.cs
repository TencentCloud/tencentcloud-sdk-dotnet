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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGrafanaNotificationChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// Grafana 实例 ID，例如：grafana-abcdefgh
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 告警通道名称，例如：test
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 接受告警通道 ID 数组，值为告警管理/基础配置/通知模板中的模板 ID 
        /// </summary>
        [JsonProperty("Receivers")]
        public string[] Receivers{ get; set; }

        /// <summary>
        /// 默认为1，建议使用 OrganizationIds
        /// </summary>
        [JsonProperty("OrgId")]
        public long? OrgId{ get; set; }

        /// <summary>
        /// 额外组织 ID 数组，已废弃，请使用 OrganizationIds
        /// </summary>
        [JsonProperty("ExtraOrgIds")]
        public string[] ExtraOrgIds{ get; set; }

        /// <summary>
        /// 生效的所有组织 ID 数组，默认为 ["1"]
        /// </summary>
        [JsonProperty("OrganizationIds")]
        public string[] OrganizationIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamArraySimple(map, prefix + "Receivers.", this.Receivers);
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamArraySimple(map, prefix + "ExtraOrgIds.", this.ExtraOrgIds);
            this.SetParamArraySimple(map, prefix + "OrganizationIds.", this.OrganizationIds);
        }
    }
}

