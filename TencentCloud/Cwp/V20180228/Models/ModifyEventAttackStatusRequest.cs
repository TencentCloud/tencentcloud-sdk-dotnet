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

    public class ModifyEventAttackStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要修改的事件id 数组，支持批量
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// 是否更新全部，即是否对所有的事件进行操作，当ids 不为空时，此参数无效
        /// </summary>
        [JsonProperty("All")]
        public bool? All{ get; set; }

        /// <summary>
        /// 0：待处理 1：已处理 3： 已忽略 4：已删除 
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>Type - String 攻击状态 0: 尝试攻击 1: 攻击成功 - 是否必填: 否</li>
        /// <li>Status - String 事件处理状态 0：待处理 1：已处理 2： 已加白 3： 已忽略 4：已删除  - 是否必填: 否</li>
        /// <li>SrcIP - String 来源IP - 是否必填: 否</li>
        /// <li>DstPort - String 攻击目标端口 - 是否必填: 否</li>
        /// <li>MachineName - String 主机名称 - 是否必填: 否</li>
        /// <li>InstanceID - String 主机实例ID - 是否必填: 否</li>
        /// <li>Quuids - String 主机cvm uuid - 是否必填: 否</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// 排除的id
        /// </summary>
        [JsonProperty("ExcludeId")]
        public ulong?[] ExcludeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "ExcludeId.", this.ExcludeId);
        }
    }
}

