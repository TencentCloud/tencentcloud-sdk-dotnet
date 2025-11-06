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

    public class QueryIpTraceLogRequest : AbstractModel
    {
        
        /// <summary>
        /// ES集群ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 起始偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 数据条数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 访问IP
        /// </summary>
        [JsonProperty("RemoteIp")]
        public string[] RemoteIp{ get; set; }

        /// <summary>
        /// Request/Response 请求/返回, 非必填
        /// </summary>
        [JsonProperty("TraceType")]
        public string[] TraceType{ get; set; }

        /// <summary>
        /// Public/Private 公网访问/内网访问, 非必填
        /// </summary>
        [JsonProperty("NetType")]
        public string[] NetType{ get; set; }

        /// <summary>
        /// POST/GET/PUT/DELETE/HEAD/OPTIONS/PATCH/CONNECT/TRACE/CONNECT等, 非必填
        /// </summary>
        [JsonProperty("ReqTypeOrRspStatus")]
        public string[] ReqTypeOrRspStatus{ get; set; }

        /// <summary>
        /// 关键字模糊查询，支持Lucene Query String
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Uri搜索
        /// </summary>
        [JsonProperty("Uri")]
        public string Uri{ get; set; }

        /// <summary>
        /// 集群节点IP
        /// </summary>
        [JsonProperty("NodeIp")]
        public string[] NodeIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "RemoteIp.", this.RemoteIp);
            this.SetParamArraySimple(map, prefix + "TraceType.", this.TraceType);
            this.SetParamArraySimple(map, prefix + "NetType.", this.NetType);
            this.SetParamArraySimple(map, prefix + "ReqTypeOrRspStatus.", this.ReqTypeOrRspStatus);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamSimple(map, prefix + "Uri", this.Uri);
            this.SetParamArraySimple(map, prefix + "NodeIp.", this.NodeIp);
        }
    }
}

