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

    public class DescribeTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// 云主机类型。
        /// <li>CVM：表示云服务器</li>
        /// <li>BM:  表示黑石物理机</li>
        /// <li>ECM:  表示边缘计算服务器</li>
        /// <li>LH:  表示轻量应用服务器</li>
        /// <li>Other:  表示混合云服务器</li>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 机器所属地域。如：ap-guangzhou
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>Keywords - String - 是否必填：否 - 查询关键字(机器名称/机器IP </li>
        /// <li>Status - String - 是否必填：否 - 客户端在线状态（OFFLINE: 离线 | ONLINE: 在线 | UNINSTALLED：未安装 | SHUTDOWN 已关机）</li>
        /// <li>Version - String  是否必填：否 - 当前防护版本（ PRO_VERSION：专业版 | BASIC_VERSION：基础版）</li>
        /// <li>Risk - String 是否必填: 否 - 风险主机( yes ) </li>
        /// <li>Os -String 是否必填: 否 - 操作系统( DescribeMachineOsList 接口 值 )
        /// 每个过滤条件只支持一个值，暂不支持多个值“或”关系查询</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MachineRegion", this.MachineRegion);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

