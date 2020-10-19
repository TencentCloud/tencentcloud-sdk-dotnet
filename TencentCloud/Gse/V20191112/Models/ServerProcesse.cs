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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerProcesse : AbstractModel
    {
        
        /// <summary>
        /// 并发执行数量，所有进程并发执行总数最小值1，最大值50
        /// </summary>
        [JsonProperty("ConcurrentExecutions")]
        public ulong? ConcurrentExecutions{ get; set; }

        /// <summary>
        /// 启动路径：Linux路径/local/game/ 或WIndows路径C:\game\，最小长度1，最大长度1024
        /// </summary>
        [JsonProperty("LaunchPath")]
        public string LaunchPath{ get; set; }

        /// <summary>
        /// 启动参数，最小长度0，最大长度1024
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConcurrentExecutions", this.ConcurrentExecutions);
            this.SetParamSimple(map, prefix + "LaunchPath", this.LaunchPath);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
        }
    }
}

