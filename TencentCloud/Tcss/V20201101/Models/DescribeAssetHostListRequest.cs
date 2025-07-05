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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetHostListRequest : AbstractModel
    {
        
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
        /// 过滤条件。<li>Status-String-是否必填：否-agent状态筛选，"ALL": "全部"(或不传该字段), "UNINSTALL"："未安装", "OFFLINE"："离线", "ONLINE"："防护中"</li><li>HostName-String-是否必填：否-主机名筛选</li><li>Group-String-是否必填：否-主机群组搜索</li><li>HostIP-string-是否必填：否-主机ip搜索</li><li>HostID-string-是否必填：否-主机id搜索</li><li>DockerVersion-string-是否必填：否-docker版本搜索</li><li>MachineType-string-是否必填：否-主机来源MachineType搜索，"ALL": "全部"(或不传该字段), 主机来源：[     "CVM",     "ECM",     "LH",     "BM" ]中的之一为腾讯云服务器；[     "Other" ]之一非腾讯云服务器；</li><li>DockerStatus-string-是否必填：否-docker安装状态，"ALL": "全部"(或不传该字段), "INSTALL": "已安装", "UNINSTALL": "未安装"</li><li>ProjectID-string-是否必填：否-所属项目id搜索</li><li>Tag:(tag: key)-string-是否必填：否-标签键值搜索示例Filters":[{"Name":"tag: tke-kind","Values":["service"]}]</li> <li>NonClusterNode: 是否查询非集群节点(true: 是,false: 否)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 排序方式 asc,desc
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

