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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Execution : AbstractModel
    {
        
        /// <summary>
        /// 任务类型，目前支持以下类型。
        /// 1. “MR”，将通过hadoop jar的方式提交。
        /// 2. "HIVE"，将通过hive -f的方式提交。
        /// 3. "SPARK"，将通过spark-submit的方式提交。
        /// </summary>
        [JsonProperty("JobType")]
        public string JobType{ get; set; }

        /// <summary>
        /// 任务参数，提供除提交指令以外的参数。
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
        }
    }
}

