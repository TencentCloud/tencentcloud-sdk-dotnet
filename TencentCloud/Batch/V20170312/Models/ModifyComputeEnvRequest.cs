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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyComputeEnvRequest : AbstractModel
    {
        
        /// <summary>
        /// 计算环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 计算节点期望个数
        /// </summary>
        [JsonProperty("DesiredComputeNodeCount")]
        public long? DesiredComputeNodeCount{ get; set; }

        /// <summary>
        /// 计算环境名称
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// 计算环境描述
        /// </summary>
        [JsonProperty("EnvDescription")]
        public string EnvDescription{ get; set; }

        /// <summary>
        /// 计算环境属性数据
        /// </summary>
        [JsonProperty("EnvData")]
        public ComputeEnvData EnvData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "DesiredComputeNodeCount", this.DesiredComputeNodeCount);
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamSimple(map, prefix + "EnvDescription", this.EnvDescription);
            this.SetParamObj(map, prefix + "EnvData.", this.EnvData);
        }
    }
}

