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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportAppMessageRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作空间Id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public long? WorkspaceId{ get; set; }

        /// <summary>
        /// 消息定义
        /// </summary>
        [JsonProperty("Profile")]
        public MessageProfile Profile{ get; set; }

        /// <summary>
        /// 数据上报时间
        /// </summary>
        [JsonProperty("ReportTs")]
        public long? ReportTs{ get; set; }

        /// <summary>
        /// 属性定义 - KV的json格式,有效字段为x-json:后的字段
        /// </summary>
        [JsonProperty("Properties")]
        public string Properties{ get; set; }

        /// <summary>
        /// 应用token
        /// </summary>
        [JsonProperty("ApplicationToken")]
        public string ApplicationToken{ get; set; }

        /// <summary>
        /// 事件定义 - KKV的json格式,有效字段为x-json:后的字段
        /// </summary>
        [JsonProperty("EventSet")]
        public string EventSet{ get; set; }

        /// <summary>
        /// 服务定义 - KKV的json格式,有效字段为x-json:后的字段
        /// </summary>
        [JsonProperty("ServiceSet")]
        public string ServiceSet{ get; set; }

        /// <summary>
        /// 扩展字段2，如：算法上报id，若为json格式，需传x-json:{}，有效字段为x-json:后的字段
        /// </summary>
        [JsonProperty("ExtendTwo")]
        public string ExtendTwo{ get; set; }

        /// <summary>
        /// 透传信息，若为json格式，需传x-json:{}，有效字段为x-json:后的字段
        /// </summary>
        [JsonProperty("Echo")]
        public string Echo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "ReportTs", this.ReportTs);
            this.SetParamSimple(map, prefix + "Properties", this.Properties);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamSimple(map, prefix + "EventSet", this.EventSet);
            this.SetParamSimple(map, prefix + "ServiceSet", this.ServiceSet);
            this.SetParamSimple(map, prefix + "ExtendTwo", this.ExtendTwo);
            this.SetParamSimple(map, prefix + "Echo", this.Echo);
        }
    }
}

