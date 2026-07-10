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

    public class DescribePGUserMigrationResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>版本号</p><p>参数格式：纯数字，14位时间格式</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>版本名</p><p>参数格式：只允许小写字母和下划线</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>要执行的migration sql 语句</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>回滚的sql 语句</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("Rollback")]
        public string Rollback{ get; set; }

        /// <summary>
        /// <p>migration query 语句的checksum值,由服务端自动生成，同版本 checksum 不一致会拒绝执行</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("Checksum")]
        public string Checksum{ get; set; }

        /// <summary>
        /// <p>用于标记调用来源</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>用于标记该条migration由谁创建，目前默认调用的用户uin</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// <p>该migration创建时间</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>该migration应用时间</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("AppliedAt")]
        public string AppliedAt{ get; set; }

        /// <summary>
        /// <p>该migration执行耗时</p><p>单位：毫秒</p><p>deprecated</p>
        /// </summary>
        [JsonProperty("DurationMs")]
        public long? DurationMs{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Rollback", this.Rollback);
            this.SetParamSimple(map, prefix + "Checksum", this.Checksum);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "AppliedAt", this.AppliedAt);
            this.SetParamSimple(map, prefix + "DurationMs", this.DurationMs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

