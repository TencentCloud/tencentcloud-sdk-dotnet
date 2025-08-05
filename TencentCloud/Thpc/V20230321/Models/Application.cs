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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Application : AbstractModel
    {
        
        /// <summary>
        /// 待执行脚本命令。
        /// </summary>
        [JsonProperty("Commands")]
        public CommandItem[] Commands{ get; set; }

        /// <summary>
        /// 存储目录挂载配置。
        /// </summary>
        [JsonProperty("StorageMounts")]
        public StorageMount[] StorageMounts{ get; set; }

        /// <summary>
        /// 用户自定义环境变量。
        /// </summary>
        [JsonProperty("EnvVars")]
        public EnvVar[] EnvVars{ get; set; }

        /// <summary>
        /// 容器配置信息。
        /// </summary>
        [JsonProperty("Docker")]
        public Docker Docker{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("OutputRedirect")]
        public OutputRedirect OutputRedirect{ get; set; }

        /// <summary>
        /// 表示所选训练框架，支持可选参数
        ///  
        /// - PyTorch：表示提交PyTorch训练作业
        /// - Custom：表示用户自定义作业
        /// 
        /// 默认参数为：Custom
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Commands.", this.Commands);
            this.SetParamArrayObj(map, prefix + "StorageMounts.", this.StorageMounts);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamObj(map, prefix + "Docker.", this.Docker);
            this.SetParamObj(map, prefix + "OutputRedirect.", this.OutputRedirect);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
        }
    }
}

