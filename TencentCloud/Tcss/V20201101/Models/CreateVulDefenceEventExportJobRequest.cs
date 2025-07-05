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

    public class CreateVulDefenceEventExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>Status- String - 是否必填：否 - 插件状态，待处理：EVENT_UNDEAL，EVENT_DEALED：已处理，已忽略：EVENT_IGNORE， EVENT_DEFENDED：已防御</li>
        /// <li>ContainerStatus- String - 是否必填：否 - 容器运行状态筛选，已创建：CREATED,正常运行：RUNNING, 暂定运行：PAUSED, 停止运行：	STOPPED，重启中：RESTARTING, 迁移中：REMOVING, 销毁：DESTROYED </li>
        /// <li>ContainerNetStatus- String -是否必填: 否 -  容器网络状态筛选 未隔离：NORMAL，已隔离：ISOLATED，隔离失败：ISOLATE_FAILED，解除隔离失败：RESTORE_FAILED，解除隔离中：RESTORING，隔离中：ISOLATING</li>
        /// <li>EventType - String -是否必填: 否 -  入侵状态，防御成功：EVENT_DEFENDED，尝试攻击：EVENT_ATTACK </li>
        /// <li>TimeRange- String -是否必填: 否 -  时间范围，第一个值表示开始时间，第二个值表示结束时间 </li>
        /// <li>VulName- string - 是否必填：否 - 漏洞名称。</li>
        /// <li>CVEID- string - 是否必填：否 - CVE编号。</li>
        /// <li>SourceIP- string - 是否必填：否 - 攻击源IP。</li>
        /// <li>ContainerName- string - 是否必填：否 - 容器名称。</li>
        /// <li>ContainerID- string - 是否必填：否 - 容器ID。</li>
        /// <li>ImageName- string - 是否必填：否 - 镜像名称。</li>
        /// <li>ImageID- string - 是否必填：否 - 镜像ID。</li>
        /// <li>HostName- string - 是否必填：否 - 主机名称。</li>
        /// <li>HostIP- string - 是否必填：否 - 内网IP。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// 需要返回的数量，最大值为100000
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 排序方式：asc/desc
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段：事件数量：EventCount
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

