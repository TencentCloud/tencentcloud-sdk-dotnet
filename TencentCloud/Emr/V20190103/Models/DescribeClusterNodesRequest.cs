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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterNodesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群实例ID,实例ID形如: emr-xxxxxxxx
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 节点标识，取值为：
        /// <li>all：表示获取全部类型节点，cdb信息除外。</li>
        /// <li>master：表示获取master节点信息。</li>
        /// <li>core：表示获取core节点信息。</li>
        /// <li>task：表示获取task节点信息。</li>
        /// <li>common：表示获取common节点信息。</li>
        /// <li>router：表示获取router节点信息。</li>
        /// <li>db：表示获取正常状态的cdb信息。</li>
        /// <li>recyle：表示获取回收站隔离中的节点信息，包括cdb信息。</li>
        /// <li>renew：表示获取所有待续费的节点信息，包括cdb信息，自动续费节点不会返回。</li>
        /// 注意：现在只支持以上取值，输入其他值会导致错误。
        /// </summary>
        [JsonProperty("NodeFlag")]
        public string NodeFlag{ get; set; }

        /// <summary>
        /// 导出全部节点信息csv时是否携带cdb信息
        /// </summary>
        [JsonProperty("ExportDb")]
        public bool? ExportDb{ get; set; }

        /// <summary>
        /// 页编号，默认值为0，表示第一页。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 每页返回数量，默认值为100，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 资源类型:支持all/host/pod，默认为all
        /// </summary>
        [JsonProperty("HardwareResourceType")]
        public string HardwareResourceType{ get; set; }

        /// <summary>
        /// 支持搜索的字段
        /// </summary>
        [JsonProperty("SearchFields")]
        public SearchItem[] SearchFields{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Asc")]
        public long? Asc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NodeFlag", this.NodeFlag);
            this.SetParamSimple(map, prefix + "ExportDb", this.ExportDb);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "HardwareResourceType", this.HardwareResourceType);
            this.SetParamArrayObj(map, prefix + "SearchFields.", this.SearchFields);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Asc", this.Asc);
        }
    }
}

