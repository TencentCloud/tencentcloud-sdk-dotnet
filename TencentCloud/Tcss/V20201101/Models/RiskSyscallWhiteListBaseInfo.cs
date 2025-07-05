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

    public class RiskSyscallWhiteListBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 白名单id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 镜像数量
        /// </summary>
        [JsonProperty("ImageCount")]
        public ulong? ImageCount{ get; set; }

        /// <summary>
        /// 连接进程路径
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 系统调用名称列表
        /// </summary>
        [JsonProperty("SyscallNames")]
        public string[] SyscallNames{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否是全局白名单，true全局
        /// </summary>
        [JsonProperty("IsGlobal")]
        public bool? IsGlobal{ get; set; }

        /// <summary>
        /// 镜像id数组
        /// </summary>
        [JsonProperty("ImageIds")]
        public string[] ImageIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ImageCount", this.ImageCount);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamArraySimple(map, prefix + "SyscallNames.", this.SyscallNames);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamArraySimple(map, prefix + "ImageIds.", this.ImageIds);
        }
    }
}

