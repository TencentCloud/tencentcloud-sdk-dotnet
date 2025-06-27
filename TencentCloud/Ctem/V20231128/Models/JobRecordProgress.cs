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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobRecordProgress : AbstractModel
    {
        
        /// <summary>
        /// 正在执行的任务数
        /// </summary>
        [JsonProperty("Doing")]
        public long? Doing{ get; set; }

        /// <summary>
        /// 已完成的任务数
        /// </summary>
        [JsonProperty("Done")]
        public long? Done{ get; set; }

        /// <summary>
        /// 发生错误的任务数
        /// </summary>
        [JsonProperty("Error")]
        public long? Error{ get; set; }

        /// <summary>
        /// 超时
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 停止
        /// </summary>
        [JsonProperty("Stop")]
        public long? Stop{ get; set; }

        /// <summary>
        /// 暂停
        /// </summary>
        [JsonProperty("Todo")]
        public long? Todo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Doing", this.Doing);
            this.SetParamSimple(map, prefix + "Done", this.Done);
            this.SetParamSimple(map, prefix + "Error", this.Error);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Stop", this.Stop);
            this.SetParamSimple(map, prefix + "Todo", this.Todo);
        }
    }
}

