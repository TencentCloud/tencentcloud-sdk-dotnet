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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpTraceLogEntry : AbstractModel
    {
        
        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// 访问IP
        /// </summary>
        [JsonProperty("RemoteIp")]
        public string RemoteIp{ get; set; }

        /// <summary>
        /// 溯源类型rsp/req
        /// </summary>
        [JsonProperty("TraceType")]
        public string TraceType{ get; set; }

        /// <summary>
        /// 访问网络类型，公网/私网
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 原始消息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 访问uri
        /// </summary>
        [JsonProperty("Uri")]
        public string Uri{ get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 请求类型或返回状态
        /// </summary>
        [JsonProperty("ReqTypeOrRspStatus")]
        public string ReqTypeOrRspStatus{ get; set; }

        /// <summary>
        /// 集群节点IP
        /// </summary>
        [JsonProperty("NodeIp")]
        public string NodeIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "RemoteIp", this.RemoteIp);
            this.SetParamSimple(map, prefix + "TraceType", this.TraceType);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Uri", this.Uri);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "ReqTypeOrRspStatus", this.ReqTypeOrRspStatus);
            this.SetParamSimple(map, prefix + "NodeIp", this.NodeIp);
        }
    }
}

