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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBootScriptRsp : AbstractModel
    {
        
        /// <summary>
        /// 资源初始化结束自定义脚本文件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceAfter")]
        public PreExecuteFileSetting[] ResourceAfter{ get; set; }

        /// <summary>
        /// 集群启动前自定义脚本文件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterBefore")]
        public PreExecuteFileSetting[] ClusterBefore{ get; set; }

        /// <summary>
        /// 集群启动后自定义脚本文件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterAfter")]
        public PreExecuteFileSetting[] ClusterAfter{ get; set; }

        /// <summary>
        /// 服务下线前自定义脚本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceBefore")]
        public PreExecuteFileSetting[] ServiceBefore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ResourceAfter.", this.ResourceAfter);
            this.SetParamArrayObj(map, prefix + "ClusterBefore.", this.ClusterBefore);
            this.SetParamArrayObj(map, prefix + "ClusterAfter.", this.ClusterAfter);
            this.SetParamArrayObj(map, prefix + "ServiceBefore.", this.ServiceBefore);
        }
    }
}

