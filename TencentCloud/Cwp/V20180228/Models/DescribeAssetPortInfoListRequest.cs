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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetPortInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询指定Quuid主机的信息
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>Port - uint64 - 是否必填：否 - 端口</li>
        /// <li>IP - String - 是否必填：否 - 主机ip</li>
        /// <li>MachineName - String - 是否必填：否 - 主机名称</li>
        /// <li>InstanceID - string - 是否必填：否 - 实例ID</li>
        /// <li>ProcessName - String - 是否必填：否 - 监听进程</li>
        /// <li>Pid - uint64 - 是否必填：否 - PID</li>
        /// <li>User - String - 是否必填：否 - 运行用户</li>
        /// <li>Group - String - 是否必填：否 - 所属用户组</li>
        /// <li>Ppid - uint64 - 是否必填：否 - PPID</li>
        /// <li>Proto - string - 是否必填：否 - tcp/udp或“”(空字符串筛选未知状态)</li>
        /// <li>OsType - uint64 - 是否必填：否 - windows/linux</li>
        /// <li>RunTimeStart - String - 是否必填：否 - 运行开始时间</li>
        /// <li>RunTimeEnd - String - 是否必填：否 - 运行结束时间</li>
        /// <li>Os -String 是否必填: 否 - 操作系统( DescribeMachineOsList 接口 值 )</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 需要返回的数量，默认为10，最大值为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 排序方式，asc升序 或 desc降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序方式：[FirstTime|StartTime]
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

