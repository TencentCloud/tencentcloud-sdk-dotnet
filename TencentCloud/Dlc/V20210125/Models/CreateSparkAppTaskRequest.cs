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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSparkAppTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// spark作业名
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// spark作业程序入参，以空格分隔；一般用于周期性调用使用
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// 任务来源信息
        /// </summary>
        [JsonProperty("SourceInfo")]
        public KVPair[] SourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "CmdArgs", this.CmdArgs);
            this.SetParamArrayObj(map, prefix + "SourceInfo.", this.SourceInfo);
        }
    }
}

