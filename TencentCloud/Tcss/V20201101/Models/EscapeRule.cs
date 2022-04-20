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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EscapeRule : AbstractModel
    {
        
        /// <summary>
        /// 规则类型   
        /// ESCAPE_HOST_ACESS_FILE:宿主机文件访问逃逸
        ///    ESCAPE_MOUNT_NAMESPACE:MountNamespace逃逸
        ///    ESCAPE_PRIVILEDGE:程序提权逃逸
        ///    ESCAPE_PRIVILEDGE_CONTAINER_START:特权容器启动逃逸
        ///    ESCAPE_MOUNT_SENSITIVE_PTAH:敏感路径挂载
        /// ESCAPE_SYSCALL:Syscall逃逸
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 规则名称
        /// 宿主机文件访问逃逸、
        /// Syscall逃逸、
        /// MountNamespace逃逸、
        /// 程序提权逃逸、
        /// 特权容器启动逃逸、
        /// 敏感路径挂载
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否打开：false否 ，true是
        /// </summary>
        [JsonProperty("IsEnable")]
        public bool? IsEnable{ get; set; }

        /// <summary>
        /// 规则组别。RISK_CONTAINER：风险容器，PROCESS_PRIVILEGE：程序特权，CONTAINER_ESCAPE：容器逃逸
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsEnable", this.IsEnable);
            this.SetParamSimple(map, prefix + "Group", this.Group);
        }
    }
}

