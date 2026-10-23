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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentRuntimeConfig : AbstractModel
    {
        
        /// <summary>
        /// 函数代码. 注意：不能同时指定Cos和ZipFile
        /// </summary>
        [JsonProperty("Code")]
        public AgentRuntimeCode Code{ get; set; }

        /// <summary>
        /// 函数运行环境，默认Python2.7
        /// 目前支持的运行环境：
        /// - Python2.7
        /// - Python3.6
        /// - Python3.7
        /// - Python3.9
        /// - Python3.10
        /// - Nodejs6.10
        /// - Nodejs8.9
        /// - Nodejs10.15
        /// - Nodejs12.16
        /// - Nodejs14.18
        /// - Nodejs16.13
        /// - Nodejs18.15
        /// - Php5.6
        /// - Php7(7.2版本)
        /// - Php7.4
        /// - Php8.0
        /// - Go1
        /// - Java8
        /// - CustomRuntime
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// 函数运行时内存大小，默认为 128M，可选范围 64、128MB-3072MB，并且以 128MB 为阶梯
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// 函数是否自动安装依赖
        /// </summary>
        [JsonProperty("InstallDependency")]
        public bool? InstallDependency{ get; set; }

        /// <summary>
        /// 函数最长执行时间，单位为秒，可选值范围 1-900 秒，默认为 3 秒
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 函数的环境变量，满足json格式
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// Agent Session 配置
        /// </summary>
        [JsonProperty("SessionConfig")]
        public AgentRuntimeSessionConfig SessionConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Code.", this.Code);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamObj(map, prefix + "SessionConfig.", this.SessionConfig);
        }
    }
}

