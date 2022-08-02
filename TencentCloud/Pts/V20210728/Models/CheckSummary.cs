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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckSummary : AbstractModel
    {
        
        /// <summary>
        /// 检查点名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 检查点所在步骤名字
        /// </summary>
        [JsonProperty("Step")]
        public string Step{ get; set; }

        /// <summary>
        /// 检查点成功次数
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// 检查失败次数
        /// </summary>
        [JsonProperty("FailCount")]
        public long? FailCount{ get; set; }

        /// <summary>
        /// 错误比例
        /// </summary>
        [JsonProperty("ErrorRate")]
        public float? ErrorRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Step", this.Step);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamSimple(map, prefix + "ErrorRate", this.ErrorRate);
        }
    }
}

