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

    public class RiskSyscallWhiteListInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像id数组，为空代表全部
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }

        /// <summary>
        /// 系统调用名称，通过DescribeRiskSyscallNames接口获取枚举列表
        /// </summary>
        [JsonProperty("SyscallNames")]
        public string[] SyscallNames{ get; set; }

        /// <summary>
        /// 目标进程
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 白名单id，如果新建则id为空
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
            this.SetParamArraySimple(map, prefix + "SyscallNames.", this.SyscallNames);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

