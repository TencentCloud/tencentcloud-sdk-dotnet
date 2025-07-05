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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 修改实例操作。如填写：
        /// - rename：表示实例重命名。
        /// - modifyProject：修改实例所属项目。
        /// - modifyAutoRenew：修改实例续费标记。
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 实例 ID，请登录[Redis控制台](https://console.cloud.tencent.com/redis/instance/list)在实例列表复制实例 ID。每次请求的实例数量的上限为10。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 实例的新名称。
        /// </summary>
        [JsonProperty("InstanceNames")]
        public string[] InstanceNames{ get; set; }

        /// <summary>
        /// 项目 ID，请登录[Redis控制台的项目管理](https://console.cloud.tencent.com/project)页面，在**项目名称**中复制项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 自动续费标识。
        /// - 0：默认状态，指手动续费。
        /// - 1：自动续费。
        /// - 2：明确不自动续费。
        /// </summary>
        [JsonProperty("AutoRenews")]
        public long?[] AutoRenews{ get; set; }

        /// <summary>
        /// 目前在废弃中，存量用户还可以使用，建议新用户使用 InstanceIds。
        /// </summary>
        [JsonProperty("InstanceId")]
        [System.Obsolete]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 已经废弃
        /// </summary>
        [JsonProperty("InstanceName")]
        [System.Obsolete]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 已经废弃。
        /// </summary>
        [JsonProperty("AutoRenew")]
        [System.Obsolete]
        public long? AutoRenew{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "InstanceNames.", this.InstanceNames);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "AutoRenews.", this.AutoRenews);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
        }
    }
}

