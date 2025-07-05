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

    public class DescribeCanNotSeparateMachineRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要修改的事件id 数组，支持批量
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// 是否更新全部，即是否对所有的事件进行操作，当ids 不为空时，此参数无效
        /// </summary>
        [JsonProperty("UpdateAll")]
        public bool? UpdateAll{ get; set; }

        /// <summary>
        /// 排除的事件id,当操作全部事件时，需要排除这次id
        /// </summary>
        [JsonProperty("ExcludeId")]
        public ulong?[] ExcludeId{ get; set; }

        /// <summary>
        /// <li>IpOrAlias - String - 是否必填：否 - 主机ip或别名筛选</li>
        /// <li>FilePath - String - 是否必填：否 - 路径筛选</li>
        /// <li>VirusName - String - 是否必填：否 - 描述筛选</li>
        /// <li>CreateBeginTime - String - 是否必填：否 - 创建时间筛选-开始时间</li>
        /// <li>CreateEndTime - String - 是否必填：否 - 创建时间筛选-结束时间</li>
        /// <li>Status - String - 是否必填：否 - 状态筛选 4待处理,5信任,6已隔离,10隔离中,11恢复隔离中</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "UpdateAll", this.UpdateAll);
            this.SetParamArraySimple(map, prefix + "ExcludeId.", this.ExcludeId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

