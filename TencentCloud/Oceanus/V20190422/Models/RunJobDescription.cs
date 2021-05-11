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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunJobDescription : AbstractModel
    {
        
        /// <summary>
        /// 作业Id
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 运行类型，1：启动，2：恢复
        /// </summary>
        [JsonProperty("RunType")]
        public long? RunType{ get; set; }

        /// <summary>
        /// 已废弃。旧版 SQL 类型作业启动参数：指定数据源消费起始时间点
        /// </summary>
        [JsonProperty("StartMode")]
        public string StartMode{ get; set; }

        /// <summary>
        /// 当前作业的某个版本
        /// </summary>
        [JsonProperty("JobConfigVersion")]
        public ulong? JobConfigVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "StartMode", this.StartMode);
            this.SetParamSimple(map, prefix + "JobConfigVersion", this.JobConfigVersion);
        }
    }
}

