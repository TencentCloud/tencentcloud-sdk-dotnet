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

    public class DescribeEksContainerInstanceLogRequest : AbstractModel
    {
        
        /// <summary>
        /// Eks Container Instance Id，即容器实例Id
        /// </summary>
        [JsonProperty("EksCiId")]
        public string EksCiId{ get; set; }

        /// <summary>
        /// 容器名称，单容器的实例可选填。如果为多容器实例，请指定容器名称。
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 返回最新日志行数，默认500，最大2000。日志内容最大返回 1M 数据。
        /// </summary>
        [JsonProperty("Tail")]
        public ulong? Tail{ get; set; }

        /// <summary>
        /// UTC时间，RFC3339标准
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 是否是查上一个容器（如果容器退出重启了）
        /// </summary>
        [JsonProperty("Previous")]
        public bool? Previous{ get; set; }

        /// <summary>
        /// 查询最近多少秒内的日志
        /// </summary>
        [JsonProperty("SinceSeconds")]
        public ulong? SinceSeconds{ get; set; }

        /// <summary>
        /// 日志总大小限制
        /// </summary>
        [JsonProperty("LimitBytes")]
        public ulong? LimitBytes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EksCiId", this.EksCiId);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "Tail", this.Tail);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Previous", this.Previous);
            this.SetParamSimple(map, prefix + "SinceSeconds", this.SinceSeconds);
            this.SetParamSimple(map, prefix + "LimitBytes", this.LimitBytes);
        }
    }
}

