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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGlobalAcceleratorAccessLogRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>GA示例唯一Id</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>监听器Id</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>终端节点组Id</p>
        /// </summary>
        [JsonProperty("EndpointGroupId")]
        public string EndpointGroupId{ get; set; }

        /// <summary>
        /// <p>日志集所在地域</p>
        /// </summary>
        [JsonProperty("CloudRegion")]
        public string CloudRegion{ get; set; }

        /// <summary>
        /// <p>日志主题Id</p>
        /// </summary>
        [JsonProperty("CloudLogId")]
        public string CloudLogId{ get; set; }

        /// <summary>
        /// <p>日志集Id</p>
        /// </summary>
        [JsonProperty("CloudLogSetId")]
        public string CloudLogSetId{ get; set; }

        /// <summary>
        /// <p>指定采集字段</p><p>枚举值：</p><ul><li>session_time： 四层，会话持续时间</li><li>upstream_bytes_received： 四层、七层，从终端节点接收的字节数</li><li>upstream_bytes_sent： 四层、七层，发送给终端节点的字节数</li><li>request_method： 七层，GET/POST</li><li>scheme： 七层，http/https</li><li>request_uri： 七层，客户端原始请求的URI</li><li>uri： 七层，当前请求的URI</li><li>host： 七层，客户端访问域名（七层）</li><li>remote_user： 七层，基本认证时的用户名（未认证时为&quot;-&quot;）</li><li>http_user_agent： 七层，客户端浏览器标识</li><li>http_referer： 七层，请求来源URL（直接从地址栏访问时为&quot;-&quot;）</li><li>http_x_forwarded_for： 七层，记录客户端原始IP及经过的代理服务器IP链</li><li>content_type： 七层，content_type</li><li>body_bytes_sent： 七层，发送给客户端的http body大小，不包含header</li><li>request_time： 七层，从接收到客户端请求的第一个字节到发送完响应最后一个字节之间的总时间（单位：秒）</li><li>sent_http_content_type： 七层，响应内容类型</li><li>upstream_header_time： 七层，终端节点的响应头到达时间</li><li>upstream_response_length： 七层，终端节点返回的响应体长度</li><li>upstream_response_time： 七层，终端节点完整响应时间</li><li>upstream_status： 七层，终端节点返回的HTTP状态码</li></ul>
        /// </summary>
        [JsonProperty("FieldKeys")]
        public string[] FieldKeys{ get; set; }

        /// <summary>
        /// <p>日志描述</p>
        /// </summary>
        [JsonProperty("FlowLogDescription")]
        public string FlowLogDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "EndpointGroupId", this.EndpointGroupId);
            this.SetParamSimple(map, prefix + "CloudRegion", this.CloudRegion);
            this.SetParamSimple(map, prefix + "CloudLogId", this.CloudLogId);
            this.SetParamSimple(map, prefix + "CloudLogSetId", this.CloudLogSetId);
            this.SetParamArraySimple(map, prefix + "FieldKeys.", this.FieldKeys);
            this.SetParamSimple(map, prefix + "FlowLogDescription", this.FlowLogDescription);
        }
    }
}

