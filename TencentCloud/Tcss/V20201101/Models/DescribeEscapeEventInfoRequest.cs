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

    public class DescribeEscapeEventInfoRequest : AbstractModel
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
        /// 过滤参数,
        /// Status：状态(EVENT_UNDEAL:未处理，EVENT_DEALED:已处理，EVENT_INGNORE:忽略)
        /// EventType: 事件类型(MOUNT_SENSITIVE_PTAH:敏感路径挂载 PRIVILEGE_CONTAINER_START:特权容器 PRIVILEGE:提权事件 
        ///     ESCAPE_VUL_OCCURRED:逃逸漏洞利用 ESCAPE_DOCKER_API:访问Docker API接口逃逸 ESCAPE_TAMPER_SENSITIVE_FILE:篡改敏感文件逃逸 ESCAPE_CGROUPS:利用cgroup机制逃逸)
        /// ContainerNetStatus: 容器隔离状态 (NORMAL:正常 ISOLATED:已隔离 ISOLATE_FAILED:隔离失败 ISOLATE_FAILED:解除隔离失败 RESTORING:解除隔离中 ISOLATING:隔离中)
        /// ContainerStatus: 容器状态(CREATED:已创建 RUNNING:正常运行 PAUSED:暂停运行 STOPPED:停止运行 RESTARTING:重启中 REMOVING:迁移中 DEAD:DEAD UNKNOWN：未知 DESTROYED:已销毁)
        /// ForeignUniqueKey:镜像ID及事件类型唯一值
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// 升序降序,asc desc
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段
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

