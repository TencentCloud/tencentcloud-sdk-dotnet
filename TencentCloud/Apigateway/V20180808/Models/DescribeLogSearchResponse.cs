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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogSearchResponse : AbstractModel
    {
        
        /// <summary>
        /// 获取更多检索结果的游标，值为""表示无后续结果
        /// </summary>
        [JsonProperty("ConText")]
        public string ConText{ get; set; }

        /// <summary>
        /// 由0或多条日志组成，每条日志格式如下：
        /// '[$app_id][$env_name][$service_id][$http_host][$api_id][$uri][$scheme][rsp_st:$status][ups_st:$upstream_status]'
        /// '[cip:$remote_addr][uip:$upstream_addr][vip:$server_addr][rsp_len:$bytes_sent][req_len:$request_length]'
        /// '[req_t:$request_time][ups_rsp_t:$upstream_response_time][ups_conn_t:$upstream_connect_time][ups_head_t:$upstream_header_time]’
        /// '[err_msg:$err_msg][tcp_rtt:$tcpinfo_rtt][$pid][$time_local][req_id:$request_id]';
        /// 
        /// 说明：
        /// app_id： 用户 ID。
        /// env_name：环境名称。
        /// service_id： 服务 ID。
        /// http_host： 域名。
        /// api_id： API 的 ID。
        /// uri：请求的路径。
        /// scheme： HTTP/HTTPS 协议。
        /// rsp_st： 请求响应状态码。
        /// ups_st： 后端业务服务器的响应状态码（如果请求透传到后端，改变量不为空。如果请求在 APIGW 就被拦截了，那么该变量显示为 -）。
        /// cip： 客户端 IP。
        /// uip： 后端业务服务（upstream）的 IP。
        /// vip： 请求访问的 VIP。
        /// rsp_len： 响应长度。
        /// req_len： 请求长度。
        /// req_t： 请求响应的总时间。
        /// ups_rsp_t： 后端响应的总时间（apigw 建立连接到接收到后端响应的时间）。
        /// ups_conn_t: 与后端业务服务器连接建立成功时间。
        /// ups_head_t：后端响应的头部到达时间。
        /// err_msg： 错误信息。
        /// tcp_rtt： 客户端 TCP 连接信息，RTT（Round Trip Time）由三部分组成：链路的传播时间（propagation delay）、末端系统的处理时间、路由器缓存中的排队和处理时间（queuing delay）。
        /// req_id：请求id。
        /// </summary>
        [JsonProperty("LogSet")]
        public string[] LogSet{ get; set; }

        /// <summary>
        /// 单次搜索返回的日志条数，TotalCount <= Limit
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConText", this.ConText);
            this.SetParamArraySimple(map, prefix + "LogSet.", this.LogSet);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

