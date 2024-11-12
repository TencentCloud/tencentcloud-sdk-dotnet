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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRiskDnsEventListRequest : AbstractModel
    {
        
        /// <summary>
        /// <li>MachineName  主机名称
        /// 
        /// 
        /// 
        /// InstanceID  实例ID  
        /// 
        ///  
        /// 
        /// IP   内网IP或公网IP- 是否必填：否 - 主机Ip或别名筛选</li>
        /// <li>HostId - String - 是否必填：否 - 主机Id</li>
        /// <li>AgentId - String - 是否必填：否 - 客户端Id</li>
        /// <li>PolicyType - String - 是否必填：否 - 策略类型,0:系统策略1:用户自定义策略</li>
        /// <li>Domain - String - 是否必填：否 - 域名(先对域名做urlencode,再base64)</li>
        /// <li>HandleStatus - String - 是否必填：否 - 状态筛选0:待处理；2:信任；3:不信任</li>
        /// <li>BeginTime - String - 是否必填：否 - 最近访问开始时间</li>
        /// <li>EndTime - String - 是否必填：否 - 最近访问结束时间</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 需要返回的数量，默认为10，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序方式：根据请求次数排序：[asc:升序|desc:降序]
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段：[AccessCount:请求次数|LastTime:最近请求时间]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

