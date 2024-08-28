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

    public class DescribeHostLoginListRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要返回的数量，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件。<li>Quuid - String - 是否必填：否 - 云服务器uuid</li><li>Uuid - String - 是否必填：否 - 主机安全唯一Uuid</li><li>MachineName - String - 是否必填：否 - 主机别名</li><li>Ip - String - 是否必填：否 - 主机ip</li><li>InstanceID - String - 是否必填：否 - 主机实例ID</li><li>SrcIp - String - 是否必填：否 - 来源ip筛选</li><li>UserName - String - 是否必填：否 - 用户名筛选</li><li>Status - string - 是否必填：否 - 状态筛选1:正常登录；5：已加白,14:已处理，15：已忽略</li><li>LoginTimeBegin - String - 是否必填：否 - 按照修改时间段筛选，开始时间</li><li>LoginTimeEnd - String - 是否必填：否 - 按照修改时间段筛选，结束时间</li><li>RiskLevel - string - 是否必填：否 - 状态筛选0:高危；1：可疑</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序方式：根据请求次数排序：asc-升序/desc-降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段：LoginTime-发生时间
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

