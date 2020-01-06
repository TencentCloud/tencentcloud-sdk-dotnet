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

    public class AnonymousComputeEnv : AbstractModel
    {
        
        /// <summary>
        /// 计算环境管理类型
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// 计算环境具体参数
        /// </summary>
        [JsonProperty("EnvData")]
        public EnvData EnvData{ get; set; }

        /// <summary>
        /// 数据盘挂载选项
        /// </summary>
        [JsonProperty("MountDataDisks")]
        public MountDataDisk[] MountDataDisks{ get; set; }

        /// <summary>
        /// agent运行模式，适用于Windows系统
        /// </summary>
        [JsonProperty("AgentRunningMode")]
        public AgentRunningMode AgentRunningMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamObj(map, prefix + "EnvData.", this.EnvData);
            this.SetParamArrayObj(map, prefix + "MountDataDisks.", this.MountDataDisks);
            this.SetParamObj(map, prefix + "AgentRunningMode.", this.AgentRunningMode);
        }
    }
}

