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

    public class DescribeVulListRequest : AbstractModel
    {
        
        /// <summary>
        /// 返回数量，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>IfEmergency - String - 是否必填：否 - 是否为应急漏洞，查询应急漏洞传:yes</li>
        /// <li>Status - String - 是否必填：是 - 漏洞状态筛选，0: 待处理 1:忽略  3:已修复  5:检测中，6：修复中 控制台仅处理0,1,3,5,6五种状态</li>
        /// <li>Level - String - 是否必填：否 - 漏洞等级筛选 1:低 2:中 3:高 4:提示</li>
        /// <li>VulName- String - 是否必填：否 - 漏洞名称搜索</li>
        /// <li>LastDay- int - 是否必填：否 - 查询近几日的数据，需要 -1 之后传入，例如近3日数据，传2</li>
        /// <li>OrderBy - String 是否必填：否 默认按照处理状态,威胁等级,检测时间排序 -排序字段，支持：level,lastTime的动态排序  hostCount 影响主机台数排序</li>
        /// <li>IsShowFollowVul -  String 是否必填：否   是否仅展示重点关注漏洞  0=展示全部 1=仅展示重点关注漏洞</li>
        /// <li>VulCategory-  String 是否必填：否   1: web应用漏洞 2:系统组件漏洞3:安全基线 4: Linux系统漏洞 5: windows补丁</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

