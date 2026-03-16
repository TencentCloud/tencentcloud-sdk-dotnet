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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyExternalNodePoolRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 节点池ID
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// 节点池名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 第三方节点label
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// 第三方节点taint
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// 删除保护开关
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// base64 编码的用户脚本, 此脚本会在 k8s 组件运行后执行, 需要用户保证脚本的可重入及重试逻辑, 脚本及其生成的日志文件可在节点的 /data/ccs_userscript/ 路径查看
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
        }
    }
}

