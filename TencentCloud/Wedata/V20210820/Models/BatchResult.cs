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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchResult : AbstractModel
    {
        
        /// <summary>
        /// 正在运行的任务数
        /// </summary>
        [JsonProperty("Running")]
        public long? Running{ get; set; }

        /// <summary>
        /// 执行成功的任务数
        /// </summary>
        [JsonProperty("Success")]
        public long? Success{ get; set; }

        /// <summary>
        /// 执行失败的任务数
        /// </summary>
        [JsonProperty("Failed")]
        public long? Failed{ get; set; }

        /// <summary>
        /// 总任务数
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Running", this.Running);
            this.SetParamSimple(map, prefix + "Success", this.Success);
            this.SetParamSimple(map, prefix + "Failed", this.Failed);
            this.SetParamSimple(map, prefix + "Total", this.Total);
        }
    }
}

