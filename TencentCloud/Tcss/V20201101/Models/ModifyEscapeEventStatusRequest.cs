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

    public class ModifyEscapeEventStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 处理事件ids
        /// </summary>
        [JsonProperty("EventIdSet")]
        public string[] EventIdSet{ get; set; }

        /// <summary>
        /// 标记事件的状态：
        /// EVENT_UNDEAL:未处理（取消忽略），
        /// EVENT_DEALED:已处理，
        /// EVENT_IGNORE:忽略，
        /// EVENT_DELETE：已删除
        /// EVENT_ADD_WHITE：加白
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 加白镜像ID数组
        /// </summary>
        [JsonProperty("ImageIDs")]
        public string[] ImageIDs{ get; set; }

        /// <summary>
        /// 加白事件类型
        ///    ESCAPE_CGROUPS：利用cgroup机制逃逸
        ///    ESCAPE_TAMPER_SENSITIVE_FILE：篡改敏感文件逃逸
        ///    ESCAPE_DOCKER_API：访问Docker API接口逃逸
        ///    ESCAPE_VUL_OCCURRED：逃逸漏洞利用
        ///    MOUNT_SENSITIVE_PTAH：敏感路径挂载
        ///    PRIVILEGE_CONTAINER_START：特权容器
        ///    PRIVILEGE：程序提权逃逸
        /// </summary>
        [JsonProperty("EventType")]
        public string[] EventType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EventIdSet.", this.EventIdSet);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "ImageIDs.", this.ImageIDs);
            this.SetParamArraySimple(map, prefix + "EventType.", this.EventType);
        }
    }
}

